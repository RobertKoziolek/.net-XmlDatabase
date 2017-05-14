using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlDatabase
{
    public partial class DeletePersonForm : Form
    {
        private MainForm _parentForm;

        public DeletePersonForm(MainForm parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
        }
 
        private bool CheckFields()
        {
            var list = new List<TextBox> { nameBox, surnameBox };
            foreach (var box in list)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    MessageBox.Show("Wymagane pola nie sa wypełnione");
                    return false;
                }
            };
            return true;
        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                Person person = new Person();
                person.Name = nameBox.Text;
                person.Surname = surnameBox.Text;
                _parentForm.Database.Delete(person);
                _parentForm.LoadTreeViewFromDatabase();
                _parentForm.LabelText = "Usunięto " + person.Name + " " + person.Surname + " z bazy";
                this.Close();
            }
        }
    }
}
