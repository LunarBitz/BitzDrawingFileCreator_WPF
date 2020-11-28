using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitzDrawingFileCreator_WPF.Data
{
    public class UserInfo : ObservableObject
    {
        private Dictionary<string, string> privateVars = new Dictionary<string, string>();

        #region Entry Data
        public string trelloBoardID
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public string trelloDefaultList
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public string trelloApiKey
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public string trelloToken
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        #endregion

    }
}
