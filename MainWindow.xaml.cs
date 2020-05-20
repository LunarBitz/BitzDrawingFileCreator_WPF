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
        Dictionary<string, int> dataSubPanelsInfo;

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            dataSubPanels = new Dictionary<string, StackPanel>();
            dataSubPanelsInfo = new Dictionary<string, int>();

            dataSubPanels["Pages"] = submenupanel_Pages;
            dataSubPanelsInfo["Pages_Hidden"] = 0;
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

        private double objToDouble(object o)
        {
            IConvertible convert = o as IConvertible;

            if (convert != null)
            {
                return convert.ToDouble(null);
            }
            else
            {
                return 0d;
            }
        }

        private void hideSubMenus()
        {
            foreach (KeyValuePair<string, StackPanel> subMenu in dataSubPanels)
            {
                /*
                ScaleTransform scale = new ScaleTransform(
                    objToDouble(subMenu.Value.LayoutTransform.ReadLocalValue(ScaleTransform.ScaleXProperty)),
                    objToDouble(subMenu.Value.LayoutTransform.ReadLocalValue(ScaleTransform.ScaleYProperty))
                );*/
                ScaleTransform scale = new ScaleTransform(1.0, 0.0);
                subMenu.Value.LayoutTransform = scale;

                DoubleAnimation menuDown = new DoubleAnimation();
                menuDown.From = 1.0;
                menuDown.To = 0.0;
                menuDown.Duration = new Duration(TimeSpan.FromMilliseconds(50.0));
                menuDown.Completed += new EventHandler((sender, e) => menuClosedAnimationComplete(sender, e, subMenu.Value));

                menuStory.Children.Add(menuDown);
                Storyboard.SetTarget(menuDown, subMenu.Value);
                Storyboard.SetTargetProperty(menuDown, new PropertyPath("LayoutTransform.ScaleY"));

                menuStory.Begin(this);
            }

        }

        private void showSubMenu(StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            hideSubMenus();

            if (dataSubPanelsInfo[baseName + "_Hidden"] == 1)
            {
                /*
                ScaleTransform scale = new ScaleTransform(
                    objToDouble(dataSubPanels[baseName].LayoutTransform.ReadLocalValue(ScaleTransform.ScaleXProperty)),
                    objToDouble(dataSubPanels[baseName].LayoutTransform.ReadLocalValue(ScaleTransform.ScaleYProperty))
                );*/
                ScaleTransform scale = new ScaleTransform(1.0, 1.0);
                dataSubPanels[baseName].LayoutTransform = scale;

                DoubleAnimation menuDown = new DoubleAnimation();
                menuDown.From = 0.0;
                menuDown.To = 1.0;
                menuDown.Duration = new Duration(TimeSpan.FromMilliseconds(50.0));
                menuDown.Completed += new EventHandler((sender, e) => menuOpenedAnimationComplete(sender, e, subMenu));

                menuStory.Children.Add(menuDown);
                Storyboard.SetTarget(menuDown, dataSubPanels[baseName]);
                Storyboard.SetTargetProperty(menuDown, new PropertyPath("LayoutTransform.ScaleY"));

                menuStory.Begin(this);
            }
        }

        private void menuOpenedAnimationComplete(object sender, EventArgs e, StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            dataSubPanelsInfo[baseName + "_Hidden"] = 0;
        }

        private void menuClosedAnimationComplete(object sender, EventArgs e, StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            dataSubPanelsInfo[baseName + "_Hidden"] = 1;
        }

        private void btnPages_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(submenupanel_Pages);
        }
    }
}