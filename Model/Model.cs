
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Model
    {
        // I build three Hashtables to hold the three tables in the database. 
        // 1. The first table is t_mining_area, its structure is Hashtable<mining_area_name,mining_area_type>
        // 2. The second table is t_cut_info, its structure is Hashtable<cut_id,List<Hashtable<attribute_name,attribute_content>> 
        // the list is in the second table is for the collisions if two rows have the same cut_id
        // 3. The third table is t_cut_geom, its structure is Hashtable<cut_id, Hashtable<x1,List<(y1 or z1)>>
        // I used second hashtable because there is too many collision, then I use x1 for the second Hashtable key.
        // Because the cut_id is not the primary key of both table, the table cannot be held just by a simple hashtable.
        // The duplication of cut_id makes the data structure hard to understand, and it makes it impossible to join table t_cut_info 
        // and table t_cut_geom. I recommend to make the cut_id distinct.
        // 4. I build a tree structure from table t_cut_info, which only holds the cut_id element. It allow us to find the cut_id with 
        // certain mining_area_name and cut_level, and find the rest of attributes by using the hashtable key "cut_id".
        private Hashtable t_mining_area;
        private Hashtable t_cut_info; // cut_id is the key, values are other attributes in t_cut_info table
        private Hashtable t_cut_geom; // cut_id is the key, values are other attributes in t_cut_geom table
        IDictionary<string, Mining_Area> miningAreas;
        public class Mining_Area
        {
            private string mining_area_name;
            private IDictionary<string, Level> levels = new Dictionary<string, Level>();
            public Mining_Area(string mining_area_name)
            {
                this.mining_area_name = mining_area_name;
            }
            public string Mining_area_name
            {
                get { return mining_area_name; }
                set { mining_area_name = value; }
            }
            public IDictionary<string, Level> Levels
            {
                get { return levels; }
                set { levels = value; }
            }
        }
        public IDictionary<string, Level> returnLevels(string mining_area_name)
        {
            return miningAreas[mining_area_name].Levels;
        }
        public class Level
        {
            private string cut_level;
            IDictionary<string, string> cuts = new Dictionary<string, string>();
            public Level(string cut_level)
            {
                this.cut_level = cut_level;
            }
            public string Cut_level
            {
                get { return cut_level; }
                set { cut_level = value; }
            }
            public IDictionary<string, string> Cuts
            {
                get { return cuts; }
                set { cuts = value; }
            }
        }
        public Hashtable T_mining_area
        {
            get { return t_mining_area; }
        }
        public Hashtable T_cut_info
        {
            get { return t_cut_info; }
        }
        public Hashtable T_cut_geom
        {
            get { return t_cut_geom; }
        }
        public Model(string databasePath)
        {
            load_all_tables(databasePath);
        }
        public SQLiteConnection SqliteConnection(string databasePath)
        {
            string connection = "Data Source=" + databasePath;
            SQLiteConnection m_dbConnection = new SQLiteConnection(connection);
            m_dbConnection.Open();
            return m_dbConnection;
        }
        private void load_t_mining_area(SQLiteConnection m_dbConnection)
        {
            IDictionary<string, Mining_Area> miningAreas = new Dictionary<string, Mining_Area>();
            t_mining_area = new Hashtable();
            string sql = "select * from t_mining_area";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // load table t_mining_area
                var mining_area_name = (string)reader["mining_area_name"];
                t_mining_area.Add(mining_area_name, (string)reader["mining_area_type"]);

            }

        }
        private void load_t_cut_info(SQLiteConnection m_dbConnection)
        {
            t_cut_info = new Hashtable();
            miningAreas = new Dictionary<string, Mining_Area>();
            string sql = "select * from t_cut_info";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // load table t_cut_info
                // The data strucre of the tree is 
                // Hashtable<List<Hashtable>>
                Hashtable values = new Hashtable();
                string cut_id = (string)reader["cut_id"];
                string mining_area_name = (string)reader["mining_area_name"];
                string cut_name = (string)reader["cut_name"];
                double tonnage = (double)reader["tonnage"];
                string cut_level = (string)reader["cut_level"];
                values.Add("mining_area_name", mining_area_name);
                values.Add("cut_name", cut_name);
                values.Add("tonnage", tonnage);
                values.Add("cut_level", cut_level);
                values.Add("cut_id_copy", cut_id); // this one is used for reference if we want to update the database
                if (t_cut_info[cut_id] == null)
                {
                    var list = new List<Hashtable>();
                    values.Add("listPointer", list);
                    list.Add(values);
                    t_cut_info.Add(cut_id, list); 
                    // found out that the "cut_id" is not unique, GUID80e3668a51ca4a418d3bfc71e07d9426 occurs twice in this table
                }
                else
                {
                    var list = (List<Hashtable>)t_cut_info[cut_id];
                    list.Add(values);
                }


                // Build a tree structure index for the cut_id, so that we can get the cuts with the same mining_area_name, cut_level
                // or cut_id
                if (!miningAreas.ContainsKey(mining_area_name))
                {
                    miningAreas.Add(mining_area_name, new Mining_Area(mining_area_name));
                }
                Mining_Area mining_Area = miningAreas[mining_area_name];
                if (!mining_Area.Levels.ContainsKey(cut_level))
                {
                    mining_Area.Levels.Add(cut_level, new Level(cut_level));
                }
                Level level = mining_Area.Levels[cut_level];
                if (!level.Cuts.ContainsKey(cut_id))
                {
                    level.Cuts.Add(cut_id, cut_name);
                }
            }
        }
        private void load_t_cut_geom(SQLiteConnection m_dbConnection)
        {
            t_cut_geom = new Hashtable();
            string sql = "select * from t_cut_geom";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Hashtable values = new Hashtable();
                string cut_id = (string)reader["cut_id"];
                double x1 = (double)reader["X1"];
                double y1 = (double)reader["Y1"];
                double z1 = (double)reader["Z1"];
                values.Add("y1", y1);
                values.Add("z1", z1);
                if (t_cut_geom[cut_id] == null)
                {
                    var hashtable = new Hashtable();
                    var list = new List<Hashtable>();
                    list.Add(values);
                    hashtable.Add(x1,list);
                    // found out that the "cut_id" is not unique. There are more than 90000 rows in the table, but there is only about 2000 cut_ids,
                    // than I added x1 as the key of the hashtable that I stored for each cut_id, 
                    t_cut_geom.Add(cut_id, hashtable);
                }
                else
                {
                    var hashtable = (Hashtable)t_cut_geom[cut_id];
                    if (hashtable[x1] == null)
                    {
                        var list = new List<Hashtable>();
                        list.Add(values);
                        hashtable.Add(x1, list);
                    }
                    else {
                        ((List<Hashtable>)hashtable[x1]).Add(values);
                    }                    
                }
            }
        }
     
        public void load_all_tables(string databasePath)
        {
            SQLiteConnection connection = SqliteConnection(databasePath);
            load_t_mining_area(connection);
            load_t_cut_info(connection);
            load_t_cut_geom(connection);
        }
        // select cut from the referenced table, given the mining_area_name, cut_level, cut_id
        public Hashtable select_cuts(Hashtable reference, string mining_area_name, string cut_level, string cut_id)
        {
            Hashtable hashTable = new Hashtable();
            if (cut_id != null && !cut_id.Equals(""))
            {
                hashTable = select_by_id(reference, mining_area_name, cut_level, cut_id);
            }
            else
            {
                if (String.IsNullOrEmpty(mining_area_name))
                {
                    foreach (var key in miningAreas.Keys)
                    {
                        select_not_by_id(reference, key, cut_level, hashTable);
                    }
                }
                else
                {
                    select_not_by_id(reference, mining_area_name, cut_level, hashTable);
                }
            }
            return hashTable;
        }
        // select the cut, given the mining_area_name and the cut_level.
        private void select_not_by_id(Hashtable reference, string mining_area_name, string cut_level, Hashtable hashTable)
        {
            if (String.IsNullOrEmpty(cut_level))
            {
                foreach (var level in (miningAreas[mining_area_name].Levels.Values))
                {

                    foreach (var key in level.Cuts.Keys)
                    {
                        List<Hashtable> selectedRows;
                        if (!hashTable.Contains(key))
                        {
                            selectedRows = new List<Hashtable>();
                            hashTable.Add(key, selectedRows);
                        }
                        else
                        {
                            selectedRows = (List<Hashtable>)hashTable[key];
                        }
                        // reference the list of hashtables that a cut_id could have, because a cut_id could have multiple 
                        // cosreponding values.
                        foreach (var ht in (List<Hashtable>)reference[key])
                        {
                            if (ht["mining_area_name"].Equals(mining_area_name))
                            {
                                selectedRows.Add(ht);
                            }
                        }

                    }

                }
            }
            else
            {
                foreach (var key in miningAreas[mining_area_name].Levels[cut_level].Cuts.Keys)
                {
                    // reference the list of hashtables that a cut_id could have, because a cut_id could have multiple 
                    // cosreponding values.
                    List<Hashtable> selectedRows;
                    if (!hashTable.Contains(key))
                    {
                        selectedRows = new List<Hashtable>();
                        hashTable.Add(key, selectedRows);
                    }
                    else
                    {
                        selectedRows = (List<Hashtable>)hashTable[key];
                    }
                    foreach (var ht in (List<Hashtable>)reference[key])
                    {
                        if (ht["mining_area_name"].Equals(mining_area_name) && ht["cut_level"].Equals(cut_level))
                        {
                            selectedRows.Add(ht);
                        }
                    }
                }
            }
            return;
        }
        // find the cut, given the cut_id, then check whether its mining_area_name and cut_level are the same as the given ones.
        private Hashtable select_by_id(Hashtable reference, string mining_area_name, string cut_level, string cut_id)
        {
            var hashTable = new Hashtable();
            var list = (List<Hashtable>)reference[cut_id];
            var selectedRows = new List<Hashtable>();
            foreach (var ht in list)
            {
                if (String.IsNullOrEmpty(mining_area_name))
                    mining_area_name = (string)ht["mining_area_name"];
                if (String.IsNullOrEmpty(cut_level))
                    cut_level = (string)ht["cut_level"];
                if (mining_area_name.Equals((string)ht["mining_area_name"]) && cut_level.Equals((string)ht["cut_level"]))
                {
                    selectedRows.Add(ht);
                }
            }
            hashTable.Add(cut_id, selectedRows); // Add the reference 
            return hashTable; // return the reference of the selected rows
        }
        // If cut_id is null, it means it could be any value. If x1 is 0, it also means x1 could be any value. 
        public Hashtable select_cuts_from_cut_geom(string cut_id, double x1)
        {
            Hashtable ht;
            if (String.IsNullOrEmpty(cut_id) && x1==0)
            {
                return T_cut_geom;
            }
            else
            {
                ht = new Hashtable();
                if (x1 == 0) {
                    ht.Add(cut_id, T_cut_geom[cut_id]);
                }
                else
                {
                    Hashtable h = new Hashtable(); // second hashtable that it is in the cut_geom hashtable
                    h.Add(x1,((Hashtable)T_cut_geom[cut_id])[x1]);
                    ht.Add(cut_id, h);
                }
            }
            return ht;
        }

    }

}
