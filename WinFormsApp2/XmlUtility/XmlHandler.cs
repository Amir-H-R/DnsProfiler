using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WinFormsApp2.XmlUtility
{
    internal class XmlHandler
    {
        string fileName;
        string profileDirectory;
        XElement profileXml;
        internal XmlHandler()
        {

            fileName = "Profiles.xml";
            profileDirectory = Directory.GetCurrentDirectory() + $"\\{fileName}";
            CkeckXmlExistence.Check(profileDirectory, fileName);
            profileXml = XElement.Load(profileDirectory);
        }
        internal IList<Profile> GetAllProfiles()
        {
            IList<Profile> profiles = profileXml.Descendants("Profile").Select(p => new Profile
            {
                Id = p.Element("Id").Value,
                Name = p.Element("Name").Value,
                PrimaryDns = p.Element("PrimaryDns").Value,
                SecondaryDns = p.Element("SecondaryDns").Value
            }).ToList();
            return profiles;
        }

        internal Profile GetProfile(string id)
        {
            var profile = GetAllProfiles().Where(p => p.Id == id).FirstOrDefault();
            if (profile == null)
            {
                return new Profile()
                {
                    SecondaryDns = " ",
                    PrimaryDns = " ",
                    Id = " "
                };
            }
            return profile;
        }

        internal static void AddNewProfile(string primaryDns, string secondaryDns, string name)
        {
            XmlHandler handler = new XmlHandler();
            string profileDirectory = Directory.GetCurrentDirectory() + $"\\{handler.fileName}";

            CkeckXmlExistence.Check(profileDirectory, handler.fileName);

            XElement newProfile = MakeProfileTemplate(primaryDns, secondaryDns, name);

            XElement profileXml = XElement.Load(profileDirectory);
            profileXml.Add(newProfile);
            profileXml.Save(profileDirectory);


            static XElement MakeProfileTemplate(string primaryDns, string secondaryDns, string name)
            {
                XElement newProfile = new XElement("Profile",
                                  new XElement("Id", Guid.NewGuid().ToString().Substring(0, 4)),
                                  new XElement("Name", name),
                                  new XElement("PrimaryDns", primaryDns),
                                  new XElement("SecondaryDns", secondaryDns));
                return newProfile;
            }
        }

        internal void DeleteProfile(string id)
        {
            XmlHandler xmlHandler = new XmlHandler();
            var profile = xmlHandler.profileXml.Descendants("Profile").Where(p => p.FirstNode.ToString().Contains(id));
            profile.Remove();
            xmlHandler.profileXml.Save(profileDirectory);
        }
    }
}
