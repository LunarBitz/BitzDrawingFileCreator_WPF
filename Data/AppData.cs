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

        #region Theme Colors

        #region Text

        public string theme_Text_Primary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Text_Secondary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Text_Tertiary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region Menu Logo

        public string theme_MenuLogo_Background_Primary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_MenuLogo_Background_Secondary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region Button

        public string theme_Button_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Button_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Button_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Button_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Button_Clicked
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Button_Selected
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region Menu

        public string theme_Menu_Background_Primary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Menu_Background_Secondary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion
        
        #region Menu Options

        public string theme_MenuOption_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_MenuOption_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_MenuOption_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_MenuOption_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_MenuOption_Clicked
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_MenuOption_Selected
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region SubMenu

        public string theme_SubMenu_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region SubMenu Option

        public string theme_SubMenuOption_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_SubMenuOption_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_SubMenuOption_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_SubMenuOption_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_SubMenuOption_Clicked
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_SubMenuOption_Selected
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region Group
        public string theme_Group_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Group_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region TextBox
        public string theme_TextBox_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_TextBox_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_TextBox_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_TextBox_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_TextBox_Focus
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_TextBox_Inactive
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region ListBox

        public string theme_ListBox_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ListBox_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ListBox_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region ComboBox
        public string theme_ComboBox_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Arrow
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Arrow_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Pressed
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Sub_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Sub_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Sub_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Sub_Pressed
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_ComboBox_Sub_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region ScrollBar
        public string theme_Scroll_Thumb
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Scroll_Background_Primary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }
        public string theme_Scroll_Background_Secondary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (!privateVars.ContainsKey(baseName))
                    return "#00000000";
                if (string.IsNullOrEmpty(privateVars[baseName]))
                    return "#00000000";
                return privateVars[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVars[baseName] = value;
                //System.Diagnostics.Debug.WriteLine(privateVars[baseName]);
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #endregion
    }
}
