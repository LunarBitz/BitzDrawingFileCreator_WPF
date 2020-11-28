using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitzDrawingFileCreator_WPF.Data
{
    public class AppData : ObservableObject
    {
        private Dictionary<string, string> privateVars = new Dictionary<string, string>();

        #region Entry Data
        public string drawingDescription
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
        public string userName 
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
        public string targetPlatform
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
        public string characterName
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
        public string characterSpecies
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
        public string drawingProduct
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
        public string drawingType
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
        public string drawingRender
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
        public string drawingSize
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
