using System;
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
        public bool WriteToConfig(List<string> hierachy, string attribute, string data)
        {
            // Create a new file in C:\\ dir  
            var xmlWriter = new XmlTextWriter("C:\\myXmFile.xml", null);

            xmlWriter.WriteStartDocument();

            foreach (var ch in hierachy)
            {
                xmlWriter.WriteStartElement(ch);
            }
            

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "42");
            xmlWriter.WriteString("John Doe");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "39");
            xmlWriter.WriteString("Jane Doe");

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            /*
                XmlDocument xml = new XmlDocument();
                xml.LoadXml("<Students>...."); // or xml.Load("yourfile.xml");
                XmlElement student = xml.SelectSingleNode(
                    String.Format("//Student[@ID='{0}']",
                                  yourcombo.SelectedItem.Value)) as XmlElement;
                if(student != null)
                {
                    XmlElement another = xml.CreateElement("another");
                    another.InnerText = "Value";
                    student.AppendChild(another);

                    // do other stuff
                }
             */

            return true;
        }
    }
}
