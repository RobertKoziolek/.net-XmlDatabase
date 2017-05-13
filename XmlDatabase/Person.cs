namespace XmlDatabase
{
    public class Person
    {
        private string name, surname, city, phone;
        private int age;

        public Person()
        {
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}