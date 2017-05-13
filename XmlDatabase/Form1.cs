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
        public Form1()
        {
            InitializeComponent(); 
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void LoadTreeViewFromXmlFile(string filename, TreeView trv)
        { 
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load(filename); 
            trv.Nodes.Clear();
            AddTreeViewChildNodes(trv.Nodes, xml_doc.DocumentElement);
        }
        private void AddTreeViewChildNodes(
    TreeNodeCollection parent_nodes, XmlNode xml_node)
        {
            foreach (XmlNode child_node in xml_node.ChildNodes)
            {
                var isTextNode = child_node.NodeType == XmlNodeType.Text;
                var treeNodeName = isTextNode ? child_node.Value : child_node.Name;
                TreeNode new_node = parent_nodes.Add(treeNodeName); 
                AddTreeViewChildNodes(new_node.Nodes, child_node); 
                if (new_node.Nodes.Count == 0) new_node.EnsureVisible();
            }
        } 

        private void openXmlSchemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openXmlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open XML Document";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            dlg.FileName = Application.StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadTreeViewFromXmlFile(dlg.FileName, treeView1);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
