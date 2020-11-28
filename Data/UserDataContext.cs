using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitzDrawingFileCreator_WPF.Data
{
    public class UserDataContext
    {
        public UserInfo UserInfo { get; set; }
        public ThemeInfo ThemeInfo { get; set; }
        public EntryInfo EntryInfo { get; set; }
    }
}
