using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp2.XmlUtility
{
    internal static class CkeckXmlExistence
    {
        internal static void Check(string directory,string fileName)
        {
            if (!File.Exists(directory))
            {
                using (XmlTextWriter xmlText = new XmlTextWriter(fileName, Encoding.UTF8))
                {
                    xmlText.WriteStartElement("Profiles");
                    xmlText.WriteFullEndElement();

                }
            }
        }
    }
}
