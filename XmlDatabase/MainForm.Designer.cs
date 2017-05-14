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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openXmlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openXmlSchemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DtdValidationButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.SchemaValidationButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.deletePerson = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-1, 27);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(179, 199);
            this.treeView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openXmlToolStripMenuItem,
            this.openXmlSchemaToolStripMenuItem,
            this.openDTDToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openXmlToolStripMenuItem
            // 
            this.openXmlToolStripMenuItem.Name = "openXmlToolStripMenuItem";
            this.openXmlToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openXmlToolStripMenuItem.Text = "Open xml";
            // 
            // openXmlSchemaToolStripMenuItem
            // 
            this.openXmlSchemaToolStripMenuItem.Name = "openXmlSchemaToolStripMenuItem";
            this.openXmlSchemaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openXmlSchemaToolStripMenuItem.Text = "Open xmlSchema";
            // 
            // openDTDToolStripMenuItem
            // 
            this.openDTDToolStripMenuItem.Name = "openDTDToolStripMenuItem";
            this.openDTDToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openDTDToolStripMenuItem.Text = "Open DTD";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openXmlToolStripMenuItem1,
            this.openXmlSchemaToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openXmlToolStripMenuItem1
            // 
            this.openXmlToolStripMenuItem1.Name = "openXmlToolStripMenuItem1";
            this.openXmlToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.openXmlToolStripMenuItem1.Text = "Open XML...";
            this.openXmlToolStripMenuItem1.Click += new System.EventHandler(this.openXmlToolStripMenuItem1_Click);
            // 
            // openXmlSchemaToolStripMenuItem1
            // 
            this.openXmlSchemaToolStripMenuItem1.Name = "openXmlSchemaToolStripMenuItem1";
            this.openXmlSchemaToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.openXmlSchemaToolStripMenuItem1.Text = "Open XmlSchema...";
            this.openXmlSchemaToolStripMenuItem1.Click += new System.EventHandler(this.openXmlSchemaToolStripMenuItem1_Click);
            // 
            // DtdValidationButton
            // 
            this.DtdValidationButton.Location = new System.Drawing.Point(184, 27);
            this.DtdValidationButton.Name = "DtdValidationButton";
            this.DtdValidationButton.Size = new System.Drawing.Size(116, 27);
            this.DtdValidationButton.TabIndex = 6;
            this.DtdValidationButton.Text = "Sprawdź DTD";
            this.DtdValidationButton.UseVisualStyleBackColor = true;
            this.DtdValidationButton.Click += new System.EventHandler(this.DtdValidationButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.Location = new System.Drawing.Point(12, 239);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(267, 96);
            this.mainLabel.TabIndex = 7;
            this.mainLabel.Text = " ";
            // 
            // SchemaValidationButton
            // 
            this.SchemaValidationButton.Location = new System.Drawing.Point(184, 60);
            this.SchemaValidationButton.Name = "SchemaValidationButton";
            this.SchemaValidationButton.Size = new System.Drawing.Size(116, 27);
            this.SchemaValidationButton.TabIndex = 8;
            this.SchemaValidationButton.Text = "Sprawdź Schema";
            this.SchemaValidationButton.UseVisualStyleBackColor = true;
            this.SchemaValidationButton.Click += new System.EventHandler(this.SchemaValidationButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(184, 93);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(116, 27);
            this.addPersonButton.TabIndex = 9;
            this.addPersonButton.Text = "Dodaj osobę";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // deletePerson
            // 
            this.deletePerson.Location = new System.Drawing.Point(184, 126);
            this.deletePerson.Name = "deletePerson";
            this.deletePerson.Size = new System.Drawing.Size(116, 27);
            this.deletePerson.TabIndex = 10;
            this.deletePerson.Text = "Usuń osobę";
            this.deletePerson.UseVisualStyleBackColor = true;
            this.deletePerson.Click += new System.EventHandler(this.deletePerson_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 338);
            this.Controls.Add(this.deletePerson);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.SchemaValidationButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.DtdValidationButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openXmlSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDTDToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openXmlToolStripMenuItem1;
        private System.Windows.Forms.Button DtdValidationButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.ToolStripMenuItem openXmlSchemaToolStripMenuItem1;
        private System.Windows.Forms.Button SchemaValidationButton;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button deletePerson;
    }
}

