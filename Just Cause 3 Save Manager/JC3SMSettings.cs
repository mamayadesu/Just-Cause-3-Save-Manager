using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Just_Cause_3_Save_Manager
{
    public class JC3SMSettings
    {
        public Dictionary<string, string> Nicknames = new Dictionary<string, string>();
        public string LastSavedSteamId = "0";
        public string SelectedLanguage
        {
            get
            {
                return _selectedlanguage.ToLower();
            }
            set
            {
                value = value.ToLower();
                _selectedlanguageindex = getlangbystring(value);
                if (_selectedlanguageindex == -1)
                {
                    _selectedlanguageindex = 0;
                    _selectedlanguage = "en";
                }
                else
                {
                    _selectedlanguage = value;
                }
            }
        }

        public int SelectedLanguageIndex
        {
            get
            {
                return _selectedlanguageindex;
            }
            set
            {
                string glbi = getlangbyindex(value);
                if (glbi == "")
                {
                    _selectedlanguageindex = 0;
                    
                }
                else
                {
                    _selectedlanguageindex = value;
                    _selectedlanguage = glbi;
                }
            }
        }

        public void LoadNicknames()
        {
            Nicknames.Clear();
            string pathToFile = Methods.GetAppData() + "nicknames.txt";
            if (!File.Exists(pathToFile))
            {
                return;
            }

            string[] content;
            try
            {
                content = File.ReadAllLines(Methods.GetAppData() + "nicknames.txt");
            }
            catch (Exception e)
            {
                return;
            }
            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] data;
            string steamId, nickname;
            foreach (string line in content)
            {
                data = line.Split(' ');
                if (data.Length < 2)
                {
                    continue;
                }
                steamId = data[0];
                nickname = data[1];

                if (!Methods.IsDigitsOnly(steamId) || steamId.Length < 16 || steamId.Length > 20 || nickname.Length > 20)
                {
                    continue;
                }
                Nicknames.Add(steamId, nickname);
            }
        }

        public void SaveNicknames()
        {
            string pathToFile = Methods.GetAppData() + "nicknames.txt";
            string output = "";

            foreach (KeyValuePair<string, string> entry in Nicknames)
            {
                output += entry.Key + " " + entry.Value;
            }

            try
            {
                File.WriteAllText(pathToFile, output);
            }
            catch
            {

            }
        }

        public void LoadSettings()
        {
            string pathToFile = Methods.GetAppData() + "settings.txt";
            if (!File.Exists(pathToFile))
            {
                return;
            }

            string[] content;
            try
            {
                content = File.ReadAllLines(Methods.GetAppData() + "settings.txt");
            }
            catch (Exception e)
            {
                return;
            }
            string[] data;
            foreach (string line in content)
            {
                data = line.Split(' ');
                if (data.Length < 2)
                {
                    continue;
                }
                if (data[0] == "language")
                {
                    SelectedLanguage = data[1];
                }
                if (data[0] == "lastsavedsteamid")
                {
                    LastSavedSteamId = data[1];
                }
            }
        }

        public void SaveSettings()
        {
            string pathToFile = Methods.GetAppData() + "settings.txt";
            string output = "";

            output += "language " + SelectedLanguage;
            output += "\n\rlastsavedsteamid " + LastSavedSteamId;

            try
            {
                File.WriteAllText(pathToFile, output);
            }
            catch (Exception e)
            {

            }
        }

        private string _selectedlanguage = "en";
        private int _selectedlanguageindex = 0;

        private int getlangbystring(string str)
        {
            switch (str.ToLower())
            {
                case "en":
                    return 0;

                case "ru":
                    return 1;

                default:
                    return -1;
            }
        }

        private string getlangbyindex(int idx)
        {
            switch (idx)
            {
                case 0:
                    return "en";

                case 1:
                    return "ru";

                default:
                    return "";
            }
        }
    }
}
