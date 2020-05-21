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
        public DoubleAnimation menuSlide = null;

        /// <summary>
        /// Time in milliseconds
        /// </summary>
        double panelOpenTime = 50.0;

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

            frameMainView.Navigate(new Page1());

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

            Resources["themeclr_Menu_Background_Primary"] = (Color)ColorConverter.ConvertFromString("#FF" + "0f0f0f");
            Resources["themeclr_Menu_Background_Secondary"] = (Color)ColorConverter.ConvertFromString("#00" + "1f1f1f");
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
                return convert.ToDouble(null);
            else
                return 0d;
        }

        #region UI Methods

        private void hideSubMenu(StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            ScaleTransform scale = new ScaleTransform(
                1.0,
                objToDouble(dataSubPanels[baseName].LayoutTransform.GetValue(ScaleTransform.ScaleYProperty))
            );
            //ScaleTransform scale = new ScaleTransform(1.0, 1.0);
            dataSubPanels[baseName].LayoutTransform = scale;

            menuSlide = new DoubleAnimation(0.0, new Duration(TimeSpan.FromMilliseconds(panelOpenTime)));
            menuSlide.Completed += new EventHandler((sender, e) => menuSlidedAnimationComplete(sender, e, dataSubPanels[baseName]));

            menuStory.Children.Add(menuSlide);
            Storyboard.SetTarget(menuSlide, dataSubPanels[baseName]);
            Storyboard.SetTargetProperty(menuSlide, new PropertyPath("LayoutTransform.ScaleY"));

            menuStory.Begin(this);
        }

        private void hideSubMenus(StackPanel exclusion = null)
        {
            foreach (KeyValuePair<string, StackPanel> subMenu in dataSubPanels)
            {
                if (subMenu.Value != exclusion)
                {
                    
                    ScaleTransform scale = new ScaleTransform(
                        1.0,
                        objToDouble(subMenu.Value.LayoutTransform.GetValue(ScaleTransform.ScaleYProperty))
                    );
                    //ScaleTransform scale = new ScaleTransform(1.0, 1.0);
                    subMenu.Value.LayoutTransform = scale;

                    menuSlide = new DoubleAnimation(0.0, new Duration(TimeSpan.FromMilliseconds(panelOpenTime)));
                    menuSlide.Completed += new EventHandler((sender, e) => menuSlidedAnimationComplete(sender, e, subMenu.Value));

                    menuStory.Children.Add(menuSlide);
                    Storyboard.SetTarget(menuSlide, subMenu.Value);
                    Storyboard.SetTargetProperty(menuSlide, new PropertyPath("LayoutTransform.ScaleY"));

                    menuStory.Begin(this);
                }
            }
        }

        private void showSubMenu(StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            if (dataSubPanelsInfo[baseName + "_Hidden"] == 0)
            {
                hideSubMenu(subMenu);
                return;
            }
            else if (dataSubPanelsInfo[baseName + "_Hidden"] == 1)
            {
                hideSubMenus(subMenu);

                
                ScaleTransform scale = new ScaleTransform(
                    1.0,
                    objToDouble(dataSubPanels[baseName].LayoutTransform.GetValue(ScaleTransform.ScaleYProperty))
                );
                //ScaleTransform scale = new ScaleTransform(1.0, 0.0);
                dataSubPanels[baseName].LayoutTransform = scale;

                menuSlide = new DoubleAnimation(1.0, new Duration(TimeSpan.FromMilliseconds(panelOpenTime)));
                menuSlide.Completed += new EventHandler((sender, e) => menuSlideedAnimationComplete(sender, e, subMenu));

                menuStory.Children.Add(menuSlide);
                Storyboard.SetTarget(menuSlide, dataSubPanels[baseName]);
                Storyboard.SetTargetProperty(menuSlide, new PropertyPath("LayoutTransform.ScaleY"));

                menuStory.Begin(this);
                return;
            }
        }

        private void menuSlideedAnimationComplete(object sender, EventArgs e, StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");
            System.Diagnostics.Debug.WriteLine("SCALE: " + dataSubPanels[baseName].LayoutTransform.GetValue(ScaleTransform.ScaleYProperty));
            dataSubPanelsInfo[baseName + "_Hidden"] = 0;
        }

        private void menuSlidedAnimationComplete(object sender, EventArgs e, StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");
            System.Diagnostics.Debug.WriteLine("SCALE: " + dataSubPanels[baseName].LayoutTransform.GetValue(ScaleTransform.ScaleYProperty));
            dataSubPanelsInfo[baseName + "_Hidden"] = 1;
        }

        #endregion

        private void btnPages_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(submenupanel_Pages);
        }
    }
}