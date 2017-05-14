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
    public partial class MainForm : Form
    {
        private XMLDatabase _xmlDatabase;

        public XMLDatabase Database => _xmlDatabase;

        public MainForm()
        {
            InitializeComponent();  
            LoadXmlDatabase("nowa.xml");
            _xmlDatabase.SetXsdFilePath("people.xsd");
        }

        private void LoadXmlDatabase(string filename)
        {
            _xmlDatabase = new XMLDatabase(filename);
            LoadTreeViewFromDatabase(); 
            LabelText = "Załadowano plik " + filename;
        }
         
        public void LoadTreeViewFromDatabase( )
        { 
            treeView1.Nodes.Clear();
            AddTreeViewChildNodes(treeView1.Nodes, _xmlDatabase.GetRootElement());
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
                LoadXmlDatabase(dlg.FileName );
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
                _xmlDatabase.SetXsdFilePath(dlg.FileName);
                LabelText = "Załadowano plik XML Schema";
            }
        }

        private void DtdValidationButton_Click(object sender, EventArgs e)
        { 
            string result = _xmlDatabase.ValidateWithDtd(); 
            LabelText = result;
        }

        private void SchemaValidationButton_Click(object sender, EventArgs e)
        {  
            string result = _xmlDatabase.ValidateWithXsd();
            LabelText = result;
        }


        private string LabelText
        { 
            set { if (!string.IsNullOrEmpty(value)) mainLabel.Text = value; }
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            AddPersonForm form = new AddPersonForm(this);
            form.Show();
        }
    }
}
