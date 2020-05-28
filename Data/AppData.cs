using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace BitzDrawingFileCreator_WPF.Data
{
    public class AppData : ObservableObject
    {

        private Dictionary<string, string> privateVarsInputs = new Dictionary<string, string>();
        private Dictionary<string, Color> privateVarsColors = new Dictionary<string, Color>();

        public static Color hexToBrush(string hexValue)
        {
            return (Color)ColorConverter.ConvertFromString(hexValue);
        }

        public class ColorToSolidColorBrushValueConverter : IValueConverter
        {

            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if (null == value)
                {
                    return null;
                }
                // For a more sophisticated converter, check also the targetType and react accordingly..
                if (value is Color)
                {
                    Color color = (Color)value;
                    return new SolidColorBrush(color);
                }
                // You can support here more source types if you wish
                // For the example I throw an exception

                Type type = value.GetType();
                throw new InvalidOperationException("Unsupported type [" + type.Name + "]");
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                // If necessary, here you can convert back. Check if which brush it is (if its one),
                // get its Color-value and return it.

                throw new NotImplementedException();
            }
        }

        #region Entry Data
        public string userName 
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (string.IsNullOrEmpty(privateVarsInputs[baseName]))
                    return " ";
                return privateVarsInputs[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");

                privateVarsInputs[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        #endregion

        #region Theme Colors

        #region Text
        public Color theme_Text_Primary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        public Color theme_Text_Secondary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        public Color theme_Text_Tertiary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region Menu Logo
        public Color theme_MenuLogo_Background_Primary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        public Color theme_MenuLogo_Background_Secondary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region Button
        public Color theme_Button_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        public Color theme_Button_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        public Color theme_Button_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        public Color theme_Button_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        public Color theme_Button_Clicked
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        public Color theme_Button_Selected
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region Menu
        public Color theme_Menu_Background_Primary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        public Color theme_Menu_Background_Secondary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion
        
        #region Menu Options
        public Color theme_MenuOption_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_MenuOption_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_MenuOption_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_MenuOption_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_MenuOption_Clicked
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_MenuOption_Selected
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region SubMenu
        public Color theme_SubMenu_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region SubMenu Option
        public Color theme_SubMenuOption_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_SubMenuOption_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_SubMenuOption_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_SubMenuOption_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_SubMenuOption_Clicked
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_SubMenuOption_Selected
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region Group
        public Color theme_Group_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_Group_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region TextBox
        public Color theme_TextBox_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_TextBox_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_TextBox_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_TextBox_Hover
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_TextBox_Focus
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_TextBox_Inactive
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region ListBox
        public Color theme_ListBox_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_ListBox_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_ListBox_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region ComboBox
        public Color theme_ComboBox_Text
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_ComboBox_Arrow
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_ComboBox_Background
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_ComboBox_Border
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #region ScrollBar
        public Color theme_Scroll_Thumb
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_Scroll_Background_Primary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }
        public Color theme_Scroll_Background_Secondary
        {
            get
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("get_", "");

                if (privateVarsColors.ContainsKey(baseName))
                    return hexToBrush("#FFFF0000");
                return privateVarsColors[baseName];
            }
            set
            {
                string baseName = System.Reflection.MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                privateVarsColors[baseName] = value;
                OnPropertyChanged(baseName);
            }
        }

        #endregion

        #endregion
    }
}
