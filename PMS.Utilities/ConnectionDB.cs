using System;
using System.Xml;

namespace PMS.Utilities
{
    public class ConnectionDB
    {
        public static string xml_conn(string path)
        {
            string posServer = "", posDatabase = "", posUser = "", posPassword = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNodeList nodeListPos = xmlDoc.DocumentElement.SelectNodes("/Database/Connection/Pos");

            foreach (XmlNode node in nodeListPos)
            {
                posServer = node.SelectSingleNode("Server").InnerText;
                posDatabase = node.SelectSingleNode("Database").InnerText;
                posUser = node.SelectSingleNode("User").InnerText;
                posPassword = node.SelectSingleNode("Password").InnerText;
            }
            return string.Format("Server = {0}; Database = {1}; User Id = {2}; Password = {3}", posServer, posDatabase, posUser, posPassword);
        }
    }
}
