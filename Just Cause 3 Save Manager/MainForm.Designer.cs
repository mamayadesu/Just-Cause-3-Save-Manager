namespace Just_Cause_3_Save_Manager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SavesTab = new System.Windows.Forms.TabPage();
            this.recommendedLbl = new System.Windows.Forms.Label();
            this.modifiedLbl = new System.Windows.Forms.Label();
            this.saveNumberLbl = new System.Windows.Forms.Label();
            this.SavesTable = new System.Windows.Forms.DataGridView();
            this.savenumber_col_savestable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modified_col_savestable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newSaveDataNumberTb = new System.Windows.Forms.TextBox();
            this.inputNumberLbl = new System.Windows.Forms.Label();
            this.newSaveDataBtn = new System.Windows.Forms.Button();
            this.loggedAsLbl = new System.Windows.Forms.Label();
            this.youLoggedAsLbl = new System.Windows.Forms.Label();
            this.loadSaveDataBtn = new System.Windows.Forms.Button();
            this.deleteSaveDataBtn = new System.Windows.Forms.Button();
            this.overwriteSaveData = new System.Windows.Forms.Button();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.appVersion = new System.Windows.Forms.Label();
            this.appVerLbl = new System.Windows.Forms.Label();
            this.nicknameHintLbl = new System.Windows.Forms.Label();
            this.languageCb = new System.Windows.Forms.ComboBox();
            this.languageLbl = new System.Windows.Forms.Label();
            this.nicknameTb = new System.Windows.Forms.TextBox();
            this.inputNicknameLbl = new System.Windows.Forms.Label();
            this.checkLng = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.SavesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SavesTable)).BeginInit();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SavesTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // SavesTab
            // 
            this.SavesTab.Controls.Add(this.recommendedLbl);
            this.SavesTab.Controls.Add(this.modifiedLbl);
            this.SavesTab.Controls.Add(this.saveNumberLbl);
            this.SavesTab.Controls.Add(this.SavesTable);
            this.SavesTab.Controls.Add(this.newSaveDataNumberTb);
            this.SavesTab.Controls.Add(this.inputNumberLbl);
            this.SavesTab.Controls.Add(this.newSaveDataBtn);
            this.SavesTab.Controls.Add(this.loggedAsLbl);
            this.SavesTab.Controls.Add(this.youLoggedAsLbl);
            this.SavesTab.Controls.Add(this.loadSaveDataBtn);
            this.SavesTab.Controls.Add(this.deleteSaveDataBtn);
            this.SavesTab.Controls.Add(this.overwriteSaveData);
            this.SavesTab.Location = new System.Drawing.Point(4, 27);
            this.SavesTab.Name = "SavesTab";
            this.SavesTab.Padding = new System.Windows.Forms.Padding(3);
            this.SavesTab.Size = new System.Drawing.Size(666, 456);
            this.SavesTab.TabIndex = 0;
            this.SavesTab.Text = "Saves";
            this.SavesTab.UseVisualStyleBackColor = true;
            // 
            // recommendedLbl
            // 
            this.recommendedLbl.AutoSize = true;
            this.recommendedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recommendedLbl.Location = new System.Drawing.Point(400, 319);
            this.recommendedLbl.Name = "recommendedLbl";
            this.recommendedLbl.Size = new System.Drawing.Size(139, 13);
            this.recommendedLbl.TabIndex = 12;
            this.recommendedLbl.Text = "Recommended: 0001, 0002";
            this.recommendedLbl.Visible = false;
            // 
            // modifiedLbl
            // 
            this.modifiedLbl.AutoSize = true;
            this.modifiedLbl.Location = new System.Drawing.Point(498, 419);
            this.modifiedLbl.Name = "modifiedLbl";
            this.modifiedLbl.Size = new System.Drawing.Size(90, 18);
            this.modifiedLbl.TabIndex = 11;
            this.modifiedLbl.Text = "When saved";
            this.modifiedLbl.Visible = false;
            // 
            // saveNumberLbl
            // 
            this.saveNumberLbl.AutoSize = true;
            this.saveNumberLbl.Location = new System.Drawing.Point(397, 419);
            this.saveNumberLbl.Name = "saveNumberLbl";
            this.saveNumberLbl.Size = new System.Drawing.Size(95, 18);
            this.saveNumberLbl.TabIndex = 10;
            this.saveNumberLbl.Text = "Save number";
            this.saveNumberLbl.Visible = false;
            // 
            // SavesTable
            // 
            this.SavesTable.AllowUserToAddRows = false;
            this.SavesTable.AllowUserToDeleteRows = false;
            this.SavesTable.AllowUserToResizeColumns = false;
            this.SavesTable.AllowUserToResizeRows = false;
            this.SavesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SavesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SavesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.savenumber_col_savestable,
            this.modified_col_savestable});
            this.SavesTable.Location = new System.Drawing.Point(21, 60);
            this.SavesTable.Name = "SavesTable";
            this.SavesTable.ReadOnly = true;
            this.SavesTable.RowHeadersVisible = false;
            this.SavesTable.Size = new System.Drawing.Size(370, 388);
            this.SavesTable.TabIndex = 9;
            this.SavesTable.SelectionChanged += new System.EventHandler(this.SavesTable_SelectionChanged);
            // 
            // savenumber_col_savestable
            // 
            this.savenumber_col_savestable.FillWeight = 88.32487F;
            this.savenumber_col_savestable.HeaderText = "Save number";
            this.savenumber_col_savestable.Name = "savenumber_col_savestable";
            this.savenumber_col_savestable.ReadOnly = true;
            this.savenumber_col_savestable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // modified_col_savestable
            // 
            this.modified_col_savestable.FillWeight = 111.6751F;
            this.modified_col_savestable.HeaderText = "When saved";
            this.modified_col_savestable.Name = "modified_col_savestable";
            this.modified_col_savestable.ReadOnly = true;
            this.modified_col_savestable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // newSaveDataNumberTb
            // 
            this.newSaveDataNumberTb.Location = new System.Drawing.Point(400, 245);
            this.newSaveDataNumberTb.MaxLength = 4;
            this.newSaveDataNumberTb.Name = "newSaveDataNumberTb";
            this.newSaveDataNumberTb.Size = new System.Drawing.Size(90, 24);
            this.newSaveDataNumberTb.TabIndex = 8;
            this.newSaveDataNumberTb.TextChanged += new System.EventHandler(this.newSaveDataNumberBtn_TextChanged);
            // 
            // inputNumberLbl
            // 
            this.inputNumberLbl.AutoSize = true;
            this.inputNumberLbl.Location = new System.Drawing.Point(397, 224);
            this.inputNumberLbl.Name = "inputNumberLbl";
            this.inputNumberLbl.Size = new System.Drawing.Size(213, 18);
            this.inputNumberLbl.TabIndex = 7;
            this.inputNumberLbl.Text = "Input number for new save data";
            // 
            // newSaveDataBtn
            // 
            this.newSaveDataBtn.Location = new System.Drawing.Point(400, 275);
            this.newSaveDataBtn.Name = "newSaveDataBtn";
            this.newSaveDataBtn.Size = new System.Drawing.Size(237, 37);
            this.newSaveDataBtn.TabIndex = 6;
            this.newSaveDataBtn.Text = "New save data";
            this.newSaveDataBtn.UseVisualStyleBackColor = true;
            this.newSaveDataBtn.Click += new System.EventHandler(this.newSaveDataBtn_Click);
            // 
            // loggedAsLbl
            // 
            this.loggedAsLbl.AutoSize = true;
            this.loggedAsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loggedAsLbl.Location = new System.Drawing.Point(156, 17);
            this.loggedAsLbl.Name = "loggedAsLbl";
            this.loggedAsLbl.Size = new System.Drawing.Size(19, 20);
            this.loggedAsLbl.TabIndex = 5;
            this.loggedAsLbl.Text = "0";
            // 
            // youLoggedAsLbl
            // 
            this.youLoggedAsLbl.AutoSize = true;
            this.youLoggedAsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.youLoggedAsLbl.Location = new System.Drawing.Point(17, 17);
            this.youLoggedAsLbl.Name = "youLoggedAsLbl";
            this.youLoggedAsLbl.Size = new System.Drawing.Size(111, 20);
            this.youLoggedAsLbl.TabIndex = 4;
            this.youLoggedAsLbl.Text = "You logged as";
            // 
            // loadSaveDataBtn
            // 
            this.loadSaveDataBtn.Enabled = false;
            this.loadSaveDataBtn.Location = new System.Drawing.Point(400, 60);
            this.loadSaveDataBtn.Name = "loadSaveDataBtn";
            this.loadSaveDataBtn.Size = new System.Drawing.Size(237, 37);
            this.loadSaveDataBtn.TabIndex = 3;
            this.loadSaveDataBtn.Text = "Load save data";
            this.loadSaveDataBtn.UseVisualStyleBackColor = true;
            this.loadSaveDataBtn.Click += new System.EventHandler(this.loadSaveDataBtn_Click);
            // 
            // deleteSaveDataBtn
            // 
            this.deleteSaveDataBtn.Enabled = false;
            this.deleteSaveDataBtn.Location = new System.Drawing.Point(400, 146);
            this.deleteSaveDataBtn.Name = "deleteSaveDataBtn";
            this.deleteSaveDataBtn.Size = new System.Drawing.Size(237, 37);
            this.deleteSaveDataBtn.TabIndex = 2;
            this.deleteSaveDataBtn.Text = "Delete save data";
            this.deleteSaveDataBtn.UseVisualStyleBackColor = true;
            this.deleteSaveDataBtn.Click += new System.EventHandler(this.deleteSaveDataBtn_Click);
            // 
            // overwriteSaveData
            // 
            this.overwriteSaveData.Enabled = false;
            this.overwriteSaveData.Location = new System.Drawing.Point(400, 103);
            this.overwriteSaveData.Name = "overwriteSaveData";
            this.overwriteSaveData.Size = new System.Drawing.Size(237, 37);
            this.overwriteSaveData.TabIndex = 1;
            this.overwriteSaveData.Text = "Overwrite save data";
            this.overwriteSaveData.UseVisualStyleBackColor = true;
            this.overwriteSaveData.Click += new System.EventHandler(this.overwriteSaveData_Click);
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.appVersion);
            this.SettingsTab.Controls.Add(this.appVerLbl);
            this.SettingsTab.Controls.Add(this.nicknameHintLbl);
            this.SettingsTab.Controls.Add(this.languageCb);
            this.SettingsTab.Controls.Add(this.languageLbl);
            this.SettingsTab.Controls.Add(this.nicknameTb);
            this.SettingsTab.Controls.Add(this.inputNicknameLbl);
            this.SettingsTab.Location = new System.Drawing.Point(4, 27);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(666, 456);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // appVersion
            // 
            this.appVersion.AutoSize = true;
            this.appVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appVersion.Location = new System.Drawing.Point(588, 423);
            this.appVersion.Name = "appVersion";
            this.appVersion.Size = new System.Drawing.Size(59, 18);
            this.appVersion.TabIndex = 6;
            this.appVersion.Text = "1.2.0.0";
            // 
            // appVerLbl
            // 
            this.appVerLbl.AutoSize = true;
            this.appVerLbl.Location = new System.Drawing.Point(479, 423);
            this.appVerLbl.Name = "appVerLbl";
            this.appVerLbl.Size = new System.Drawing.Size(58, 18);
            this.appVerLbl.TabIndex = 5;
            this.appVerLbl.Text = "Version";
            // 
            // nicknameHintLbl
            // 
            this.nicknameHintLbl.AutoSize = true;
            this.nicknameHintLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nicknameHintLbl.Location = new System.Drawing.Point(25, 71);
            this.nicknameHintLbl.Name = "nicknameHintLbl";
            this.nicknameHintLbl.Size = new System.Drawing.Size(456, 13);
            this.nicknameHintLbl.TabIndex = 4;
            this.nicknameHintLbl.Text = "It will be visible only in this program and next time you can easier to recognize" +
    " your Steam profile";
            // 
            // languageCb
            // 
            this.languageCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageCb.FormattingEnabled = true;
            this.languageCb.Items.AddRange(new object[] {
            "English",
            "Русский (Russian)"});
            this.languageCb.Location = new System.Drawing.Point(28, 132);
            this.languageCb.Name = "languageCb";
            this.languageCb.Size = new System.Drawing.Size(161, 26);
            this.languageCb.TabIndex = 3;
            this.languageCb.SelectedIndexChanged += new System.EventHandler(this.languageCb_SelectedIndexChanged);
            // 
            // languageLbl
            // 
            this.languageLbl.AutoSize = true;
            this.languageLbl.Location = new System.Drawing.Point(25, 110);
            this.languageLbl.Name = "languageLbl";
            this.languageLbl.Size = new System.Drawing.Size(72, 18);
            this.languageLbl.TabIndex = 2;
            this.languageLbl.Text = "Language";
            // 
            // nicknameTb
            // 
            this.nicknameTb.Location = new System.Drawing.Point(25, 40);
            this.nicknameTb.Name = "nicknameTb";
            this.nicknameTb.Size = new System.Drawing.Size(164, 24);
            this.nicknameTb.TabIndex = 1;
            this.nicknameTb.TextChanged += new System.EventHandler(this.nicknameTb_TextChanged);
            // 
            // inputNicknameLbl
            // 
            this.inputNicknameLbl.AutoSize = true;
            this.inputNicknameLbl.Location = new System.Drawing.Point(22, 18);
            this.inputNicknameLbl.Name = "inputNicknameLbl";
            this.inputNicknameLbl.Size = new System.Drawing.Size(140, 18);
            this.inputNicknameLbl.TabIndex = 0;
            this.inputNicknameLbl.Text = "Input your nickname";
            // 
            // checkLng
            // 
            this.checkLng.Enabled = true;
            this.checkLng.Interval = 1;
            this.checkLng.Tick += new System.EventHandler(this.checkLng_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 487);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Cause 3 Save Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.SavesTab.ResumeLayout(false);
            this.SavesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SavesTable)).EndInit();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SavesTab;
        private System.Windows.Forms.TextBox newSaveDataNumberTb;
        private System.Windows.Forms.Label inputNumberLbl;
        private System.Windows.Forms.Button newSaveDataBtn;
        private System.Windows.Forms.Label loggedAsLbl;
        private System.Windows.Forms.Label youLoggedAsLbl;
        private System.Windows.Forms.Button loadSaveDataBtn;
        private System.Windows.Forms.Button deleteSaveDataBtn;
        private System.Windows.Forms.Button overwriteSaveData;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.ComboBox languageCb;
        private System.Windows.Forms.Label languageLbl;
        private System.Windows.Forms.TextBox nicknameTb;
        private System.Windows.Forms.Label inputNicknameLbl;
        private System.Windows.Forms.DataGridView SavesTable;
        private System.Windows.Forms.Label modifiedLbl;
        private System.Windows.Forms.Label saveNumberLbl;
        private System.Windows.Forms.Timer checkLng;
        private System.Windows.Forms.Label recommendedLbl;
        private System.Windows.Forms.Label nicknameHintLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn savenumber_col_savestable;
        private System.Windows.Forms.DataGridViewTextBoxColumn modified_col_savestable;
        private System.Windows.Forms.Label appVersion;
        private System.Windows.Forms.Label appVerLbl;
    }
}