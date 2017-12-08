using Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Controller.Controller;

namespace View
{
    public partial class View1 : Form, IView
    {
        Controller.Controller controller;
        string[] cutInfoCombo_text, levelCombo_text, cutGeomCombo_text;
        public View1()
        {
            InitializeComponent();
            initializeComboText(1,3,2);
        }
        public void populate_t_mining_area()
        {
            int count = 0;
            foreach (DictionaryEntry pair in controller.T_mining_area)
            {
                string[] str = { (string)pair.Key, (string)pair.Value };
                dataGridMiningArea.Rows.Add(str);
                count++;
            }
            MiningAreaTextBox.Text = "The total number of the mining areas is:  " + count;
        }
        public void populate_levels(string mining_area_name)
        {
            if (levelCombo1.Items.Count == 0)
            {
                populateComboBox(levelCombo1, controller.getMiningAreaList());
            }
            dataGridLevels.Rows.Clear();
            ICollection<KeyValuePair<string,string>> collection = controller.getLevelListWithAreaName(mining_area_name);
            foreach (var pair in collection)
            {
                string[] str = { pair.Key, pair.Value };
                dataGridLevels.Rows.Add(str);
            }
            if (collection.Count != 1) {
                levelsTextBox.Text = "The number of the levels is: " + collection.Count;
            }
            else
            {
                levelsTextBox.Text = "The number of the level is: 1";
            }
        }

        // public Hashtable select_rows(Hashtable reference, string mining_area_name, string cut_level, string cut_id)
        public void populate_t_cut_info(string mining_area_name, string cut_level, string cut_id)
        {          
            if (cutInfoCombo1.Items.Count == 0)
            {
                populateComboBox(cutInfoCombo1, controller.getMiningAreaList());
            }
            dataGridCutInfo.Rows.Clear();
            int count = 0;
            ICollection<Cut_info_entry> collection = controller.getCutInfo(mining_area_name, cut_level, cut_id);
            foreach (var entry in collection)
            {
                string[] str = { entry.Mining_area_name, entry.Cut_level, entry.Cut_id, entry.Cut_name, entry.Tonnage };
                dataGridCutInfo.Rows.Add(str);
                count++;
            }
            if (count == 1)
            {
                cutInfoTextBox.Text = "The number of the cut is:  " + count;
            }
            else
            {
                cutInfoTextBox.Text = "The number of the cuts is:  " + count;
            }
        }
        public void populate_t_cut_geom(string cut_id, double x1)
        {
            if (cutGeomCombo1.Items.Count == 0)
            {
                populateComboBox(cutGeomCombo1, controller.getCutIdListFromCutGeom(null));
            }
            dataGridCutGeom.Rows.Clear();
            ICollection<Cut_geom_entry> collection = controller.getCutGeom(cut_id,x1); // 0 mens x1 could be any value
            int count = 0;
            foreach (var entry in collection)
            {
                // the dataGrid cannot hold 90000 rows, it breaks if it is more than it can hold,
                // I tried (count>20000) and it worked. But it would need more time to load the data to the dataGrid.
                if (count > 3000) break;
                string[] str = { entry.Cut_id, entry.X1, entry.Y1, entry.Z1 };
                dataGridCutGeom.Rows.Add(str);
                count++;
            }
            count = collection.Count();
            if (count == 1)
            {
                cutGeomTextBox.Text = "The number of the row in the table is:  " + count;
            }
            else
            {
                cutGeomTextBox.Text = "The number of the rows in the table is:  " + count;
            }
            return;
        }

        public void setController(Controller.Controller controller)
        {
            this.controller = controller;
        }
        private void populateComboBox(ComboBox comboBox, ICollection<string> list)
        {
            comboBox.Items.Add("All");
            foreach (string key in list)
            {
                comboBox.Items.Add(key);
            }
        }
        private void cutInfoCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ICollection<string> list;
            var selected = (string)cutInfoCombo1.SelectedItem;
            cutInfoCombo2.Items.Clear();
            if (selected.Equals("All"))
            {
                cutInfoCombo_text[0] = null;
            }
            else
            {
                cutInfoCombo_text[0] = String.Copy(selected);              
            }
            list = controller.getLevelList(cutInfoCombo_text[0]);
            cutInfoCombo3.Items.Clear();
            populateComboBox(cutInfoCombo2, list);
            populate_t_cut_info(cutInfoCombo_text[0], cutInfoCombo_text[1], cutInfoCombo_text[2]);
        }
        private void cutInfoCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (string)cutInfoCombo2.SelectedItem;
            if (selected.Equals("All"))
            {
                cutInfoCombo_text[1] = null;
            }
            else
            {
                cutInfoCombo_text[1] = String.Copy(selected);
            }
            ICollection<string> list = controller.getCutIdList(cutInfoCombo_text[0], cutInfoCombo_text[1], null);
            cutInfoCombo3.Items.Clear();
            populateComboBox(cutInfoCombo3, list);
            populate_t_cut_info(cutInfoCombo_text[0], cutInfoCombo_text[1], cutInfoCombo_text[2]);
        }


        private void cutInfoCombo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (string)cutInfoCombo3.SelectedItem;
            if (selected.Equals("All"))
            {
                cutInfoCombo_text[2] = null;
            }
            else
            {
                cutInfoCombo_text[2] = String.Copy(selected);
            }
            populate_t_cut_info(cutInfoCombo_text[0], cutInfoCombo_text[1], cutInfoCombo_text[2]);
        }
        private void levelCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (string)levelCombo1.SelectedItem;
            if (selected.Equals("All"))
            {
                levelCombo_text[0] = null;
            }
            else
            {
                levelCombo_text[0] = String.Copy(selected);
            }
            populate_levels(levelCombo_text[0]);
        }



        private void cutGeomCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (string)cutGeomCombo1.SelectedItem;
            if (selected.Equals("All"))
            {
                cutGeomCombo_text[0] = null;
            }
            else
            {
                cutGeomCombo_text[0] = String.Copy(selected);
            }
            populate_t_cut_geom(cutGeomCombo_text[0],0);
            ICollection<Cut_geom_entry> collection = controller.getCutGeom(cutGeomCombo_text[0], 0); // 0 mens x1 could be any value
            var hashSet = new HashSet<string>();
            cutGeomCombo2.Items.Clear();
            foreach (var entry in collection)
                hashSet.Add(entry.X1);
            populateComboBox(cutGeomCombo2, hashSet);
        }

        private void cutGeomCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (string)cutGeomCombo2.SelectedItem;
            if (selected.Equals("All"))
            {
                cutGeomCombo_text[1] = null;
                populate_t_cut_geom(cutGeomCombo_text[0], 0);
            }
            else
            {
                cutGeomCombo_text[1] = String.Copy(selected);
                populate_t_cut_geom(cutGeomCombo_text[0], Convert.ToDouble(cutGeomCombo_text[1]));
            }
        }


        public void initializeComboText(int num_levelCombo, int num_cutInfoCombo, int num_cutGeomCombo)
        {
            levelCombo_text = new string[num_levelCombo];
            cutInfoCombo_text = new string[num_cutInfoCombo];
            cutGeomCombo_text = new string[num_cutGeomCombo];
            for (var i = 0; i < num_levelCombo; i++)
            {
                levelCombo_text[i] = null;
            }
            for (var i = 0; i < num_cutInfoCombo; i++)
            {
                cutInfoCombo_text[i] = null;
            }
            for (var i = 0; i < num_cutGeomCombo; i++)
            {
                cutGeomCombo_text[i] = null;
            }
        }
    }
}
