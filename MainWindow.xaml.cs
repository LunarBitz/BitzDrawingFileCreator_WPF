using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BitzDrawingFileCreator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Variables

        private Window activeWindow = null;

        int panelSlideSpeed = 20;

        Dictionary<string, StackPanel> dataSubPanels;
        Dictionary<string, string> dataSubPanelsInfo;

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            

            dataSubPanels = new Dictionary<string, StackPanel>();
            dataSubPanelsInfo = new Dictionary<string, string>();

            dataSubPanels["Pages"] = submenupanel_Pages;
            dataSubPanelsInfo["Pages_Height"] = dataSubPanels["Pages"].Height.ToString();
            System.Diagnostics.Debug.WriteLine(" Height: " + dataSubPanels["Pages"].Height);
            dataSubPanelsInfo["Pages_Hidden"] = "False";
            dataSubPanelsInfo["Pages_Slide"] = "Up";

            initThemeColors();

            hideSubMenus();

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1, 300);
            dispatcherTimer.Start();

        }

        private void initThemeColors()
        {
            Resources["themeclr_Text_Primary"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_Text_Secondary"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "5f2568"));
            Resources["themeclr_Text_Tertiary"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "341d38"));

            Resources["themeclr_MenuLogo_Background_Primary"] = (Color)ColorConverter.ConvertFromString("#FF" + "3f164d");
            Resources["themeclr_MenuLogo_Background_Secondary"] = (Color)ColorConverter.ConvertFromString("#00" + "000000");

            Resources["themeclr_Button_Text"] = Resources["themeclr_Text_Primary"];
            Resources["themeclr_Button_Background"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "0f0f0f"));
            Resources["themeclr_Button_Border"] = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_Button_Hover"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "404040"));
            Resources["themeclr_Button_Clicked"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "79517d"));
            Resources["themeclr_Button_Selected"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c0c0c0"));

            Resources["themeclr_Menu_Background"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "0f0f0f"));
            Resources["themeclr_MenuOption_Text"] = Resources["themeclr_Text_Primary"];
            Resources["themeclr_MenuOption_Background"] = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_MenuOption_Border"] = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_MenuOption_Hover"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "404040"));
            Resources["themeclr_MenuOption_Clicked"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "79517d"));
            Resources["themeclr_MenuOption_Selected"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c0c0c0"));

            Resources["themeclr_SubMenu_Background"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "232027"));
            Resources["themeclr_SubMenuOption_Text"] = Resources["themeclr_Text_Secondary"];
            Resources["themeclr_SubMenuOption_Background"] = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_SubMenuOption_Border"] = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_SubMenuOption_Hover"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "404040"));
            Resources["themeclr_SubMenuOption_Clicked"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "79517d"));
            Resources["themeclr_SubMenuOption_Selected"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c0c0c0"));

            Resources["themeclr_EntryText_Text"] = Resources["themeclr_Text_Primary"];
            Resources["themeclr_EntryText_Background"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_EntryTex_Border"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));

            Resources["themeclr_ListBox_Text"] = Resources["themeclr_Text_Primary"];
            Resources["themeclr_ListBox_Background"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_ListBox_Border"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));

            Resources["themeclr_ComboBox_Text"] = Resources["themeclr_Text_Primary"];
            Resources["themeclr_ComboBox_Arrow"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_ComboBox_Background"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_ComboBox_Border"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));

            Resources["themeclr_Scroll_Thumb"] = Resources["themeclr_Text_Primary"];
            Resources["themeclr_Scroll_Arrows"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_Scroll_Background"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_Scroll_Border"] = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
        }

        private void hideSubMenus()
        {
            foreach (KeyValuePair<string, StackPanel> subMenus in dataSubPanels)
            {
                dataSubPanelsInfo[subMenus.Key + "_Slide"] = "Up";
            }
        }
        
        private void showSubMenu(StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            if (dataSubPanelsInfo[baseName + "_Hidden"] == "True")
            {
                hideSubMenus();

                dataSubPanelsInfo[baseName + "_Slide"] = "Down";
            }
            else
            {
                dataSubPanelsInfo[baseName + "_Slide"] = "Up";
            }
        }

        private double ConvertToDouble(string s)
        {
            char systemSeparator = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            double result = 0;
            try
            {
                if (s != null)
                    if (!s.Contains(","))
                        result = double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
                    else
                        result = Convert.ToDouble(s.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
            }
            catch (Exception e)
            {
                try
                {
                    result = Convert.ToDouble(s);
                }
                catch
                {
                    try
                    {
                        result = Convert.ToDouble(s.Replace(",", ";").Replace(".", ",").Replace(";", "."));
                    }
                    catch
                    {
                        throw new Exception("Wrong string-to-double format");
                    }
                }
            }
            return result;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, StackPanel> subMenus in dataSubPanels)
            {
                if (dataSubPanelsInfo[subMenus.Key + "_Slide"] == "Down" && dataSubPanelsInfo[subMenus.Key + "_Hidden"] == "True")
                {
                    subMenus.Value.Height += panelSlideSpeed;
                    System.Diagnostics.Debug.WriteLine(subMenus.Value.Name + "Going Down Height: " + subMenus.Value.Height);

                    if (subMenus.Value.Height >= ConvertToDouble(dataSubPanelsInfo[subMenus.Key + "_Height"]))
                    {
                        dataSubPanelsInfo[subMenus.Key + "_Hidden"] = "False";
                        subMenus.Value.Height = ConvertToDouble(dataSubPanelsInfo[subMenus.Key + "_Height"]);
                        //this.Refresh();
                    }
                }

                if (dataSubPanelsInfo[subMenus.Key + "_Slide"] == "Up" && dataSubPanelsInfo[subMenus.Key + "_Hidden"] == "False")
                {
                    subMenus.Value.Height -= panelSlideSpeed;
                    System.Diagnostics.Debug.WriteLine(subMenus.Value.Name + "Going Up Height: " + subMenus.Value.Height);

                    if (subMenus.Value.Height <= 0)
                    {
                        dataSubPanelsInfo[subMenus.Key + "_Hidden"] = "True";
                        subMenus.Value.Height = 0;
                        //this.Refresh();
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            hideSubMenus();
        }
    }
}
