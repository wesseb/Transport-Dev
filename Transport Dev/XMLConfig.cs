using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Transport_Dev
{
    public static class XMLConfig
    {
        private const string xmlFileName = @"config.xml";

        public static void saveXMLConfigFile (string hostName, string port, string DBname, string userName, string? password = null)
        {
            try
            {
                if (!File.Exists(xmlFileName))
                {
                    XDocument xDoc = new XDocument(
                    new XElement("SQL",
                        new XElement("Host", hostName),
                        new XElement("Port", port),
                        new XElement("DBname", DBname),
                        new XElement("User", userName),
                        password != null ? new XElement("Password", AesEncrypter.EncryptToAesAndOutput(password)) : null
                        )
                    );

                    xDoc.Save(xmlFileName);
                }
                else
                {
                    XDocument xDoc = XDocument.Load(xmlFileName);

                    foreach (XElement e in xDoc.Elements())
                    {
                        e.SetElementValue("Host", hostName);
                        e.SetElementValue("Port", port);
                        e.SetElementValue("DBname", DBname);
                        e.SetElementValue("User", userName);
                        if (password != null)
                        {
                            e.SetElementValue ("Password", AesEncrypter.EncryptToAesAndOutput(password));
                        }
                        else
                        {
                            e.SetElementValue("Password", null);
                        }
                    }

                    xDoc.Save(xmlFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                MessageBox.Show("Zapisano zmiany!", "OK");
            }
        }
    }
}