namespace XmlDatabase
{
    partial class Form1
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

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
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
            this.openDTDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-1, 27);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(179, 234);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openXmlToolStripMenuItem1,
            this.openXmlSchemaToolStripMenuItem1,
            this.openDTDToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openXmlToolStripMenuItem1
            // 
            this.openXmlToolStripMenuItem1.Name = "openXmlToolStripMenuItem1";
            this.openXmlToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.openXmlToolStripMenuItem1.Text = "Open xml...";
            this.openXmlToolStripMenuItem1.Click += new System.EventHandler(this.openXmlToolStripMenuItem1_Click);
            // 
            // openXmlSchemaToolStripMenuItem1
            // 
            this.openXmlSchemaToolStripMenuItem1.Name = "openXmlSchemaToolStripMenuItem1";
            this.openXmlSchemaToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.openXmlSchemaToolStripMenuItem1.Text = "Open XmlSchema...";
            this.openXmlSchemaToolStripMenuItem1.Click += new System.EventHandler(this.openXmlSchemaToolStripMenuItem1_Click);
            // 
            // openDTDToolStripMenuItem1
            // 
            this.openDTDToolStripMenuItem1.Name = "openDTDToolStripMenuItem1";
            this.openDTDToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.openDTDToolStripMenuItem1.Text = "Open DTD...";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(184, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No validation";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "DTD";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(184, 73);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "XmlSchema";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1"; 
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
        private System.Windows.Forms.ToolStripMenuItem openXmlSchemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openDTDToolStripMenuItem1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

