using BitzDrawingFileCreator_WPF.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        public static AppData publicDataContext;

        public static Page activePage = null;

        /// <summary>
        /// Storyboard handler for all animations
        /// </summary>
        public Dictionary<string, Storyboard> menuStories = null;

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

            DirectoryParser.folderFormat = "$ROOT|$Drawing_Product~s\\$Target_Platform\\$User_Name\\$Date\\";
            DirectoryParser.fileNameFormat = "[$Date] [$User_Name] [$Target_Platform] [$Drawing_Product] [$Characters] [$Drawing_Type] [$Drawing_Render] [PROJECT] [A]";

            Height = 510;
            Width = 872;

            publicDataContext = new AppData();
            DataContext = publicDataContext;

            // Initialize the necessary components
            menuSlide = new DoubleAnimation();
            menuStories = new Dictionary<string, Storyboard>();
            dataSubPanels = new Dictionary<string, StackPanel>();
            dataSubPanelsInfo = new Dictionary<string, int>();

            // Add the panels to the submenu dictionaries and app registry
            addSubMenu(submenupanel_Pages);
            addSubMenu(submenupanel_Create);
            addSubMenu(submenupanel_Settings);

            // Default the theme and menu
            initThemeColors();
            hideSubMenus();

            // Load inital page to sub view
            activePage = new PageMain();
            frameMainView.Navigate(activePage);
        }

        private void initThemeColors()
        {
            publicDataContext.theme_Text_Primary = "#FF" + "c000c0";
            publicDataContext.theme_Text_Secondary = "#FF" + "5f2568";
            publicDataContext.theme_Text_Tertiary = "#FF" + "341d38";

            publicDataContext.theme_MenuLogo_Background_Primary = "#FF" + "3f164d";
            publicDataContext.theme_MenuLogo_Background_Secondary = "#00" + "000000";

            publicDataContext.theme_Button_Text = publicDataContext.theme_Text_Primary;
            publicDataContext.theme_Button_Background = "#80" + "0f0f0f";
            publicDataContext.theme_Button_Border = "#00" + "000000";
            publicDataContext.theme_Button_Hover = "#FF" + "404040";
            publicDataContext.theme_Button_Clicked = "#FF" + "79517d";
            publicDataContext.theme_Button_Selected = "#FF" + "c0c0c0";

            publicDataContext.theme_Menu_Background_Primary = "#FF" + "0f0f0f";
            publicDataContext.theme_Menu_Background_Secondary = "#00" + "1f1f1f";

            publicDataContext.theme_MenuOption_Text = publicDataContext.theme_Text_Primary;
            publicDataContext.theme_MenuOption_Background = "#00" + "000000";
            publicDataContext.theme_MenuOption_Border = "#00" + "000000";
            publicDataContext.theme_MenuOption_Hover = "#FF" + "404040";
            publicDataContext.theme_MenuOption_Clicked = "#FF" + "79517d";
            publicDataContext.theme_MenuOption_Selected = "#FF" + "c0c0c0";

            publicDataContext.theme_SubMenu_Background = "#FF" + "232027";

            publicDataContext.theme_SubMenuOption_Text = publicDataContext.theme_Text_Secondary;
            publicDataContext.theme_SubMenuOption_Background = "#00" + "000000";
            publicDataContext.theme_SubMenuOption_Border = "#00" + "000000";
            publicDataContext.theme_SubMenuOption_Hover = "#FF" + "404040";
            publicDataContext.theme_SubMenuOption_Clicked = "#FF" + "79517d";
            publicDataContext.theme_SubMenuOption_Selected = "#FF" + "c0c0c0";

            publicDataContext.theme_Group_Background = "#00" + "000000";
            publicDataContext.theme_Group_Border = "#80" + "9e9e9e";

            publicDataContext.theme_TextBox_Text = publicDataContext.theme_Text_Secondary;
            publicDataContext.theme_TextBox_Background = "#80" + "0f0f0f";
            publicDataContext.theme_TextBox_Border = "#80" + "79517d";
            publicDataContext.theme_TextBox_Hover = "#80" + "c0c0c0";
            publicDataContext.theme_TextBox_Focus = "#80" + "9e9e9e";
            publicDataContext.theme_TextBox_Inactive = "#80" + "1f1f1f";

            publicDataContext.theme_ListBox_Text = publicDataContext.theme_Text_Secondary;
            publicDataContext.theme_ListBox_Background = "#80" + "0f0f0f";
            publicDataContext.theme_ListBox_Border = "#80" + "79517d";

            publicDataContext.theme_ComboBox_Text = publicDataContext.theme_Text_Primary;
            publicDataContext.theme_ComboBox_Arrow = "#FF" + "c000c0";
            publicDataContext.theme_ComboBox_Arrow_Hover = "#FF" + "404040";
            publicDataContext.theme_ComboBox_Background = "#80" + "0f0f0f";
            publicDataContext.theme_ComboBox_Hover = "#FF" + "404040";
            publicDataContext.theme_ComboBox_Pressed = "#FF" + "79517d";
            publicDataContext.theme_ComboBox_Border = "#80" + "79517d";
            publicDataContext.theme_ComboBox_Sub_Text = publicDataContext.theme_Text_Secondary;
            publicDataContext.theme_ComboBox_Sub_Background = "#FF" + "232027";
            publicDataContext.theme_ComboBox_Sub_Hover = "#FF" + "404040";
            publicDataContext.theme_ComboBox_Sub_Pressed = "#FF" + "79517d";
            publicDataContext.theme_ComboBox_Sub_Border = "#00" + "000000";

            publicDataContext.theme_Scroll_Thumb = publicDataContext.theme_Text_Secondary;
            publicDataContext.theme_Scroll_Background_Primary = "#00" + "0f0f0f";
            publicDataContext.theme_Scroll_Background_Secondary = "#FF" + "000000";

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

            menuStories[baseName] = new Storyboard();
            dataSubPanels[baseName] = subMenu;
            dataSubPanelsInfo[baseName + "_Hidden"] = 0;
            this.RegisterName(dataSubPanels[baseName].Name, dataSubPanels[baseName]);
        }

        private void hideSubMenu(StackPanel subMenu)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            if (dataSubPanelsInfo[baseName + "_Hidden"] == 0)
            {
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
                menuStories[baseName].Children.Add(menuSlide);
                Storyboard.SetTarget(menuSlide, dataSubPanels[baseName]);
                Storyboard.SetTargetProperty(menuSlide, new PropertyPath("LayoutTransform.ScaleY"));
                menuStories[baseName].Begin(this);
            }
        }

        private void hideSubMenus(StackPanel exclusion = null)
        {
            foreach (KeyValuePair<string, StackPanel> subMenu in dataSubPanels)
            {
                if (subMenu.Value != exclusion)
                {
                    hideSubMenu(subMenu.Value);
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
            if (dataSubPanelsInfo[baseName + "_Hidden"] == 1)
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
                menuStories[baseName].Children.Add(menuSlide);
                Storyboard.SetTarget(menuSlide, dataSubPanels[baseName]);
                Storyboard.SetTargetProperty(menuSlide, new PropertyPath("LayoutTransform.ScaleY"));
                menuStories[baseName].Begin(this);

                return;
            }
        }

        private void menuSlideComplete(object sender, EventArgs e, StackPanel subMenu, int setHidden)
        {
            string baseName = subMenu.Name.Replace("submenupanel_", "");

            menuStories[baseName] = new Storyboard();
            dataSubPanelsInfo[baseName + "_Hidden"] = setHidden;
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

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(submenupanel_Create);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            showSubMenu(submenupanel_Settings);
        }

        private void btnCreateFiles_Click(object sender, RoutedEventArgs e)
        {
            bool _result = MessageBoxHandler.showYesNoBox("Are you sure that you want to create the directories?", "Create Directories?", "Yeah", "Nah");
            if (_result == false)
                return;

            DirectoryParser _dirParse = new DirectoryParser();

            var _subFolders = new List<string>();
            _subFolders.Add("REFERENCES\\RENDERS");
            _subFolders.Add("PROGRESS");
            _subFolders.Add("EXPORT");

            string folderRoot = System.IO.Path.Combine(_dirParse.parseFormatString(DirectoryParser.folderFormat));
            string fileName = System.IO.Path.Combine(_dirParse.parseFormatString(DirectoryParser.fileNameFormat));



            foreach (string subFolder in _subFolders)
            {
                string _newPath = System.IO.Path.Combine(folderRoot, subFolder);
                Directory.CreateDirectory(_newPath);
                System.Diagnostics.Debug.WriteLine(_newPath);
            }

            StreamWriter sw = File.AppendText(folderRoot + fileName + ".txt");
            sw.Write(publicDataContext.drawingDescription);

            try
            {
                _result = MessageBoxHandler.showYesNoBox("Would you like to open your new folders?", "Open Directories?", "Pwease! OwO", "No Thankis. UwU");
                if (_result == true)
                    System.Diagnostics.Process.Start("explorer.exe", folderRoot);

            }
            catch (System.ComponentModel.Win32Exception win32Exception)
            {
                //The system cannot find the file specified...
                Console.WriteLine(win32Exception.Message);
            }

        }
        
    }
}