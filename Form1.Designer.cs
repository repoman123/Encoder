namespace Encoder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openfile2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.statuslabel = new System.Windows.Forms.Label();
            this.progresslabel2 = new System.Windows.Forms.Label();
            this.progressupdater = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fontbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCustomEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useDefaultNumberEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useDefaultByteEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openCustomEncodingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomOrEditEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openCustomEncodingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrEditEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.FileName = "openfile";
            this.openfile.Filter = "Encoded files |*.enc|All files|*.*";
            // 
            // savefile
            // 
            this.savefile.Filter = "Encoded files |*.enc|All files|*.*";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(360, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(165, 173);
            this.listBox1.TabIndex = 6;
            // 
            // openfile2
            // 
            this.openfile2.Filter = "Encoding files |*.encoding|All files|*.*";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AutoWordSelection = true;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 343);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Errors";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(360, 205);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(165, 147);
            this.listBox2.TabIndex = 10;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar1.Enabled = false;
            this.ProgressBar1.Location = new System.Drawing.Point(349, 394);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(176, 22);
            this.ProgressBar1.Step = 1;
            this.ProgressBar1.TabIndex = 12;
            this.ProgressBar1.Visible = false;
            // 
            // statuslabel
            // 
            this.statuslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statuslabel.AutoSize = true;
            this.statuslabel.Location = new System.Drawing.Point(12, 397);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(0, 13);
            this.statuslabel.TabIndex = 13;
            // 
            // progresslabel2
            // 
            this.progresslabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progresslabel2.AutoSize = true;
            this.progresslabel2.Location = new System.Drawing.Point(198, 397);
            this.progresslabel2.Name = "progresslabel2";
            this.progresslabel2.Size = new System.Drawing.Size(0, 13);
            this.progresslabel2.TabIndex = 14;
            // 
            // progressupdater
            // 
            this.progressupdater.Tick += new System.EventHandler(this.progressupdater_Tick);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            this.fontDialog1.ShowHelp = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(220, 370);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Font";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Size";
            // 
            // fontbox
            // 
            this.fontbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fontbox.Location = new System.Drawing.Point(46, 370);
            this.fontbox.Name = "fontbox";
            this.fontbox.Size = new System.Drawing.Size(135, 20);
            this.fontbox.TabIndex = 18;
            this.fontbox.Click += new System.EventHandler(this.fontbox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.encodingToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openFileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCustomEncodingToolStripMenuItem,
            this.createCustomEncodingToolStripMenuItem,
            this.useDefaultNumberEncodingToolStripMenuItem,
            this.useDefaultByteEncodingToolStripMenuItem});
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.encodingToolStripMenuItem.Text = "Encoding";
            // 
            // openCustomEncodingToolStripMenuItem
            // 
            this.openCustomEncodingToolStripMenuItem.Name = "openCustomEncodingToolStripMenuItem";
            this.openCustomEncodingToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.openCustomEncodingToolStripMenuItem.Text = "Open Custom Encoding";
            // 
            // createCustomEncodingToolStripMenuItem
            // 
            this.createCustomEncodingToolStripMenuItem.Name = "createCustomEncodingToolStripMenuItem";
            this.createCustomEncodingToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.createCustomEncodingToolStripMenuItem.Text = "Create Custom Or Edit Encoding";
            // 
            // useDefaultNumberEncodingToolStripMenuItem
            // 
            this.useDefaultNumberEncodingToolStripMenuItem.Name = "useDefaultNumberEncodingToolStripMenuItem";
            this.useDefaultNumberEncodingToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.useDefaultNumberEncodingToolStripMenuItem.Text = "Use Default Number Encoding";
            // 
            // useDefaultByteEncodingToolStripMenuItem
            // 
            this.useDefaultByteEncodingToolStripMenuItem.CheckOnClick = true;
            this.useDefaultByteEncodingToolStripMenuItem.Name = "useDefaultByteEncodingToolStripMenuItem";
            this.useDefaultByteEncodingToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.useDefaultByteEncodingToolStripMenuItem.Text = "Use Default Byte Encoding";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // encodingToolStripMenuItem1
            // 
            this.encodingToolStripMenuItem1.Name = "encodingToolStripMenuItem1";
            this.encodingToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.encodingToolStripMenuItem1.Text = "Encoding";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // openCustomEncodingToolStripMenuItem1
            // 
            this.openCustomEncodingToolStripMenuItem1.Name = "openCustomEncodingToolStripMenuItem1";
            this.openCustomEncodingToolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.openCustomEncodingToolStripMenuItem1.Text = "Open Custom Encoding";
            // 
            // createCustomOrEditEncodingToolStripMenuItem
            // 
            this.createCustomOrEditEncodingToolStripMenuItem.Name = "createCustomOrEditEncodingToolStripMenuItem";
            this.createCustomOrEditEncodingToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.createCustomOrEditEncodingToolStripMenuItem.Text = "Create Custom or Edit Encoding ";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem2,
            this.saveToolStripMenuItem2});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem2
            // 
            this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            this.openToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.openToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem2.Text = "Open";
            this.openToolStripMenuItem2.Click += new System.EventHandler(this.openToolStripMenuItem2_Click);
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem2.Text = "Save";
            this.saveToolStripMenuItem2.Click += new System.EventHandler(this.saveToolStripMenuItem2_Click);
            // 
            // encodingToolStripMenuItem2
            // 
            this.encodingToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCustomEncodingToolStripMenuItem2,
            this.createOrEditEncodingToolStripMenuItem});
            this.encodingToolStripMenuItem2.Name = "encodingToolStripMenuItem2";
            this.encodingToolStripMenuItem2.Size = new System.Drawing.Size(69, 20);
            this.encodingToolStripMenuItem2.Text = "Encoding";
            // 
            // openCustomEncodingToolStripMenuItem2
            // 
            this.openCustomEncodingToolStripMenuItem2.Name = "openCustomEncodingToolStripMenuItem2";
            this.openCustomEncodingToolStripMenuItem2.Size = new System.Drawing.Size(216, 22);
            this.openCustomEncodingToolStripMenuItem2.Text = "Open Custom Encoding";
            this.openCustomEncodingToolStripMenuItem2.Click += new System.EventHandler(this.openCustomEncodingToolStripMenuItem2_Click);
            // 
            // createOrEditEncodingToolStripMenuItem
            // 
            this.createOrEditEncodingToolStripMenuItem.Name = "createOrEditEncodingToolStripMenuItem";
            this.createOrEditEncodingToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.createOrEditEncodingToolStripMenuItem.Text = "Create or Edit An Encoding";
            this.createOrEditEncodingToolStripMenuItem.Click += new System.EventHandler(this.createOrEditEncodingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fontbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.progresslabel2);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(548, 400);
            this.Name = "Form1";
            this.Text = "Encoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openfile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label progresslabel2;
        private System.Windows.Forms.Timer progressupdater;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fontbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCustomEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useDefaultNumberEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useDefaultByteEncodingToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openCustomEncodingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createCustomOrEditEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openCustomEncodingToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createOrEditEncodingToolStripMenuItem;
    }
}

