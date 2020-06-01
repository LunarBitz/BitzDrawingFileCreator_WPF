using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitzDrawingFileCreator_WPF
{
    class MessageBoxHandler
    {
        public static bool showMessageBox(string message = "", string title = "", string confirmButton = "Okay")
        {
            BitzMessageBox loMessageWindow = new BitzMessageBox();
            StringBuilder loStringBuilder = new StringBuilder();

            loStringBuilder.Append(message);
            loStringBuilder.Append(Environment.NewLine + Environment.NewLine);
            loStringBuilder.Append(Environment.NewLine + Environment.NewLine);
            loStringBuilder.Append(Environment.NewLine + Environment.NewLine);

            loMessageWindow.txtbTitle.Text = title;
            loMessageWindow.txtbMessage.Text = loStringBuilder.ToString();
            loMessageWindow.btnConfirm.Content = confirmButton;
            loMessageWindow.Owner = System.Windows.Application.Current.MainWindow;
            
            return (bool)loMessageWindow.ShowDialog();
        }
        public static bool showYesNoBox(string message = "", string title = "", string yesButton = "Yes", string noButton = "No")
        {
            BitzMessageYesNoBox loMessageWindow = new BitzMessageYesNoBox();
            StringBuilder loStringBuilder = new StringBuilder();

            loStringBuilder.Append(message);
            loStringBuilder.Append(Environment.NewLine + Environment.NewLine);
            loStringBuilder.Append(Environment.NewLine + Environment.NewLine);
            loStringBuilder.Append(Environment.NewLine + Environment.NewLine);

            loMessageWindow.txtbTitle.Text = title;
            loMessageWindow.txtbMessage.Text = loStringBuilder.ToString();
            loMessageWindow.btnYes.Content = yesButton;
            loMessageWindow.btnNo.Content = noButton;
            loMessageWindow.Owner = System.Windows.Application.Current.MainWindow;
            bool? result = loMessageWindow.ShowDialog();
             


            if (result.HasValue)
                return loMessageWindow.diagAnswer;
            return false;
        }
    }
}
