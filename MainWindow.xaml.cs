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
        public Storyboard menuStory = null;

        int panelSlideSpeed = 20;

        Dictionary<string, StackPanel> dataSubPanels;
        Dictionary<string, double> dataSubPanelsInfo;

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            dataSubPanels = new Dictionary<string, StackPanel>();
            dataSubPanelsInfo = new Dictionary<string, double>();

            dataSubPanels["Pages"] = submenupanel_Pages;
            dataSubPanelsInfo["Pages_Height"] = dataSubPanels["Pages"].Height;
            this.RegisterName(dataSubPanels["Pages"].Name, dataSubPanels["Pages"]);

            menuStory = new Storyboard();

            initThemeColors();

            hideSubMenus();

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
            foreach (KeyValuePair<string, StackPanel> subMenu in dataSubPanels)
            {

                DoubleAnimation menuDown = new DoubleAnimation();
                menuDown.From = 160;
                menuDown.To = 0;
                menuDown.Duration = new Duration(TimeSpan.FromMilliseconds(100.0));
                Storyboard.SetTargetName(menuDown, subMenu.Value.Name);
                Storyboard.SetTargetProperty(menuDown,
                    new PropertyPath(StackPanel.HeightProperty));

                menuStory.Children.Add(menuDown);

                menuStory.Begin(this);
            }
            
        }
        
        private void showSubMenu(StackPanel subMenu)
        {
            if (subMenu.Height > 0.0)
            {
                hideSubMenus();
            }
            else
            {
                string baseName = subMenu.Name.Replace("submenupanel_", "");

                DoubleAnimation menuUp = new DoubleAnimation();
                menuUp.From = subMenu.Height;
                menuUp.To = dataSubPanelsInfo[baseName + "_Height"];
                menuUp.Duration = new Duration(TimeSpan.FromMilliseconds(300));
                Storyboard.SetTargetName(menuUp, subMenu.Name);
                Storyboard.SetTargetProperty(menuUp,
                    new PropertyPath(StackPanel.HeightProperty));
                
                menuStory.Children.Add(menuUp);

                menuStory.Begin(this);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            hideSubMenus();
        }
    }
}
