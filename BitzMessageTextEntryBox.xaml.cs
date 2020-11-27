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
using System.Windows.Shapes;

namespace BitzDrawingFileCreator_WPF
{
    /// <summary>
    /// Interaction logic for BitzMessageTextEntryBox.xaml
    /// </summary>
    public partial class BitzMessageTextEntryBox : Window
    {
        public string diagAnswer = "";

        public BitzMessageTextEntryBox()
        {
            InitializeComponent();

            DataContext = MainWindow.publicDataContext;
        }

        #region Window Fade In/Out
        private bool closeCompleted = false;

        private void FormFadeOut_Completed(object sender, EventArgs e)
        {
            closeCompleted = true;
            this.Close();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!closeCompleted)
            {
                FormFadeOut.Begin();
                e.Cancel = true;
            }
        }
        #endregion

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            diagAnswer = txtDiagEntry.Text;
            this.DialogResult = true;
        }
    }
}
