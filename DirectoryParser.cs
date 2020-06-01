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
        public static string folderFormat = "$ROOT/$Drawing_Product~s/$Target_Platform/$User_Name/$Date";
        public static string fileNameFormat = "[$Date] [$User_Name] [$Target_Platform] [$Drawing_Product] [$Characters] [$Drawing_Type] [$Drawing_Render] [PROJECT] [A]";

        #region Tag Retrievals

        private string _ROOT_Get()
        {
            return @"G:\\Mega Sync Drive\\SYNCHRONOUS\\Projects";
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
            Regex pattern = new Regex("[^0-9a-zA-Z_$]+");
            var matches = Regex.Matches(formatString, @"[^a-zA-Z ]");

            var _cmd_pos = new List<int>();
            var _cmds = new List<string>();
            string _fnc_cmd = "";
            string _return = formatString;


            // Find starting positions of all calling tags
                // Ends when i=-1 ('$' not found)
            for (int i = formatString.IndexOf('$'); i > -1; i = formatString.IndexOf('$', i + 1))
                _cmd_pos.Add(i);

            var index = -1;
            
            if (matches.Count > 1)  // at least 2
            {
                index = matches[1].Index;
            }

            for (int i = 0; i < _cmd_pos.Count; i++)
            {
                if (i < _cmd_pos.Count - 1)
                    _cmds.Add(formatString.Substring(_cmd_pos[i], Math.Min(formatString.Length, _cmd_pos[1 + i]) - _cmd_pos[i]));
                else
                    _cmds.Add(formatString.Substring(_cmd_pos[i], Math.Min(formatString.Length, formatString.Length) - _cmd_pos[i]));

                _cmds[i] = pattern.Replace(_cmds[i], "");
                System.Diagnostics.Debug.WriteLine("Command: " + _cmds[i]);
            }

            foreach (string cmd in _cmds)
            {
                string _ext = cmd.Substring(cmd.LastIndexOf('!'), cmd.Length).Replace("!", "");
                _fnc_cmd = "_" + cmd.Replace("$", "").Replace(_ext, "") + "_Get";
                MethodInfo tagMethod = this.GetType().GetMethod(_fnc_cmd, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                if (tagMethod != null)
                {
                    _return = _return.Replace(cmd, (string)tagMethod.Invoke(this, null));
                    _return = _return.Replace(_ext, "");
                }

            }

            _return = _return.Replace("@", "/");
            _return = _return.Replace("|", "");

            return _return;
        }

        #endregion
    }
}
