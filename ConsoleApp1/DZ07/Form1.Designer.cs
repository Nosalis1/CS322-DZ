namespace DZ07
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
            dataGridView1 = new DataGridView();
            buttonRefresh = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonCreate = new Button();
            textBoxIme = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxGodinaRodjenja = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 98);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(563, 451);
            dataGridView1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(581, 257);
            buttonRefresh.Margin = new Padding(3, 4, 3, 4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(207, 29);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Osvezi";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(581, 202);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(207, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Obrisi";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(581, 147);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(207, 29);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Azuriraj";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click_1;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(581, 98);
            buttonCreate.Margin = new Padding(3, 4, 3, 4);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(207, 29);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "Kreiraj";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click_1;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(196, 42);
            textBoxIme.Margin = new Padding(3, 4, 3, 4);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(133, 27);
            textBoxIme.TabIndex = 5;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(335, 42);
            textBoxPrezime.Margin = new Padding(3, 4, 3, 4);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(133, 27);
            textBoxPrezime.TabIndex = 6;
            // 
            // textBoxGodinaRodjenja
            // 
            textBoxGodinaRodjenja.Location = new Point(474, 42);
            textBoxGodinaRodjenja.Margin = new Padding(3, 4, 3, 4);
            textBoxGodinaRodjenja.Name = "textBoxGodinaRodjenja";
            textBoxGodinaRodjenja.Size = new Size(133, 27);
            textBoxGodinaRodjenja.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 18);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 8;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 18);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 9;
            label2.Text = "Prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 18);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 10;
            label3.Text = "Godina rodjenja";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxGodinaRodjenja);
            Controls.Add(textBoxPrezime);
            Controls.Add(textBoxIme);
            Controls.Add(buttonCreate);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxGodinaRodjenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
