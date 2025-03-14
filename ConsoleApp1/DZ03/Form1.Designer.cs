namespace DZ03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbPrezime = new TextBox();
            tbAdresa = new TextBox();
            tbIme = new TextBox();
            btnOpenFile = new Button();
            chkBold = new CheckBox();
            rbtnItalic = new RadioButton();
            listBoxData = new ListBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            lblExample = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(674, 137);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 20;
            button1.Text = "Unesi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 107);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 19;
            label3.Text = "Adresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 75);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 18;
            label2.Text = "Prezime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 17;
            label1.Text = "Ime";
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(426, 72);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(362, 27);
            tbPrezime.TabIndex = 16;
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(426, 104);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(362, 27);
            tbAdresa.TabIndex = 15;
            // 
            // tbIme
            // 
            tbIme.Location = new Point(426, 39);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(362, 27);
            tbIme.TabIndex = 14;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(12, 203);
            btnOpenFile.Margin = new Padding(3, 4, 3, 4);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(109, 31);
            btnOpenFile.TabIndex = 21;
            btnOpenFile.Text = "Open Image";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Location = new Point(448, 147);
            chkBold.Margin = new Padding(3, 4, 3, 4);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(93, 24);
            chkBold.TabIndex = 22;
            chkBold.Text = "Bold Text";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.Click += ApplyFormatting;
            // 
            // rbtnItalic
            // 
            rbtnItalic.AutoSize = true;
            rbtnItalic.Location = new Point(556, 147);
            rbtnItalic.Margin = new Padding(3, 4, 3, 4);
            rbtnItalic.Name = "rbtnItalic";
            rbtnItalic.Size = new Size(93, 24);
            rbtnItalic.TabIndex = 23;
            rbtnItalic.TabStop = true;
            rbtnItalic.Text = "Italic Text";
            rbtnItalic.UseVisualStyleBackColor = true;
            rbtnItalic.Click += ApplyFormatting;
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.Location = new Point(12, 254);
            listBoxData.Margin = new Padding(3, 4, 3, 4);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(776, 184);
            listBoxData.TabIndex = 24;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 34);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 161);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // lblExample
            // 
            lblExample.AutoSize = true;
            lblExample.Location = new Point(494, 175);
            lblExample.Name = "lblExample";
            lblExample.Size = new Size(109, 20);
            lblExample.TabIndex = 27;
            lblExample.Text = "Formatted Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(lblExample);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxData);
            Controls.Add(rbtnItalic);
            Controls.Add(chkBold);
            Controls.Add(btnOpenFile);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPrezime);
            Controls.Add(tbAdresa);
            Controls.Add(tbIme);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbPrezime;
        private TextBox tbAdresa;
        private TextBox tbIme;
        private Button btnOpenFile;
        private CheckBox chkBold;
        private RadioButton rbtnItalic;
        private ListBox listBoxData;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private Label lblExample;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
