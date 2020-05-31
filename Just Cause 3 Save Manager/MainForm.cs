using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Just_Cause_3_Save_Manager
{
    public partial class MainForm : Form
    {
        SelectProfileForm s;
        JC3SMSettings settings;
        string selectedSteamId;
        LanguageManager lm;
        LanguageManager lm1;
        LanguageManager lm2;

        List<string> LoadedSaves = new List<string>();
        List<string> LoadedSavesWithFullPath = new List<string>();
        DataGridViewCellStyle savedStyle = null;
        int savedIdx = -1;
        bool isTableFilled = false;

        DataGridViewCellStyle selectedStyle = new DataGridViewCellStyle
        {
            ForeColor = SystemColors.HighlightText,
            BackColor = SystemColors.Highlight
        };

        public MainForm(SelectProfileForm spf)
        {
            s = spf;
            settings = s.settings;
            selectedSteamId = s.selectedSteamId;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lm = new LanguageManager(this);
            lm1 = new LanguageManager(this.SavesTab);
            lm2 = new LanguageManager(this.SettingsTab);

            lm.LoadLanguage(settings.SelectedLanguage);
            lm1.LoadLanguage(settings.SelectedLanguage);
            lm2.LoadLanguage(settings.SelectedLanguage);
            if (settings.Nicknames.ContainsKey(selectedSteamId))
            {
                nicknameTb.Text = settings.Nicknames[selectedSteamId];
            }
            nicknameTb_TextChanged(sender, e);
            languageCb.SelectedIndex = settings.SelectedLanguageIndex;
            LoadSaves();
        }

        private void checkLng_Tick(object sender, EventArgs e)
        {
            if (savenumber_col_savestable.HeaderText != saveNumberLbl.Text)
            {
                savenumber_col_savestable.HeaderText = saveNumberLbl.Text;
            }
            if (modified_col_savestable.HeaderText != modifiedLbl.Text)
            {
                modified_col_savestable.HeaderText = modifiedLbl.Text;
            }
        }

        private void nicknameTb_TextChanged(object sender, EventArgs e)
        {
            if (nicknameTb.Text == "")
            {
                if (settings.Nicknames.ContainsKey(selectedSteamId))
                {
                    settings.Nicknames.Remove(selectedSteamId);;
                }
                loggedAsLbl.Text = selectedSteamId;
                return;
            }
            if (settings.Nicknames.ContainsKey(selectedSteamId))
            {
                settings.Nicknames[selectedSteamId] = nicknameTb.Text;
            }
            else
            {
                settings.Nicknames.Add(selectedSteamId, nicknameTb.Text);
            }
            loggedAsLbl.Text = settings.Nicknames[selectedSteamId] + " (" + selectedSteamId + ")";
        }

        private void languageCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.SelectedLanguageIndex = languageCb.SelectedIndex;
            lm.LoadLanguage(settings.SelectedLanguage);
            lm1.LoadLanguage(settings.SelectedLanguage);
            lm2.LoadLanguage(settings.SelectedLanguage);
            LoadSaves();
        }

        private void LoadSaves()
        {
            isTableFilled = false;
            LoadedSaves.Clear();
            LoadedSavesWithFullPath.Clear();
            SavesTable.RowCount = 0;
            if (!Directory.Exists(Methods.GetPathToSaves()))
            {
                return;
            }

            string[] files = Directory.GetFiles(Methods.GetPathToSaves(), "JC3_" + selectedSteamId + "_*.zip");

            string[] file1;
            string onlyfile;
            string n;
            int i = -1;
            foreach (string file in files)
            {
                i++;
                LoadedSavesWithFullPath.Add(file);
                file1 = file.Split('\\');
                onlyfile = file1[file1.Length - 1];
                n = onlyfile.Replace("JC3_" + selectedSteamId + "_", "").Replace(".zip", "");
                LoadedSaves.Add(n);
                SavesTable.RowCount++;
                SavesTable.Rows[i].Cells[0].Value = lm.G("SaveN") + n;
                SavesTable.Rows[i].Cells[1].Value = File.GetLastWriteTime(file).ToString("dd/MM/yyyy HH:mm:ss");
            }
            isTableFilled = true;

            if (LoadedSaves.Count > 0)
            {
                SavesTable.CurrentCell = SavesTable.Rows[0].Cells[1];
            }
        }

        private void SavesTable_SelectionChanged(object sender, EventArgs e)
        {
            if (!isTableFilled)
            {
                return;
            }
            if (savedIdx != -1 && (savedIdx + 1) <= SavesTable.RowCount)
            {
                for (int j = 0; j < 2; j++)
                {
                    SavesTable.Rows[savedIdx].Cells[j].Style = savedStyle;
                }
            }
            int i = savedIdx = SavesTable.CurrentCell.RowIndex;
            if (i < 0)
            {
                loadSaveDataBtn.Enabled = overwriteSaveData.Enabled = deleteSaveDataBtn.Enabled = false;
                return;
            }
            loadSaveDataBtn.Enabled = overwriteSaveData.Enabled = deleteSaveDataBtn.Enabled = true;
            savedStyle = SavesTable.Rows[savedIdx].Cells[1].Style;
            for (int j = 0; j < 2; j++)
            {
                SavesTable.Rows[savedIdx].Cells[j].Style = selectedStyle;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.SaveNicknames();
            settings.SaveSettings();
            s.Close();
        }

        private void loadSaveDataBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(lm.G("LoadConfirm"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            string[] files = Directory.GetFiles(Methods.GetPathToAutoSaves(selectedSteamId));
            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(lm.G("LoadFail"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadSaves();
                    return;
                }
            }
            string pathToZip = LoadedSavesWithFullPath[savedIdx];
            try
            {
                ZipFile.ExtractToDirectory(pathToZip, Methods.GetPathToAutoSaves(selectedSteamId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(lm.G("LoadFail"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadSaves();
                return;
            }
            MessageBox.Show(lm.G("LoadOk"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSaves();
        }

        private void overwriteSaveData_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(lm.G("OverwriteConfirm"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                File.Delete(LoadedSavesWithFullPath[savedIdx]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(lm.G("OverwriteFail"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadSaves();
                return;
            }

            try
            {
                ZipFile.CreateFromDirectory(Methods.GetPathToAutoSaves(selectedSteamId), LoadedSavesWithFullPath[savedIdx]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(lm.G("OverwriteFail"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadSaves();
                return;
            }
            MessageBox.Show(lm.G("OverwriteOk"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSaves();
        }

        private void deleteSaveDataBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(lm.G("DeleteConfirm"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                File.Delete(LoadedSavesWithFullPath[savedIdx]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(lm.G("DeleteFail"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadSaves();
                return;
            }
            LoadSaves();
            MessageBox.Show(lm.G("DeleteOk"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newSaveDataNumberBtn_TextChanged(object sender, EventArgs e)
        {
            newSaveDataNumberTb.Text = Methods.StringOnlyNumericSymbols(newSaveDataNumberTb.Text, false, false);
        }

        private void newSaveDataBtn_Click(object sender, EventArgs e)
        {
            if (newSaveDataNumberTb.Text == "")
            {
                MessageBox.Show(lm.G("InputNumberOfNewSaveData"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filename = "JC3_" + selectedSteamId + "_" + newSaveDataNumberTb.Text + ".zip";
            string fullpath = Methods.GetPathToSaves() + filename;

            string confirm, ok, fail;
            bool overwrite = false;
            if (File.Exists(fullpath))
            {
                confirm = lm.G("Overwrite2Confirm");
                ok = lm.G("OverwriteOk");
                fail = lm.G("OverwriteFail");
                overwrite = true;
            }
            else
            {
                confirm = lm.G("NewConfirm");
                ok = lm.G("NewOk");
                fail = lm.G("NewFail");
            }

            DialogResult c = MessageBox.Show(confirm, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (c != DialogResult.Yes)
            {
                return;
            }

            if (overwrite)
            {
                try
                {
                    File.Delete(fullpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(fail, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadSaves();
                    return;
                }
            }

            try
            {
                ZipFile.CreateFromDirectory(Methods.GetPathToAutoSaves(selectedSteamId), fullpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(fail, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadSaves();
                return;
            }
            newSaveDataNumberTb.Text = "";
            LoadSaves();
            MessageBox.Show(ok, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
