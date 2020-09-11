﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Xml;

namespace BitzDrawingFileCreator_WPF.Data
{
    public class SystemHandler
    {
        public static string read_Setting(string setting_Name)

        {

            //----------< save_Settings() >----------

            string sResult = "";



            //< get Setting >

            if (Properties.Settings.Default.Properties[setting_Name] != null)

            {

                sResult = Properties.Settings.Default.Properties[setting_Name].DefaultValue.ToString();

            }

            //</ get Setting >



            //< correct >

            if (sResult == "NaN") sResult = "0";

            //</ correct >



            //< output >

            return sResult;

            //</ output >



            //----------</ save_Settings() >----------

        }
        public static void save_Setting(string setting_Name, string setting_Value)

        {

            //----------< save_Settings() >----------



            string property_name = setting_Name;



            //< Setting erstellen >

            SettingsProperty prop = null;

            if (Properties.Settings.Default.Properties[property_name] != null)

            {

                //< existing Setting >

                prop = Properties.Settings.Default.Properties[property_name];

                //</ existing Setting >

            }

            else

            {

                //< new Setting >

                prop = new System.Configuration.SettingsProperty(property_name);

                prop.PropertyType = typeof(string);

                Properties.Settings.Default.Properties.Add(prop);

                Properties.Settings.Default.Save();

                //</ new Setting >

            }

            //</ Setting erstellen >



            //< set value  >

            Properties.Settings.Default.Properties[property_name].DefaultValue = setting_Value;

            //</ set value >



            //< Save Settings File >

            Properties.Settings.Default.Save();

            //</ Save Settings File >



            //----------</ save_Settings() >----------

        }
    }
}