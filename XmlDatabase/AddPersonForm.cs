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
    public partial class AddPersonForm : Form
    {
        private MainForm _parentForm;

        public AddPersonForm(MainForm parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
        } 

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                Person person = new Person();
                person.Name = nameBox.Text;
                person.Surname = surnameBox.Text;
                person.Age = Int32.Parse(ageNumeric.Text);
                person.City = cityBox.Text;
                person.Phone = phoneBox.Text; 
                _parentForm.Database.Add(person);
                _parentForm.LoadTreeViewFromDatabase();
                _parentForm.LabelText = "Dodano " + person.Name + " " + person.Surname + " do bazy";
                this.Close();
            }
        }

        private bool CheckFields()
        {
            var list = new List<TextBox> {nameBox, surnameBox, cityBox}; 
            foreach(var box in list) {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    MessageBox.Show("Wymagane pola nie sa wypełnione");
                    return false;
                }
            };
            return true;
        } 
    }
}
