using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitzDrawingFileCreator_WPF.Data
{
    public class AppData : ObservableObject
    {

        #region UserName
        private string _userName;
        public string userName 
        { 
            get
            {
                if (string.IsNullOrEmpty(_userName))
                    return " ";
                return _userName;
            }
            set
            {
                _userName = value;
                OnPropertyChanged("userName");
            }
        }
        #endregion
    
    }
}
