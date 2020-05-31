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

namespace Just_Cause_3_Save_Manager
{
    public partial class SelectProfileForm : Form
    {
        public string pathToSaves;
        public List<string> profiles = new List<string>();
        public LanguageManager lm;
        public JC3SMSettings settings = new JC3SMSettings();
        public string selectedSteamId = "0";
        MainForm main;

        public SelectProfileForm()
        {
            InitializeComponent();
        }

        private void SelectProfileForm_Load(object sender, EventArgs e)
        {
            lm = new LanguageManager(this);
            settings.LoadSettings();
            settings.LoadNicknames();
            lm.LoadLanguage(settings.SelectedLanguage);

            pathToSaves = Methods.GetPathToAutoSaves();
            string[] list;
            try
            {
                list = Directory.GetDirectories(pathToSaves);
            }
            catch (Exception ex)
            {
                MessageBox.Show(lm.G("FolderNotFound"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            string[] i1;
            string a;
            foreach (string i in list)
            {
                i1 = i.Split('\\');
                a = i1[i1.Length - 1];
                if (a.Length >= 16 && a.Length <= 20 && Methods.IsDigitsOnly(a))
                {
                    profiles.Add(a);
                }
            }
            int c = -1;
            foreach (string profile in profiles)
            {
                c++;
                if (settings.Nicknames.ContainsKey(profile))
                {
                    steamProfile.Items.Add(settings.Nicknames[profile] + " (" + profile + ")");
                }
                else
                {
                    steamProfile.Items.Add(profile);
                }
                if (profile == settings.LastSavedSteamId)
                {
                    steamProfile.SelectedIndex = c;
                }
            }
        }

        private void steamProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            continueBtn.Enabled = steamProfile.SelectedIndex != -1;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            selectedSteamId = profiles[steamProfile.SelectedIndex];
            settings.LastSavedSteamId = selectedSteamId;
            main = new MainForm(this);
            this.Visible = false;
            main.Show();
        }
    }
}
