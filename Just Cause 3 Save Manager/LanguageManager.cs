using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just_Cause_3_Save_Manager
{
    public class LanguageManager
    {
        public Dictionary<string, Dictionary<string, string>> LANG = new Dictionary<string,Dictionary<string,string>>();
        private Form form;
        private TabPage tabpage;
        private string loadedlang = "";
        private string type = "form";

        public string LoadedLanguage
        {
            get
            {
                return loadedlang;
            }
            set
            {

            }
        }

        public LanguageManager(Form f)
        {
            init();
            form = f;
            type = "form";
        }

        public LanguageManager(TabPage f)
        {
            init();
            tabpage = f;
            type = "tabpage";
        }

        private void init()
        {
            Dictionary<string, string> en = new Dictionary<string, string>();
            en.Add("SelectProfileForm", "Just Cause 3 Save Manager - Select Profile");
            en.Add("selectProfileLbl", "Select your Steam profile");
            en.Add("FolderNotFound", "Saves folder of Just Cause 3 not found. Be sure you're using Steam-version of the game");
            en.Add("continueBtn", "Continue");
            en.Add("MainForm", "Just Cause 3 Save Manager");
            en.Add("SavesTab", "Saves");
            en.Add("youLoggedAsLbl", "You logged as");
            en.Add("loadSaveDataBtn", "Load save data");
            en.Add("overwriteSaveData", "Overwrite (re-save) save data");
            en.Add("deleteSaveDataBtn", "Delete save data");
            en.Add("inputNumberLbl", "Input number for new save data");
            en.Add("newSaveDataBtn", "New save data");
            en.Add("SettingsTab", "Settings");
            en.Add("inputNicknameLbl", "Input nickname");
            en.Add("languageLbl", "Language");
            en.Add("LoadConfirm", "Do you really want to load this save data? Your auto-save data will be lost");
            en.Add("LoadOk", "Your save data has been loaded. Now you can play Just Cause 3 with this save data");
            en.Add("OverwriteConfirm", "Do you really want to OVERWRITE this save data?");
            en.Add("OverwriteOk", "Your in-game progress has been saved");
            en.Add("DeleteConfirm", "Do you really want to DELETE THIS save data?");
            en.Add("DeleteOk", "This save data has been deleted");
            en.Add("NewConfirm", "Save your save data to new slot?");
            en.Add("NewOk", "Your save has been saved to new slot");
            en.Add("LoadFail", "Failed to load save data");
            en.Add("OverwriteFail", "Failed to overwrite save data");
            en.Add("DeleteFail", "Failed to delete save data");
            en.Add("NewFail", "Failed to save your save data to new slot");
            en.Add("saveNumberLbl", "Save number");
            en.Add("modifiedLbl", "When saved");
            en.Add("SaveN", "Save #");
            en.Add("InputNumberOfNewSaveData", "Input number of new save data!");
            en.Add("recommendedLbl", "Recommended: 0001, 0002");
            en.Add("Overwrite2Confirm", "The save data with the same number already exists. Do you want to OVERWRITE this save data?");
            en.Add("nicknameHintLbl", "It will be visible only in this program and next time you can easier to recognize your Steam profile");

            Dictionary<string, string> ru = new Dictionary<string, string>();
            ru.Add("SelectProfileForm", "JC3 Мастер сохранений - Выбор профиля");
            ru.Add("selectProfileLbl", "Выберите Ваш профиль Steam");
            ru.Add("FolderNotFound", "Папка для сохранений Just Cause 3 не найдена. Убедитесь, что Вы используете Steam-версию игры");
            ru.Add("continueBtn", "Продолжить");
            ru.Add("MainForm", "Just Cause 3 Мастер сохранений");
            ru.Add("SavesTab", "Сохранения");
            ru.Add("youLoggedAsLbl", "Вы вошли как");
            ru.Add("loadSaveDataBtn", "Загрузить сохранение");
            ru.Add("overwriteSaveData", "Пересохранить");
            ru.Add("deleteSaveDataBtn", "Удалить сохрaнение");
            ru.Add("inputNumberLbl", "Номер для нового сохранения");
            ru.Add("newSaveDataBtn", "Новое сохранение");
            ru.Add("SettingsTab", "Настройки");
            ru.Add("inputNicknameLbl", "Введите никнейм");
            ru.Add("languageLbl", "Язык программы");
            ru.Add("LoadConfirm", "Вы действительно хотите загрузить выбранное сохранение в игру? Ваше автосохранение будет утеряно");
            ru.Add("LoadOk", "Сохранение загружено. Теперь Вы можете запустить игру и играть с выбранным сохранением");
            ru.Add("OverwriteConfirm", "Вы действительно хотите ПЕРЕСОХРАНИТЬ это сохранение?");
            ru.Add("OverwriteOk", "Ваш прогресс сохранён");
            ru.Add("DeleteConfirm", "Вы действительно хотите УДАЛИТЬ это сохранение?");
            ru.Add("DeleteOk", "Это сохранение удалено");
            ru.Add("NewConfirm", "Сохранить прогресс в новый слот?");
            ru.Add("NewOk", "Ваш прогресс сохранён в новый слот");
            ru.Add("LoadFail", "Произошла ошибка при загрузке сохранения");
            ru.Add("OverwriteFail", "Произошла ошибка при пересохранении данных");
            ru.Add("DeleteFail", "Произошла ошибка при удалении сохранения");
            ru.Add("NewFail", "Произошла ошибка при создании нового сохранения");
            ru.Add("saveNumberLbl", "Сохранение");
            ru.Add("modifiedLbl", "Дата изменения");
            ru.Add("SaveN", "Сохранение #");
            ru.Add("InputNumberOfNewSaveData", "Введите номер нового сохранения");
            ru.Add("recommendedLbl", "Рекомендуется: 0001, 0002");
            ru.Add("Overwrite2Confirm", "Сохранение с таким номером уже существует. Перезаписать ЭТО сохранение?");
            ru.Add("nicknameHintLbl", "Он будет виден только в этой программе и в следующий раз Вам будет легче узнать свой профиль Steam");

            LANG.Add("en", en);
            LANG.Add("ru", ru);
        }

        public string G(string title)
        {
            if (LoadedLanguage == "")
            {
                return "";
            }
            if (!LANG[LoadedLanguage].ContainsKey(title))
            {
                return "";
            }
            return LANG[LoadedLanguage][title];
        }

        public void LoadLanguage(string langname)
        {
            Dictionary<string, string> lang;

            if (!LANG.ContainsKey(langname))
            {
                throw new Exception("Language " + langname + " not found");
            }
            lang = LANG[langname];
            loadedlang = langname;
            foreach (KeyValuePair<string, string> entry in lang)
            {
                if (type == "form")
                {
                    foreach (Control control in form.Controls)
                    {
                        if (entry.Key == control.Name)
                        {
                            control.Text = entry.Value;
                            break;
                        }
                    }
                    if (form.Name == entry.Key)
                    {
                        form.Text = entry.Value;
                    }
                }
                else if (type == "tabpage")
                {
                    foreach (Control control in tabpage.Controls)
                    {
                        if (entry.Key == control.Name)
                        {
                            control.Text = entry.Value;
                            break;
                        }
                    }

                    if (tabpage.Name == entry.Key)
                    {
                        tabpage.Text = entry.Value;
                    }
                }
            }
        }
    }
}
