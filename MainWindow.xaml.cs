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

        /// <summary>
        /// Storyboard handler for all animations
        /// </summary>
        public Storyboard menuStory = null;

        /// <summary>
        /// Double animation for menu opening and closing
        /// </summary>
        public DoubleAnimation menuSlide = null;

        /// <summary>
        /// Time for menu to open and close in milliseconds
        /// </summary>
        double panelOpenTime = 50.0;

        /// <summary>
        /// Dictionary of submenupanels for easy recall and key collection
        /// </summary>
        Dictionary<string, StackPanel> dataSubPanels;
        
        /// <summary>
        /// Dictionary holding extra information of the submenupanels.
        /// If possible, move to bindings
        /// </summary>
        Dictionary<string, int> dataSubPanelsInfo;

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the necessary components
            menuSlide = new DoubleAnimation();
            menuStory = new Storyboard();
            dataSubPanels = new Dictionary<string, StackPanel>();
            dataSubPanelsInfo = new Dictionary<string, int>();

            // Add the panels to the submenu dictionaries and app registry
            addSubMenu(submenupanel_Pages);

            // Default the theme and menu
            initThemeColors();
            hideSubMenus();

            // Load inital page to sub view
            frameMainView.Navigate(new PageMain());
        }

        private void initThemeColors()
        {
            Resources["themeclr_Text_Primary"]                  = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_Text_Secondary"]                = (Brush)(new BrushConverter().ConvertFrom("#FF" + "5f2568"));
            Resources["themeclr_Text_Tertiary"]                 = (Brush)(new BrushConverter().ConvertFrom("#FF" + "341d38"));

            Resources["themeclr_MenuLogo_Background_Primary"]   = (Color)ColorConverter.ConvertFromString("#FF" + "3f164d");
            Resources["themeclr_MenuLogo_Background_Secondary"] = (Color)ColorConverter.ConvertFromString("#00" + "000000");

            Resources["themeclr_Button_Text"]                   = Resources["themeclr_Text_Primary"];
            Resources["themeclr_Button_Background"]             = (Brush)(new BrushConverter().ConvertFrom("#FF" + "0f0f0f"));
            Resources["themeclr_Button_Border"]                 = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_Button_Hover"]                  = (Brush)(new BrushConverter().ConvertFrom("#FF" + "404040"));
            Resources["themeclr_Button_Clicked"]                = (Brush)(new BrushConverter().ConvertFrom("#FF" + "79517d"));
            Resources["themeclr_Button_Selected"]               = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c0c0c0"));

            Resources["themeclr_Menu_Background_Primary"]       = (Color)ColorConverter.ConvertFromString("#FF" + "0f0f0f");
            Resources["themeclr_Menu_Background_Secondary"]     = (Color)ColorConverter.ConvertFromString("#00" + "1f1f1f");
            Resources["themeclr_MenuOption_Text"]               = Resources["themeclr_Text_Primary"];
            Resources["themeclr_MenuOption_Background"]         = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_MenuOption_Border"]             = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_MenuOption_Hover"]              = (Brush)(new BrushConverter().ConvertFrom("#FF" + "404040"));
            Resources["themeclr_MenuOption_Clicked"]            = (Brush)(new BrushConverter().ConvertFrom("#FF" + "79517d"));
            Resources["themeclr_MenuOption_Selected"]           = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c0c0c0"));

            Resources["themeclr_SubMenu_Background"]            = (Brush)(new BrushConverter().ConvertFrom("#FF" + "232027"));
            Resources["themeclr_SubMenuOption_Text"]            = Resources["themeclr_Text_Secondary"];
            Resources["themeclr_SubMenuOption_Background"]      = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_SubMenuOption_Border"]          = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_SubMenuOption_Hover"]           = (Brush)(new BrushConverter().ConvertFrom("#FF" + "404040"));
            Resources["themeclr_SubMenuOption_Clicked"]         = (Brush)(new BrushConverter().ConvertFrom("#FF" + "79517d"));
            Resources["themeclr_SubMenuOption_Selected"]        = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c0c0c0"));

            Resources["themeclr_Group_Background"]              = (Brush)(new BrushConverter().ConvertFrom("#00" + "000000"));
            Resources["themeclr_Group_Border"]                  = (Brush)(new BrushConverter().ConvertFrom("#FF" + "FFFFFF"));
            Resources["themeclr_TextBox_Text"]                  = Resources["themeclr_Text_Secondary"];
            Resources["themeclr_TextBox_Background"]            = (Brush)(new BrushConverter().ConvertFrom("#80" + "0f0f0f"));
            Resources["themeclr_TextBox_Border"]                = (Brush)(new BrushConverter().ConvertFrom("#80" + "FF0000"));
            Resources["themeclr_TextBox_Hover"]                 = (Brush)(new BrushConverter().ConvertFrom("#80" + "c0c0c0"));
            Resources["themeclr_TextBox_Focus"]                 = (Brush)(new BrushConverter().ConvertFrom("#80" + "79517d"));

            Resources["themeclr_ListBox_Text"]                  = Resources["themeclr_Text_Primary"];
            Resources["themeclr_ListBox_Background"]            = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_ListBox_Border"]                = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));

            Resources["themeclr_ComboBox_Text"]                 = Resources["themeclr_Text_Primary"];
            Resources["themeclr_ComboBox_Arrow"]                = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_ComboBox_Background"]           = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_ComboBox_Border"]               = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));

            Resources["themeclr_Scroll_Thumb"]                  = Resources["themeclr_Text_Primary"];
            Resources["themeclr_Scroll_Arrows"]                 = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_Scroll_Background"]             = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
            Resources["themeclr_Scroll_Border"]                 = (Brush)(new BrushConverter().ConvertFrom("#FF" + "c000c0"));
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

        private void addSubMenu(StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            dataSubPanels[baseName] = subMenu;
            dataSubPanelsInfo[baseName + "_Hidden"] = 0;
            this.RegisterName(dataSubPanels[baseName].Name, dataSubPanels[baseName]);
        }

        private void hideSubMenu(StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            // Set element scale to a scale variable for animation
            ScaleTransform scale = new ScaleTransform(
                objToDouble(dataSubPanels[baseName].LayoutTransform.GetValue(ScaleTransform.ScaleXProperty)),
                objToDouble(dataSubPanels[baseName].LayoutTransform.GetValue(ScaleTransform.ScaleYProperty))
            );
            dataSubPanels[baseName].LayoutTransform = scale;

            // Set up animation and add completion handler
            menuSlide = new DoubleAnimation(0.0, new Duration(TimeSpan.FromMilliseconds(panelOpenTime)));
            menuSlide.Completed += new EventHandler((sender, e) => menuSlideComplete(sender, e, dataSubPanels[baseName], 1));

            // Add animation to storyboard and play it
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
                    // Set element scale to a scale variable for animation
                    ScaleTransform scale = new ScaleTransform(
                        objToDouble(subMenu.Value.LayoutTransform.GetValue(ScaleTransform.ScaleXProperty)),
                        objToDouble(subMenu.Value.LayoutTransform.GetValue(ScaleTransform.ScaleYProperty))
                    );
                    subMenu.Value.LayoutTransform = scale;

                    // Set up animation and add completion handler
                    menuSlide = new DoubleAnimation(0.0, new Duration(TimeSpan.FromMilliseconds(panelOpenTime)));
                    menuSlide.Completed += new EventHandler((sender, e) => menuSlideComplete(sender, e, subMenu.Value, 1));

                    // Add animation to storyboard and play it
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
                // Close this submenu instead if it was open
                hideSubMenu(subMenu);
                return;
            }
            else if (dataSubPanelsInfo[baseName + "_Hidden"] == 1)
            {
                // Close every other sub menu before opening the target menu
                hideSubMenus(subMenu);

                // Set element scale to a scale variable for animation
                ScaleTransform scale = new ScaleTransform(
                    objToDouble(dataSubPanels[baseName].LayoutTransform.GetValue(ScaleTransform.ScaleXProperty)),
                    objToDouble(dataSubPanels[baseName].LayoutTransform.GetValue(ScaleTransform.ScaleYProperty))
                );
                dataSubPanels[baseName].LayoutTransform = scale;

                // Set up animation and add completion handler
                menuSlide = new DoubleAnimation(1.0, new Duration(TimeSpan.FromMilliseconds(panelOpenTime)));
                menuSlide.Completed += new EventHandler((sender, e) => menuSlideComplete(sender, e, subMenu, 0));

                // Add animation to storyboard and play it
                menuStory.Children.Add(menuSlide);
                Storyboard.SetTarget(menuSlide, dataSubPanels[baseName]);
                Storyboard.SetTargetProperty(menuSlide, new PropertyPath("LayoutTransform.ScaleY"));
                menuStory.Begin(this);

                return;
            }
        }

        private void menuSlideComplete(object sender, EventArgs e, StackPanel subMenu, int setHidden)
        {
            dataSubPanelsInfo[subMenu.Name.Replace("submenupanel_", "") + "_Hidden"] = setHidden;
        }

        private void openChildForm(Window childWindow)
        {
//
        }

        #endregion

        private void btnPages_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(submenupanel_Pages);
        }
    }
}