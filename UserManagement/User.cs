using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace UserManagement
{
    public class User
    {
        public User()
        {

        }


        public string SaveUserInfo(UserBE obj)
        {

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(obj.FilePath);

            XmlNode xList = xDoc.ChildNodes[1].ChildNodes[0];
            XmlNode FirstName = xDoc.CreateNode(XmlNodeType.Element, "FirstName", null);
            FirstName.InnerText = obj.FirstName;
            xList.AppendChild(FirstName);

            XmlNode lastName = xDoc.CreateNode(XmlNodeType.Element, "LastName", null);
            lastName.InnerText = obj.LastName;
            xList.AppendChild(lastName);

            XmlNode UserName = xDoc.CreateNode(XmlNodeType.Element, "UserName", null);
            UserName.InnerText = obj.UserName;
            xList.AppendChild(UserName);

            XmlNode Age = xDoc.CreateNode(XmlNodeType.Element, "Age", null);
            Age.InnerText = obj.Age.ToString();
            xList.AppendChild(Age);

            xDoc.Save(obj.FilePath);
            // xDoc.DocumentElement.AppendChild()

            // xDoc.DocumentElement.AppendChild(xList);


            return "User Saved Successfully";
        }
    }
}
