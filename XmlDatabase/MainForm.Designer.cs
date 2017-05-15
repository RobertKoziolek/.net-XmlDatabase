namespace XmlDatabase
{
    partial class MainForm
    { 
        private System.ComponentModel.IContainer components = null;
         
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows
         
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openXmlSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDTDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DtdValidationButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.SchemaValidationButton = new System.Windows.Forms.Button();
            this.openXsdFileButton = new System.Windows.Forms.Button();
            this.openXmlButton = new System.Windows.Forms.Button();
            this.deletePerson = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(179, 192);
            this.treeView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openXmlToolStripMenuItem
            // 
            this.openXmlToolStripMenuItem.Name = "openXmlToolStripMenuItem";
            this.openXmlToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openXmlSchemaToolStripMenuItem
            // 
            this.openXmlSchemaToolStripMenuItem.Name = "openXmlSchemaToolStripMenuItem";
            this.openXmlSchemaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openDTDToolStripMenuItem
            // 
            this.openDTDToolStripMenuItem.Name = "openDTDToolStripMenuItem";
            this.openDTDToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // DtdValidationButton
            // 
            this.DtdValidationButton.Location = new System.Drawing.Point(197, 144);
            this.DtdValidationButton.Name = "DtdValidationButton";
            this.DtdValidationButton.Size = new System.Drawing.Size(116, 27);
            this.DtdValidationButton.TabIndex = 6;
            this.DtdValidationButton.Text = "Sprawdź DTD";
            this.DtdValidationButton.UseVisualStyleBackColor = true;
            this.DtdValidationButton.Click += new System.EventHandler(this.DtdValidationButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.Location = new System.Drawing.Point(12, 207);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(301, 84);
            this.mainLabel.TabIndex = 7;
            this.mainLabel.Text = " ";
            // 
            // SchemaValidationButton
            // 
            this.SchemaValidationButton.Location = new System.Drawing.Point(197, 177);
            this.SchemaValidationButton.Name = "SchemaValidationButton";
            this.SchemaValidationButton.Size = new System.Drawing.Size(116, 27);
            this.SchemaValidationButton.TabIndex = 8;
            this.SchemaValidationButton.Text = "Sprawdź Schema";
            this.SchemaValidationButton.UseVisualStyleBackColor = true;
            this.SchemaValidationButton.Click += new System.EventHandler(this.SchemaValidationButton_Click);
            // 
            // openXsdFileButton
            // 
            this.openXsdFileButton.Location = new System.Drawing.Point(197, 45);
            this.openXsdFileButton.Name = "openXsdFileButton";
            this.openXsdFileButton.Size = new System.Drawing.Size(116, 27);
            this.openXsdFileButton.TabIndex = 12;
            this.openXsdFileButton.Text = "Otwórz Schema..";
            this.openXsdFileButton.UseVisualStyleBackColor = true;
            this.openXsdFileButton.Click += new System.EventHandler(this.openXsdFileButton_Click);
            // 
            // openXmlButton
            // 
            this.openXmlButton.Location = new System.Drawing.Point(197, 12);
            this.openXmlButton.Name = "openXmlButton";
            this.openXmlButton.Size = new System.Drawing.Size(116, 27);
            this.openXmlButton.TabIndex = 11;
            this.openXmlButton.Text = "Otwórz XML..";
            this.openXmlButton.UseVisualStyleBackColor = true;
            this.openXmlButton.Click += new System.EventHandler(this.openXmlButton_Click);
            // 
            // deletePerson
            // 
            this.deletePerson.Location = new System.Drawing.Point(197, 111);
            this.deletePerson.Name = "deletePerson";
            this.deletePerson.Size = new System.Drawing.Size(116, 27);
            this.deletePerson.TabIndex = 14;
            this.deletePerson.Text = "Usuń osobę";
            this.deletePerson.UseVisualStyleBackColor = true;
            this.deletePerson.Click += new System.EventHandler(this.deletePerson_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(197, 78);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(116, 27);
            this.addPersonButton.TabIndex = 13;
            this.addPersonButton.Text = "Dodaj osobę";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 290);
            this.Controls.Add(this.deletePerson);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.openXsdFileButton);
            this.Controls.Add(this.openXmlButton);
            this.Controls.Add(this.SchemaValidationButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.DtdValidationButton);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openXmlSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDTDToolStripMenuItem;
        private System.Windows.Forms.Button DtdValidationButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button SchemaValidationButton;
        private System.Windows.Forms.Button openXsdFileButton;
        private System.Windows.Forms.Button openXmlButton;
        private System.Windows.Forms.Button deletePerson;
        private System.Windows.Forms.Button addPersonButton;
    }
}

