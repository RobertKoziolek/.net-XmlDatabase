using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlDatabase
{
    public partial class Form1 : Form
    {
        private Database database;

        public Form1()
        {
            InitializeComponent(); 
//            Person person = new Person();
//            person.Name = "dsa";
//            person.Surname = "dsa";
//            person.Age = 9;
//            person.City = "dsa";
//            person.Phone = "dsa"; 
//            database.Add(person); 
            LoadTreeViewFromXmlFile("nowa.xml");
            database.SetXsdFilePath("people.xsd");
        }
         
        private void LoadTreeViewFromXmlFile(string filename  )
        { 
            database = new Database(filename);
            treeView1.Nodes.Clear();
            AddTreeViewChildNodes(treeView1.Nodes, database.GetRootElement());
            mainLabel.Text = "Załadowano plik "+filename;
        }
        private void AddTreeViewChildNodes(TreeNodeCollection parent_nodes, XmlNode xml_node)
        {
            foreach (XmlNode child_node in xml_node.ChildNodes)
            {
                var isTextNode = child_node.NodeType == XmlNodeType.Text;
                var treeNodeName = isTextNode ? child_node.Value : child_node.Name;
                TreeNode newNode = parent_nodes.Add(treeNodeName); 
                AddTreeViewChildNodes(newNode.Nodes, child_node); 
                if (newNode.Nodes.Count == 0) newNode.EnsureVisible();
            }
        } 


        private void openXmlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open XML Document";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            dlg.FileName = Application.StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadTreeViewFromXmlFile(dlg.FileName );
            }
        }  
        private void openXmlSchemaToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open XML Schema Document";
            dlg.Filter = "XML Schema Files (*.xsd)|*.xsd";
            dlg.FileName = Application.StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database.SetXsdFilePath(dlg.FileName);
                mainLabel.Text = "Załadowano plik XML Schema";
            }
        }

        private void validationButton_Click(object sender, EventArgs e)
        {
            if (DTDRadio.Checked)
            {
                string result = database.ValidateWithDtd();
                if (!string.IsNullOrEmpty(result))
                    mainLabel.Text = result;
            }else if (XMLRadio.Checked)
            {
                string result = database.ValidateWithXsd();
                if (!string.IsNullOrEmpty(result))
                    mainLabel.Text = result;
            }
        }
    }
}
