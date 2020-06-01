using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;

namespace BitzDrawingFileCreator_WPF
{
    class MessageBoxHandler
    {
        public static bool showMessageBox(string message = "", string title = "", string confirmButton = "Okay")
        {
            BitzMessageBox loMessageWindow = new BitzMessageBox();
            StringBuilder loStringBuilder = new StringBuilder();
            bool loBoolean = false;

            loStringBuilder.Append(message);
            loStringBuilder.Append(Environment.NewLine + Environment.NewLine);
            loStringBuilder.Append(Environment.NewLine + Environment.NewLine);
            loStringBuilder.Append(Environment.NewLine + Environment.NewLine);

            loMessageWindow.txtbTitle.Text = title;
            loMessageWindow.txtbMessage.Text = loStringBuilder.ToString();
            loMessageWindow.btnConfirm.Content = confirmButton;
            loMessageWindow.Owner = Application.Current.MainWindow;
            loMessageWindow.Topmost = true;

            loMessageWindow.Owner.Effect = new BlurEffect();
            loBoolean = (bool)loMessageWindow.ShowDialog();
            loMessageWindow.Owner.Effect = null;

            return loBoolean;
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

            loMessageWindow.Owner.Effect = new BlurEffect();
            bool? result = loMessageWindow.ShowDialog();
            loMessageWindow.Owner.Effect = null;

            if (result.HasValue)
                return loMessageWindow.diagAnswer;
            return false;
        }
    }
}
