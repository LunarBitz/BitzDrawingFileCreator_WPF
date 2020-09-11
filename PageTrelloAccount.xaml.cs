using BitzDrawingFileCreator_WPF.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for PageTrelloAccount.xaml
    /// </summary>
    public partial class PageTrelloAccount : Page
    {
        public PageTrelloAccount()
        {
            InitializeComponent();
            DataContext = MainWindow.publicDataContext;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string tak = SystemHandler.read_Setting("Trello_API_Key");
            Console.WriteLine("ASGGSGS" + tak );
            if (tak != null || tak != "")
            {
                MainWindow.publicDataContext.trelloApiKey = tak;
            }

            string tt = SystemHandler.read_Setting("Trello_Token");
            Console.WriteLine("ASGGSGS" + tt);
            if (tt != null || tt != "")
            {
                MainWindow.publicDataContext.trelloToken = tt;
            }

        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            SystemHandler.save_Setting("Trello_API_Key", MainWindow.publicDataContext.trelloApiKey);
            SystemHandler.save_Setting("Trello_Token", MainWindow.publicDataContext.trelloToken);
        }
    }
}
