using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BitzDrawingFileCreator_WPF
{
    class DirectoryParser
    {
        public static string folderFormat = "$ROOT|$Drawing_Product~s\\$Target_Platform\\$User_Name\\$Date\\";
        public static string fileNameFormat = "[$Date] [$User_Name] [$Target_Platform] [$Drawing_Product] [$Characters] [$Drawing_Type] [$Drawing_Render] [PROJECT] [A]";

        #region Tag Retrievals

        private string _ROOT_Get()
        {
            //return @"G:\\Mega Sync Drive\\SYNCHRONOUS\\Projects\\Drawings\\";
            return "C:\\Mega Sync Drive\\SYNCHRONOUS\\Projects\\Drawings\\";
        }

        private string _Character_Get()
        {
            return "(" + ((PageMain)MainWindow.activePage).listboxCharacters.Items[0].ToString() + ")";
        }

        private string _Character_Name_Get()
        {
            System.Windows.Controls.ItemCollection _lstItems = ((PageMain)MainWindow.activePage).listboxCharacters.Items;
            return "(" + _lstItems[0].ToString().Split('-')[0] + ")";
        }

        private string _Character_Species_Get()
        {
            System.Windows.Controls.ItemCollection _lstItems = ((PageMain)MainWindow.activePage).listboxCharacters.Items;
            return "(" + _lstItems[0].ToString().Split('-')[1] + ")";
        }

        private string _Characters_Get()
        {
            string returnString = "";
            System.Windows.Controls.ItemCollection _lstItems = ((PageMain)MainWindow.activePage).listboxCharacters.Items;

            for (int x = 0; x < _lstItems.Count; x++)
                returnString += "(" + _lstItems[x].ToString() + ")";

            return returnString;
        }

        private string _Characters_Name_Get()
        {
            string returnString = "";
            System.Windows.Controls.ItemCollection _lstItems = ((PageMain)MainWindow.activePage).listboxCharacters.Items;

            for (int x = 0; x < _lstItems.Count; x++)
                returnString += "(" + _lstItems[x].ToString().Split('-')[0] + ")";

            return returnString;
        }

        private string _Characters_Species_Get()
        {
            string returnString = "";
            System.Windows.Controls.ItemCollection _lstItems = ((PageMain)MainWindow.activePage).listboxCharacters.Items;

            for (int x = 0; x < _lstItems.Count; x++)
                returnString += "(" + _lstItems[x].ToString().Split('-')[1] + ")";

            return returnString;
        }

        private string _Drawing_Product_Get()
        {
            return MainWindow.publicDataContext.drawingProduct;
        }

        private string _Drawing_Render_Get()
        {
            return MainWindow.publicDataContext.drawingRender;
        }

        private string _Drawing_Type_Get()
        {
            return MainWindow.publicDataContext.drawingType;
        }

        private string _Target_Platform_Get()
        {
            return MainWindow.publicDataContext.targetPlatform;
        }

        private string _User_Name_Get()
        {
            return MainWindow.publicDataContext.userName;
        }

        public string _Date_Get()
        {
            return DateTime.Today.ToString("yyyy-MM-dd");
        }

        #endregion

        #region Format Methods

        public string parseFormatString(string formatString)
        {
            var index = -1;

            var _cmd_pos = new List<int>();
            var _cmds = new List<string>();
            string _fnc_cmd = "";
            string _return = formatString;


            // Find starting positions of all calling tags
                // Ends when i=-1 ('$' not found)
            for (int i = formatString.IndexOf('$'); i > -1; i = formatString.IndexOf('$', i + 1))
                _cmd_pos.Add(i);

            

            for (int i = 0; i < _cmd_pos.Count; i++)
            {
                if (i < _cmd_pos.Count - 1)
                    _cmds.Add(formatString.Slice(_cmd_pos[i], _cmd_pos[1 + i]));
                else
                    _cmds.Add(formatString.Slice(_cmd_pos[i], formatString.Length));

                System.Diagnostics.Debug.WriteLine("Rough Command: " + _cmds[i]);
            }

            foreach (string cmd in _cmds)
            {
                index = -1;
                var matches = Regex.Matches(cmd.Replace("$", ""), @"[^a-zA-Z_ ]");
                if (matches.Count > 0) { index = matches[0].Index; }

                string _scrub_cmd = (index == -1) ? cmd : cmd.Replace(cmd.Slice(index + 1, cmd.Length), "");
                _fnc_cmd = "_" + _scrub_cmd.Replace("$", "") + "_Get";
                System.Diagnostics.Debug.WriteLine("Scrubbed: " + _scrub_cmd + "\nCommand: " + _fnc_cmd);

                MethodInfo tagMethod = this.GetType().GetMethod(_fnc_cmd, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                if (tagMethod != null)
                    _return = _return.Replace(_scrub_cmd, (string)tagMethod.Invoke(this, null));

            }
            _return = _return.Replace("~", "");
            _return = _return.Replace("@", "/");
            _return = _return.Replace("|", "");

            return _return;
        }

        #endregion
    }
}
