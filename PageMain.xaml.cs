﻿using BitzDrawingFileCreator_WPF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BitzDrawingFileCreator_WPF
{
    /// <summary>
    /// Interaction logic for PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
            DataContext = MainWindow.publicDataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.publicDataContext.userName = "CCCCC";
            randomizeTheme();
        }

        private string rndColor()
        {
            return String.Format("#{0:X6}", new Random((int)DateTime.Now.Ticks).Next(0x1000000)).Replace("#", ""); // = "#A197B9"
        }

        private void randomizeTheme()
        {
            var con = MainWindow.publicDataContext;

            con.theme_Text_Primary = "#FF" + rndColor();
            con.theme_Text_Secondary = "#FF" + rndColor();
            con.theme_Text_Tertiary = "#FF" + rndColor();

            con.theme_MenuLogo_Background_Primary = "#FF" + rndColor();
            con.theme_MenuLogo_Background_Secondary = "#00" + rndColor();

            con.theme_Button_Text = con.theme_Text_Primary;
            con.theme_Button_Background = "#80" + rndColor();
            con.theme_Button_Border = "#00" + rndColor();
            con.theme_Button_Hover = "#FF" + rndColor();
            con.theme_Button_Clicked = "#FF" + rndColor();
            con.theme_Button_Selected = "#FF" + rndColor();

            con.theme_Menu_Background_Primary = "#FF" + rndColor();
            con.theme_Menu_Background_Secondary = "#00" + rndColor();

            con.theme_MenuOption_Text = con.theme_Text_Primary;
            con.theme_MenuOption_Background = "#00" + rndColor();
            con.theme_MenuOption_Border = "#00" + rndColor();
            con.theme_MenuOption_Hover = "#FF" + rndColor();
            con.theme_MenuOption_Clicked = "#FF" + rndColor();
            con.theme_MenuOption_Selected = "#FF" + rndColor();

            con.theme_SubMenu_Background = "#FF" + rndColor();

            con.theme_SubMenuOption_Text = con.theme_Text_Secondary;
            con.theme_SubMenuOption_Background = "#00" + rndColor();
            con.theme_SubMenuOption_Border = "#00" + rndColor();
            con.theme_SubMenuOption_Hover = "#FF" + rndColor();
            con.theme_SubMenuOption_Clicked = "#FF" + rndColor();
            con.theme_SubMenuOption_Selected = "#FF" + rndColor();

            con.theme_Group_Background = "#00" + rndColor();
            con.theme_Group_Border = "#80" + rndColor();

            con.theme_TextBox_Text = con.theme_Text_Secondary;
            con.theme_TextBox_Background = "#80" + rndColor();
            con.theme_TextBox_Border = "#80" + rndColor();
            con.theme_TextBox_Hover = "#80" + rndColor();
            con.theme_TextBox_Focus = "#80" + rndColor();
            con.theme_TextBox_Inactive = "#80" + rndColor();

            con.theme_ListBox_Text = con.theme_Text_Primary;
            con.theme_ListBox_Background = "#FF" + rndColor();
            con.theme_ListBox_Border = "#FF" + rndColor();

            con.theme_ComboBox_Text = con.theme_Text_Primary;
            con.theme_ComboBox_Arrow = "#FF" + rndColor();
            con.theme_ComboBox_Background = "#FF" + rndColor();
            con.theme_ComboBox_Border = "#FF" + rndColor();

            con.theme_Scroll_Thumb = con.theme_Text_Secondary;
            con.theme_Scroll_Background_Primary = "#00" + rndColor();
            con.theme_Scroll_Background_Secondary = "#FF" + rndColor();
        }
    }
}
