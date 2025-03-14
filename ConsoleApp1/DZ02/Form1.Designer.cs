namespace DZ02
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(447, 222);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 13;
            button1.Text = "Unesi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 192);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 12;
            label3.Text = "Adresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 159);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 11;
            label2.Text = "Prezime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 126);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 10;
            label1.Text = "Ime";
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(199, 156);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(362, 27);
            tbPrezime.TabIndex = 9;
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(199, 189);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(362, 27);
            tbAdresa.TabIndex = 8;
            // 
            // tbIme
            // 
            tbIme.Location = new Point(199, 123);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(362, 27);
            tbIme.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPrezime);
            Controls.Add(tbAdresa);
            Controls.Add(tbIme);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbPrezime;
        private TextBox tbAdresa;
        private TextBox tbIme;
    }
}
