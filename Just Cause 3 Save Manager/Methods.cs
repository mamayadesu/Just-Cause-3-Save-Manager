using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Just_Cause_3_Save_Manager
{
    public class Methods
    {
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public static string GetAppData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Just Cause 3 Save Manager\\";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        public static string GetPathToAutoSaves()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Square Enix\\Just Cause 3\\Saves\\";
        }

        public static string GetPathToAutoSaves(string steamId)
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Square Enix\\Just Cause 3\\Saves\\" + steamId + "\\";
        }

        public static string GetPathToSaves()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Square Enix\\";
        }

        public static string StringOnlyNumericSymbols(string str, bool comma, bool minus)
        {
            string c = (comma ? "," : "");
            string m = (minus ? "-" : "");
            return System.Text.RegularExpressions.Regex.Replace(str, "[^0-9" + c + m + "]", "");
        }
    }
}
