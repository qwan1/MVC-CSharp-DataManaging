using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Controller
    {
        private IView view;
        private Model.Model model;
        private Hashtable t_mining_area;
        private Hashtable t_cut_info;
        private Hashtable t_cut_geom;
        public Controller(IView view, string databasePath)
        {
            model = new Model.Model(databasePath);
            this.view = view;
            view.setController(this);
            t_mining_area = model.T_mining_area;
            t_cut_info = model.T_cut_info;
            t_cut_geom = model.T_cut_geom;
            viewInitialization();
        }
        public void viewInitialization()
        {
            view.populate_t_mining_area();
            view.populate_levels(null);
            view.populate_t_cut_info(null, null, null);
            view.populate_t_cut_geom(null,0);
        }
        public class Cut_info_entry
        {
            string mining_area_name, cut_id, cut_name, tonnage, cut_level;
            public Cut_info_entry(string mining_area_name, string cut_id, string cut_name, string tonnage, string cut_level)
            {
                this.mining_area_name = String.Copy(mining_area_name);
                this.cut_id = String.Copy(cut_id);
                this.cut_name = String.Copy(cut_name);
                this.tonnage = String.Copy(tonnage);
                this.cut_level = String.Copy(cut_level);
            }
            public string Mining_area_name
            {
                get { return mining_area_name; }
            }
            public string Cut_id
            {
                get { return cut_id; }
            }
            public string Cut_name
            {
                get { return cut_name; }
            }
            public string Tonnage
            {
                get { return tonnage; }
            }
            public string Cut_level
            {
                get { return cut_level; }
            }
        }
        public class Cut_geom_entry
        {
            string cut_id, x1, y1, z1;
            public Cut_geom_entry(string cut_id, string x1, string y1, string z1)
            {
                this.cut_id = String.Copy(cut_id);
                this.x1 = String.Copy(x1);
                this.z1 = String.Copy(z1);
                this.y1 = String.Copy(y1);
            }
            public string Cut_id
            {
                get { return cut_id; }
            }
            public string X1
            {
                get { return x1; }
            }
            public string Y1
            {
                get { return y1; }
            }
            public string Z1
            {
                get { return z1; }
            }
        }
        // Give a mining_area_name, a cut_level, and a cut_id, return the reference of the 
        // data in the form of Hashtable<list<Hashtable>>, when mining_area_name, cut_level, or cut_id is null,
        // it means it could be any values.
        public Hashtable select(Hashtable reference, string mining_area_name, string cut_level, string cut_id)
        {
            return model.select_cuts(reference, mining_area_name, cut_level, cut_id);
        }

        public ICollection<string> getMiningAreaList()
        {
            ICollection<string> collection = new Collection<string>();
            foreach (var key in T_mining_area.Keys)
            {
                collection.Add((string)key);
            }
            return collection;
        }
        public int getMiningAreaCount()
        {
            return T_mining_area.Count;
        }
        // return a list of the name the level with no duplication
        public ICollection<string> getLevelList(string mining_area_name)
        {
            ICollection<string> collection;
            if (String.IsNullOrEmpty(mining_area_name))
            {
                collection = new HashSet<string>(); // high perforanmance for collection with no duplications
                foreach (string miningAreaName in model.T_mining_area.Keys)
                {
                    ICollection<string> levels = model.returnLevels(miningAreaName).Keys;
                    foreach (var i in levels)
                    {
                            collection.Add(i);
                    }
                }
            }
            else
            {
                collection = model.returnLevels(mining_area_name).Keys;
            }
            return collection;
        }
        // Get disinct number of the level in the database.
        // This function is unused but I write it anyway in case someone needs it.
        public int getLevelCount(string mining_area_name)
        {
            ICollection<string> collection;
            if (String.IsNullOrEmpty(mining_area_name))
            {
                collection = new HashSet<string>(); // high perforanmance for collection with no duplications
                foreach (string miningAreaName in model.T_mining_area.Keys)
                {
                    ICollection<string> levels = model.returnLevels(miningAreaName).Keys;
                    foreach (var i in levels)
                    {
                        collection.Add(i);
                    }
                }
            }
            else
            {
                collection = model.returnLevels(mining_area_name).Keys;
            }
            return collection.Count;
        }
        // Give a mining_area_name, return a list of the distinct levels with no duplication 
        // alone with its mining_area_name.
        public ICollection<KeyValuePair<string,string>> getLevelListWithAreaName(string mining_area_name)
        {
            ICollection<KeyValuePair<string, string>> collection;
            collection = new HashSet<KeyValuePair<string, string>>(); // high perforanmance for collection with no duplications
            if (String.IsNullOrEmpty(mining_area_name))
            {            
                foreach (string miningAreaName in model.T_mining_area.Keys)
                {
                    ICollection<string> levels = model.returnLevels(miningAreaName).Keys;
                    foreach (var i in levels)
                    {
                        collection.Add(new KeyValuePair<string,string>(miningAreaName, i));
                    }
                }
            }
            else
            {
                ICollection<string> levels = model.returnLevels(mining_area_name).Keys;
                foreach (var i in levels)
                {
                    collection.Add(new KeyValuePair<string, string>(mining_area_name, i));
                }
            }
            return collection;
        }
        // Return a list of disctinct cut_id from the table t_cut_info, when given a mining_area_name, cut_level and cut_id)
        public ICollection<string> getCutIdList(string mining_area_name, string cut_level, string cut_id)
        {
            Hashtable hashTable = model.select_cuts(T_cut_info,mining_area_name, cut_level, cut_id);
            ICollection<string> collection = new Collection<string>();
            foreach (DictionaryEntry pair in hashTable)
            {
                collection.Add((string)pair.Key);
            }
            return collection;
        }
        //  Return a list of disctinct cut_id from the table t_cut_geom, when given a mining_area_name, cut_level and cut_id)
        public ICollection<string> getCutIdListFromCutGeom(string cut_id)
        {
            Hashtable hashTable = model.select_cuts_from_cut_geom(cut_id,0);
            ICollection<string> collection = new Collection<string>();
            foreach (DictionaryEntry pair in hashTable)
            {
                collection.Add((string)pair.Key);
            }
            return collection;
        }
        // Return a list of cut_geom (not distinct) when giving a cut_id, along with its attributes.
        public ICollection<Cut_geom_entry> getCutGeom(string cut_id, double x1)
        {
            Hashtable hashTable = model.select_cuts_from_cut_geom(cut_id,x1);
            ICollection<Cut_geom_entry> collection = new Collection<Cut_geom_entry>();
            foreach (DictionaryEntry entry in hashTable)
            {
                var ht = entry.Value;
                foreach (DictionaryEntry pair in (Hashtable)ht)
                {
                    foreach (var value in (List<Hashtable>)pair.Value)
                    {
                        Cut_geom_entry returnEntry = new Cut_geom_entry((string)entry.Key, pair.Key.ToString(),
                                                                 (string)value["y1"].ToString(), (string)value["z1"].ToString());
                        collection.Add(returnEntry);
                    }
                }
            }

            return collection;
        }
        // Return the ist
        public ICollection<Cut_info_entry> getCutInfo(string mining_area_name, string cut_level, string cut_id)
        {
            Hashtable hashTable = model.select_cuts(T_cut_info, mining_area_name, cut_level, cut_id);
            ICollection<Cut_info_entry> collection = new Collection<Cut_info_entry>();
            foreach (DictionaryEntry pair in hashTable)
            {
                foreach (var value in (List<Hashtable>)pair.Value)
                {
                    Cut_info_entry entry = new Cut_info_entry((string)value["mining_area_name"], (string)pair.Key, (string)value["cut_name"],
                                                               value["tonnage"].ToString(), (string)value["cut_level"]);
                    collection.Add(entry);
                }
            }
            return collection;
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
    }
}
