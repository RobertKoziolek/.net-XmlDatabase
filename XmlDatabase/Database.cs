using System;
using System.IO;
using System.Text;
using System.Xml;

namespace XmlDatabase
{
    public class Database
    {
        private string filepath;

        public Database(string filepath)
        {
            this.filepath = filepath;//TODO filepath validation
            if (File.Exists(filepath) == false)
            {
                InitializeDatabase();
            }
        }

        private void InitializeDatabase()
        {
            XmlTextWriter writer;
            writer = new XmlTextWriter(filepath, Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteStartElement("People");
            writer.WriteEndElement();
            writer.Close();
        }

        public void Add(Person person)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fileStream = new FileStream(filepath, FileMode.Open);
            xmlDocument.Load(fileStream);
            XmlElement personElement = xmlDocument.CreateElement("Person");

            addPersonElement("Name", person.Name, xmlDocument, personElement);
            addPersonElement("Surname", person.Surname, xmlDocument, personElement);
            addPersonElement("Age", person.Age.ToString(), xmlDocument, personElement);
            addPersonElement("City", person.City, xmlDocument, personElement);
            addPersonElement("Phone", person.Phone, xmlDocument, personElement);

            xmlDocument.DocumentElement.AppendChild(personElement);
            fileStream.Close();
            xmlDocument.Save(filepath);
        }

        private void addPersonElement(string elementName, string elementValue, XmlDocument xmlDocument, XmlElement personElement)
        {
            XmlElement element = xmlDocument.CreateElement(elementName);
            XmlText text = xmlDocument.CreateTextNode(elementValue);
            element.AppendChild(text);

            personElement.AppendChild(element);
        }

        public Person FindByPhone(string phoneNumber)//TODO zmienic na kazde pole
        {
            Person person = new Person();
            XmlDocument xdoc = new XmlDocument();
            FileStream rfile = new FileStream(filepath, FileMode.Open);
            xdoc.Load(rfile);
            XmlNodeList list = xdoc.GetElementsByTagName("Person");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement cl = (XmlElement)xdoc.GetElementsByTagName("Phone")[i];
                if (phoneNumber.Equals(cl.InnerText))
                {
                    XmlElement nameElement = (XmlElement)xdoc.GetElementsByTagName("Name")[i];
                    XmlElement surnameElement = (XmlElement)xdoc.GetElementsByTagName("Surname")[i];
                    XmlElement ageElement = (XmlElement)xdoc.GetElementsByTagName("Age")[i];
                    XmlElement cityElement = (XmlElement)xdoc.GetElementsByTagName("City")[i];
                    XmlElement phoneElement = (XmlElement)xdoc.GetElementsByTagName("Phone")[i];

                    person.Name = nameElement.InnerText;
                    person.Surname = surnameElement.InnerText;
                    person.Age = Int32.Parse(ageElement.InnerText);
                    person.City = cityElement.InnerText;
                    person.Phone = phoneElement.InnerText;
                    break;
                }
            }
            rfile.Close();
            return person;
        }
    }
}