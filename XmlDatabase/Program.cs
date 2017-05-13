using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlDatabase
{
    static class Program
    { 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Database database = new Database("druga.xml");

            Person person = new Person();
            person.Name = "Adam";
            person.Surname = "Pierwszy";
            person.Age = 33;
            person.City = "ZG";
            person.Phone = "+48 665463807";

            database.Add(person);

            person.Name = "Maciej";
            person.Phone = "+48 667876323";
            person.Age = 24;
            database.Add(person);
        }
    }
}
