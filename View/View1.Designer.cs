namespace View
{
    partial class View1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tMiningArea = new System.Windows.Forms.TabPage();
            this.MiningAreaTextBox = new System.Windows.Forms.TextBox();
            this.dataGridMiningArea = new System.Windows.Forms.DataGridView();
            this.t_mining_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mining_area_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levels = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.levelsTextBox = new System.Windows.Forms.TextBox();
            this.levelCombo1 = new System.Windows.Forms.ComboBox();
            this.dataGridLevels = new System.Windows.Forms.DataGridView();
            this.mining_area_name_levels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cut_level_levels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCutInfo = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cutInfoCombo3 = new System.Windows.Forms.ComboBox();
            this.cutInfoCombo2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cutInfoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridCutInfo = new System.Windows.Forms.DataGridView();
            this.mining_area_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cut_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cut_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cut_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonnage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutInfoCombo1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tCutGeom = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cutGeomCombo1 = new System.Windows.Forms.ComboBox();
            this.cutGeomTextBox = new System.Windows.Forms.TextBox();
            this.dataGridCutGeom = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cutGeomCombo2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tMiningArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMiningArea)).BeginInit();
            this.levels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLevels)).BeginInit();
            this.tCutInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCutInfo)).BeginInit();
            this.tCutGeom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCutGeom)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tMiningArea);
            this.tabControl1.Controls.Add(this.levels);
            this.tabControl1.Controls.Add(this.tCutInfo);
            this.tabControl1.Controls.Add(this.tCutGeom);
            this.tabControl1.Location = new System.Drawing.Point(41, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1185, 622);
            this.tabControl1.TabIndex = 0;
            // 
            // tMiningArea
            // 
            this.tMiningArea.Controls.Add(this.MiningAreaTextBox);
            this.tMiningArea.Controls.Add(this.dataGridMiningArea);
            this.tMiningArea.Location = new System.Drawing.Point(4, 25);
            this.tMiningArea.Name = "tMiningArea";
            this.tMiningArea.Padding = new System.Windows.Forms.Padding(3);
            this.tMiningArea.Size = new System.Drawing.Size(1177, 593);
            this.tMiningArea.TabIndex = 0;
            this.tMiningArea.Text = "t_mining_area";
            this.tMiningArea.UseVisualStyleBackColor = true;
            // 
            // MiningAreaTextBox
            // 
            this.MiningAreaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MiningAreaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiningAreaTextBox.Location = new System.Drawing.Point(234, 12);
            this.MiningAreaTextBox.Name = "MiningAreaTextBox";
            this.MiningAreaTextBox.Size = new System.Drawing.Size(357, 15);
            this.MiningAreaTextBox.TabIndex = 1;
            // 
            // dataGridMiningArea
            // 
            this.dataGridMiningArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMiningArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t_mining_area,
            this.mining_area_type});
            this.dataGridMiningArea.Location = new System.Drawing.Point(3, 45);
            this.dataGridMiningArea.Name = "dataGridMiningArea";
            this.dataGridMiningArea.RowTemplate.Height = 24;
            this.dataGridMiningArea.Size = new System.Drawing.Size(543, 552);
            this.dataGridMiningArea.TabIndex = 0;
            // 
            // t_mining_area
            // 
            this.t_mining_area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t_mining_area.HeaderText = "t_mining_area";
            this.t_mining_area.Name = "t_mining_area";
            // 
            // mining_area_type
            // 
            this.mining_area_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mining_area_type.HeaderText = "mining_area_type";
            this.mining_area_type.Name = "mining_area_type";
            // 
            // levels
            // 
            this.levels.Controls.Add(this.textBox4);
            this.levels.Controls.Add(this.levelsTextBox);
            this.levels.Controls.Add(this.levelCombo1);
            this.levels.Controls.Add(this.dataGridLevels);
            this.levels.Location = new System.Drawing.Point(4, 25);
            this.levels.Name = "levels";
            this.levels.Padding = new System.Windows.Forms.Padding(3);
            this.levels.Size = new System.Drawing.Size(1177, 593);
            this.levels.TabIndex = 1;
            this.levels.Text = "levels";
            this.levels.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(6, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 15);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Mining Area: ";
            // 
            // levelsTextBox
            // 
            this.levelsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelsTextBox.Location = new System.Drawing.Point(288, 24);
            this.levelsTextBox.Name = "levelsTextBox";
            this.levelsTextBox.Size = new System.Drawing.Size(248, 15);
            this.levelsTextBox.TabIndex = 2;
            // 
            // levelCombo1
            // 
            this.levelCombo1.FormattingEnabled = true;
            this.levelCombo1.Location = new System.Drawing.Point(89, 21);
            this.levelCombo1.Name = "levelCombo1";
            this.levelCombo1.Size = new System.Drawing.Size(130, 24);
            this.levelCombo1.TabIndex = 1;
            this.levelCombo1.SelectedIndexChanged += new System.EventHandler(this.levelCombo1_SelectedIndexChanged);
            // 
            // dataGridLevels
            // 
            this.dataGridLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mining_area_name_levels,
            this.cut_level_levels});
            this.dataGridLevels.Location = new System.Drawing.Point(0, 59);
            this.dataGridLevels.Name = "dataGridLevels";
            this.dataGridLevels.RowTemplate.Height = 24;
            this.dataGridLevels.Size = new System.Drawing.Size(536, 534);
            this.dataGridLevels.TabIndex = 0;
            // 
            // mining_area_name_levels
            // 
            this.mining_area_name_levels.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mining_area_name_levels.HeaderText = "mining_area_name";
            this.mining_area_name_levels.Name = "mining_area_name_levels";
            // 
            // cut_level_levels
            // 
            this.cut_level_levels.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cut_level_levels.HeaderText = "cut_level";
            this.cut_level_levels.Name = "cut_level_levels";
            // 
            // tCutInfo
            // 
            this.tCutInfo.Controls.Add(this.textBox3);
            this.tCutInfo.Controls.Add(this.cutInfoCombo3);
            this.tCutInfo.Controls.Add(this.cutInfoCombo2);
            this.tCutInfo.Controls.Add(this.textBox2);
            this.tCutInfo.Controls.Add(this.cutInfoTextBox);
            this.tCutInfo.Controls.Add(this.dataGridCutInfo);
            this.tCutInfo.Controls.Add(this.cutInfoCombo1);
            this.tCutInfo.Controls.Add(this.textBox1);
            this.tCutInfo.Location = new System.Drawing.Point(4, 25);
            this.tCutInfo.Name = "tCutInfo";
            this.tCutInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tCutInfo.Size = new System.Drawing.Size(1177, 593);
            this.tCutInfo.TabIndex = 2;
            this.tCutInfo.Text = "t_cut_info";
            this.tCutInfo.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(376, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 15);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Cut ID:";
            // 
            // cutInfoCombo3
            // 
            this.cutInfoCombo3.FormattingEnabled = true;
            this.cutInfoCombo3.Location = new System.Drawing.Point(427, 15);
            this.cutInfoCombo3.Name = "cutInfoCombo3";
            this.cutInfoCombo3.Size = new System.Drawing.Size(342, 24);
            this.cutInfoCombo3.TabIndex = 5;
            this.cutInfoCombo3.SelectedIndexChanged += new System.EventHandler(this.cutInfoCombo3_SelectedIndexChanged);
            // 
            // cutInfoCombo2
            // 
            this.cutInfoCombo2.FormattingEnabled = true;
            this.cutInfoCombo2.Location = new System.Drawing.Point(266, 17);
            this.cutInfoCombo2.Name = "cutInfoCombo2";
            this.cutInfoCombo2.Size = new System.Drawing.Size(88, 24);
            this.cutInfoCombo2.TabIndex = 4;
            this.cutInfoCombo2.SelectedIndexChanged += new System.EventHandler(this.cutInfoCombo2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(195, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 15);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Cut Level:";
            // 
            // cutInfoTextBox
            // 
            this.cutInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cutInfoTextBox.Location = new System.Drawing.Point(852, 21);
            this.cutInfoTextBox.Name = "cutInfoTextBox";
            this.cutInfoTextBox.Size = new System.Drawing.Size(322, 15);
            this.cutInfoTextBox.TabIndex = 2;
            // 
            // dataGridCutInfo
            // 
            this.dataGridCutInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCutInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mining_area_name,
            this.cut_level,
            this.cut_id,
            this.cut_name,
            this.tonnage});
            this.dataGridCutInfo.Location = new System.Drawing.Point(16, 57);
            this.dataGridCutInfo.Name = "dataGridCutInfo";
            this.dataGridCutInfo.RowTemplate.Height = 24;
            this.dataGridCutInfo.Size = new System.Drawing.Size(1143, 509);
            this.dataGridCutInfo.TabIndex = 0;
            // 
            // mining_area_name
            // 
            this.mining_area_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mining_area_name.HeaderText = "mining_area_name";
            this.mining_area_name.Name = "mining_area_name";
            // 
            // cut_level
            // 
            this.cut_level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cut_level.HeaderText = "cut_level";
            this.cut_level.Name = "cut_level";
            // 
            // cut_id
            // 
            this.cut_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cut_id.HeaderText = "cut_id";
            this.cut_id.Name = "cut_id";
            this.cut_id.Width = 75;
            // 
            // cut_name
            // 
            this.cut_name.HeaderText = "cut_name";
            this.cut_name.Name = "cut_name";
            this.cut_name.Width = 150;
            // 
            // tonnage
            // 
            this.tonnage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tonnage.HeaderText = "tonnage";
            this.tonnage.Name = "tonnage";
            // 
            // cutInfoCombo1
            // 
            this.cutInfoCombo1.FormattingEnabled = true;
            this.cutInfoCombo1.Location = new System.Drawing.Point(92, 18);
            this.cutInfoCombo1.Name = "cutInfoCombo1";
            this.cutInfoCombo1.Size = new System.Drawing.Size(83, 24);
            this.cutInfoCombo1.Sorted = true;
            this.cutInfoCombo1.TabIndex = 1;
            this.cutInfoCombo1.SelectedIndexChanged += new System.EventHandler(this.cutInfoCombo1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Mining Area:";
            // 
            // tCutGeom
            // 
            this.tCutGeom.Controls.Add(this.cutGeomCombo2);
            this.tCutGeom.Controls.Add(this.textBox6);
            this.tCutGeom.Controls.Add(this.textBox5);
            this.tCutGeom.Controls.Add(this.cutGeomCombo1);
            this.tCutGeom.Controls.Add(this.cutGeomTextBox);
            this.tCutGeom.Controls.Add(this.dataGridCutGeom);
            this.tCutGeom.Location = new System.Drawing.Point(4, 25);
            this.tCutGeom.Name = "tCutGeom";
            this.tCutGeom.Size = new System.Drawing.Size(1177, 593);
            this.tCutGeom.TabIndex = 3;
            this.tCutGeom.Text = "t_cut_geom";
            this.tCutGeom.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(31, 30);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 15);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Cut ID:";
            // 
            // cutGeomCombo1
            // 
            this.cutGeomCombo1.FormattingEnabled = true;
            this.cutGeomCombo1.Location = new System.Drawing.Point(82, 27);
            this.cutGeomCombo1.Name = "cutGeomCombo1";
            this.cutGeomCombo1.Size = new System.Drawing.Size(342, 24);
            this.cutGeomCombo1.TabIndex = 13;
            this.cutGeomCombo1.SelectedIndexChanged += new System.EventHandler(this.cutGeomCombo1_SelectedIndexChanged);
            // 
            // cutGeomTextBox
            // 
            this.cutGeomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cutGeomTextBox.Location = new System.Drawing.Point(712, 30);
            this.cutGeomTextBox.Name = "cutGeomTextBox";
            this.cutGeomTextBox.Size = new System.Drawing.Size(322, 15);
            this.cutGeomTextBox.TabIndex = 10;
            // 
            // dataGridCutGeom
            // 
            this.dataGridCutGeom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCutGeom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.x1,
            this.y1,
            this.z1});
            this.dataGridCutGeom.Location = new System.Drawing.Point(9, 63);
            this.dataGridCutGeom.Name = "dataGridCutGeom";
            this.dataGridCutGeom.RowTemplate.Height = 24;
            this.dataGridCutGeom.Size = new System.Drawing.Size(995, 509);
            this.dataGridCutGeom.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "cut_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // x1
            // 
            this.x1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.x1.HeaderText = "x1";
            this.x1.Name = "x1";
            // 
            // y1
            // 
            this.y1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.y1.HeaderText = "y1";
            this.y1.Name = "y1";
            // 
            // z1
            // 
            this.z1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.z1.HeaderText = "z1";
            this.z1.Name = "z1";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(12, 24);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(0, 0);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(448, 30);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(23, 15);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "X1:";
            // 
            // cutGeomCombo2
            // 
            this.cutGeomCombo2.FormattingEnabled = true;
            this.cutGeomCombo2.Location = new System.Drawing.Point(477, 27);
            this.cutGeomCombo2.Name = "cutGeomCombo2";
            this.cutGeomCombo2.Size = new System.Drawing.Size(194, 24);
            this.cutGeomCombo2.TabIndex = 16;
            this.cutGeomCombo2.SelectedIndexChanged += new System.EventHandler(this.cutGeomCombo2_SelectedIndexChanged);
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 646);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "View1";
            this.Text = "View1";
            this.tabControl1.ResumeLayout(false);
            this.tMiningArea.ResumeLayout(false);
            this.tMiningArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMiningArea)).EndInit();
            this.levels.ResumeLayout(false);
            this.levels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLevels)).EndInit();
            this.tCutInfo.ResumeLayout(false);
            this.tCutInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCutInfo)).EndInit();
            this.tCutGeom.ResumeLayout(false);
            this.tCutGeom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCutGeom)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tMiningArea;
        private System.Windows.Forms.TabPage levels;
        private System.Windows.Forms.TabPage tCutInfo;
        private System.Windows.Forms.DataGridView dataGridMiningArea;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tCutGeom;
        private System.Windows.Forms.TextBox MiningAreaTextBox;
        private System.Windows.Forms.ComboBox cutInfoCombo1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridCutInfo;
        private System.Windows.Forms.TextBox cutInfoTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cutInfoCombo3;
        private System.Windows.Forms.ComboBox cutInfoCombo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mining_area_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cut_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn cut_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cut_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonnage;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_mining_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn mining_area_type;
        private System.Windows.Forms.DataGridView dataGridLevels;
        private System.Windows.Forms.DataGridViewTextBoxColumn mining_area_name_levels;
        private System.Windows.Forms.DataGridViewTextBoxColumn cut_level_levels;
        private System.Windows.Forms.TextBox levelsTextBox;
        private System.Windows.Forms.ComboBox levelCombo1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cutGeomCombo1;
        private System.Windows.Forms.TextBox cutGeomTextBox;
        private System.Windows.Forms.DataGridView dataGridCutGeom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn z1;
        private System.Windows.Forms.ComboBox cutGeomCombo2;
        private System.Windows.Forms.TextBox textBox6;
    }
}