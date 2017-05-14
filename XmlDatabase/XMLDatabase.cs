using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace XmlDatabase
{
    public class XMLDatabase
    {
        private const string INNER_DTD = "<!ELEMENT people (person*)>\n<!ELEMENT person (name,surname,age,city,phone)>\n<!ELEMENT name (#PCDATA)>\n<!ELEMENT surname (#PCDATA)>\n<!ELEMENT age (#PCDATA)>\n<!ELEMENT city (#PCDATA)>\n<!ELEMENT phone (#PCDATA)>";
        private readonly string _databasePath;
        private string  _xsdFilePath = null;
         
        public void SetXsdFilePath(string filepath) => _xsdFilePath = filepath;

        public XMLDatabase(string databasePath)
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
            if (!string.IsNullOrWhiteSpace(person.Phone))
            {
                personElement.AppendChild(CreateElement("phone", person.Phone, xmlDocument));
            }

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

        public void Delete(Person person)
        {
            FileStream fileStream = new FileStream(_databasePath, FileMode.Open);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(fileStream);
            XmlNodeList list = xmlDocument.GetElementsByTagName("person");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement nameElement = (XmlElement)xmlDocument.GetElementsByTagName("name")[i];
                XmlElement surnameElement = (XmlElement)xmlDocument.GetElementsByTagName("surname")[i];

                if (person.Name.Equals(nameElement.InnerText) && person.Surname.Equals(surnameElement.InnerText))
                {
                    xmlDocument.DocumentElement.RemoveChild(list[i]);
                }
            }
            fileStream.Close();
            xmlDocument.Save(_databasePath);
        }
        public Person FindBy(string searchField, string searchValue) 
        {
            Person person = new Person();
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fileStream = new FileStream(_databasePath, FileMode.Open);
            xmlDocument.Load(fileStream);
            XmlNodeList list = xmlDocument.GetElementsByTagName("person");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement element = (XmlElement)xmlDocument.GetElementsByTagName(searchField)[i];
                if (searchValue.Equals(element.InnerText))
                {
                    XmlElement nameElement = (XmlElement)xmlDocument.GetElementsByTagName("name")[i];
                    XmlElement surnameElement = (XmlElement)xmlDocument.GetElementsByTagName("surname")[i];
                    XmlElement ageElement = (XmlElement)xmlDocument.GetElementsByTagName("age")[i];
                    XmlElement cityElement = (XmlElement)xmlDocument.GetElementsByTagName("city")[i];
                    XmlElement phoneElement = (XmlElement)xmlDocument.GetElementsByTagName("phone")[i];

                    person.Name = nameElement.InnerText;
                    person.Surname = surnameElement.InnerText;
                    person.Age = Int32.Parse(ageElement.InnerText);
                    person.City = cityElement.InnerText;
                    person.Phone = phoneElement.InnerText;
                    break;
                }
            }
            fileStream.Close();
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
                return "Nie załadowano pliku Schema";
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