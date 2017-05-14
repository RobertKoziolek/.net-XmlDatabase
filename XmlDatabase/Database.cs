using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace XmlDatabase
{
    public class Database
    {
        private const string INNER_DTD = "<!ELEMENT people (person*)>\n<!ELEMENT person (name,surname,age,city,phone)>\n<!ELEMENT name (#PCDATA)>\n<!ELEMENT surname (#PCDATA)>\n<!ELEMENT age (#PCDATA)>\n<!ELEMENT city (#PCDATA)>\n<!ELEMENT phone (#PCDATA)>";
        private readonly string _databasePath;
        private string  _xsdFilePath = null;
         
        public void SetXsdFilePath(string filepath) => _xsdFilePath = filepath;

        public Database(string databasePath)
        {
            this._databasePath = databasePath; 
            if (File.Exists(databasePath) == false)
            {
                InitializeDatabase();
            }
        }

        private void InitializeDatabase()
        { 
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            XmlDocumentType doctype;
            doctype = doc.CreateDocumentType("people", null, null, INNER_DTD);
            doc.AppendChild(doctype);
            XmlElement peopleElement = doc.CreateElement(("people")); 
            doc.AppendChild(peopleElement); 
            doc.Save(_databasePath);
        }

        public void Add(Person person)
        {
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fileStream = new FileStream(_databasePath, FileMode.Open);
            xmlDocument.Load(fileStream);
            XmlElement personElement = xmlDocument.CreateElement("person");

            personElement.AppendChild(CreateElement("name", person.Name, xmlDocument));
            personElement.AppendChild(CreateElement("surname", person.Surname, xmlDocument));
            personElement.AppendChild(CreateElement("age", person.Age.ToString(), xmlDocument));
            personElement.AppendChild(CreateElement("city", person.City, xmlDocument));
            personElement.AppendChild(CreateElement("phone", person.Phone, xmlDocument));

            xmlDocument.DocumentElement.AppendChild(personElement);
            fileStream.Close();
            xmlDocument.Save(_databasePath);
        }

        private XmlElement CreateElement(string elementName, string elementValue, XmlDocument xmlDocument )
        {
            XmlElement element = xmlDocument.CreateElement(elementName);
            XmlText text = xmlDocument.CreateTextNode(elementValue);
            element.AppendChild(text); 
            return element;
        }

        public Person FindByPhone(string phoneNumber)//TODO zmienic na kazde pole
        {
            Person person = new Person();
            XmlDocument xdoc = new XmlDocument();
            FileStream rfile = new FileStream(_databasePath, FileMode.Open);
            xdoc.Load(rfile);
            XmlNodeList list = xdoc.GetElementsByTagName("person");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement cl = (XmlElement)xdoc.GetElementsByTagName("phone")[i];
                if (phoneNumber.Equals(cl.InnerText))
                {
                    XmlElement nameElement = (XmlElement)xdoc.GetElementsByTagName("name")[i];
                    XmlElement surnameElement = (XmlElement)xdoc.GetElementsByTagName("surname")[i];
                    XmlElement ageElement = (XmlElement)xdoc.GetElementsByTagName("age")[i];
                    XmlElement cityElement = (XmlElement)xdoc.GetElementsByTagName("city")[i];
                    XmlElement phoneElement = (XmlElement)xdoc.GetElementsByTagName("phone")[i];

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

        public string ValidateWithDtd( )
        {
            return Validate(ValidationType.DTD);
        }

        public string ValidateWithXsd()
        {
            if (string.IsNullOrEmpty(_xsdFilePath) || !File.Exists(_xsdFilePath))
            {
                return "Nie załadowano pliku XML Schema";
            }
            return Validate(ValidationType.Schema);
        }

        private string Validate(ValidationType validationType)
        {
            StringBuilder xmlValMsg = new StringBuilder();

            XmlTextReader reader = new XmlTextReader(_databasePath);
            XmlValidatingReader validator = new XmlValidatingReader(reader);
            validator.ValidationType = validationType;
            if (validationType == ValidationType.Schema)
            { 
                 validator.Schemas.Add(null, _xsdFilePath);
            } 
            validator.ValidationEventHandler += new ValidationEventHandler(delegate(object sender, ValidationEventArgs args)
            {
                xmlValMsg.AppendLine(args.Message);
            });
            while (validator.Read()) ;
            string result = xmlValMsg.ToString();
            if (string.IsNullOrEmpty(result))
            {
                result = "Plik XML jest poprawny z "+validationType ;
            }
            return result;
        }

        public XmlElement GetRootElement()
        {
            XmlDocument xdoc = new XmlDocument(); 
            xdoc.Load(_databasePath); 
            return xdoc.DocumentElement;
        }
    }
}