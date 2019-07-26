using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace WebAPI.Models
{
    public class User
    {
        public int Status
        {
            get;
            set;
        }

        public string Result
        {
            get;
            set;
        }
    }


    public class UserRegistration
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }


        public string City
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
    }

    public class ICEXMLSerializer
    {
        public T Deserialize<T>(string input, string Root = "") where T : class
        {
            T result = null;
            try
            {
                System.Xml.Serialization.XmlSerializer ser;
                if (Root == "")
                    ser = new System.Xml.Serialization.XmlSerializer(typeof(T));
                else
                    ser = new System.Xml.Serialization.XmlSerializer(typeof(T), new XmlRootAttribute(Root));

                using (StringReader sr = new StringReader(input))
                {
                    result = (T)ser.Deserialize(sr);
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public string Serialize<T>(T ObjectToSerialize, string Root = "")
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer;
            if (Root == "")
                xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());
            else
                xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType(), new XmlRootAttribute(Root));

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
    }
}