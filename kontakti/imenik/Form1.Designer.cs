namespace imenik
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
            this.labelKontakti = new System.Windows.Forms.Label();
            this.listBoxKontakti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTrazi = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.labelGrupa = new System.Windows.Forms.Label();
            this.comboBoxGrupa = new System.Windows.Forms.ComboBox();
            this.grupaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKontakti
            // 
            this.labelKontakti.AutoSize = true;
            this.labelKontakti.Location = new System.Drawing.Point(12, 9);
            this.labelKontakti.Name = "labelKontakti";
            this.labelKontakti.Size = new System.Drawing.Size(49, 13);
            this.labelKontakti.TabIndex = 0;
            this.labelKontakti.Text = "Kontakti:";
            // 
            // listBoxKontakti
            // 
            this.listBoxKontakti.FormattingEnabled = true;
            this.listBoxKontakti.Location = new System.Drawing.Point(12, 25);
            this.listBoxKontakti.Name = "listBoxKontakti";
            this.listBoxKontakti.Size = new System.Drawing.Size(166, 173);
            this.listBoxKontakti.TabIndex = 1;
            this.listBoxKontakti.SelectedIndexChanged += new System.EventHandler(this.listBoxKontakti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Traži:";
            // 
            // textBoxTrazi
            // 
            this.textBoxTrazi.Location = new System.Drawing.Point(53, 212);
            this.textBoxTrazi.Name = "textBoxTrazi";
            this.textBoxTrazi.Size = new System.Drawing.Size(125, 20);
            this.textBoxTrazi.TabIndex = 3;
            this.textBoxTrazi.TextChanged += new System.EventHandler(this.textBoxTrazi_TextChanged);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(204, 25);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(27, 13);
            this.labelIme.TabIndex = 4;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(204, 54);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(47, 13);
            this.labelPrezime.TabIndex = 5;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(204, 83);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(204, 113);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(46, 13);
            this.labelTelefon.TabIndex = 7;
            this.labelTelefon.Text = "Telefon:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(275, 22);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(123, 20);
            this.textBoxIme.TabIndex = 8;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(275, 51);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(123, 20);
            this.textBoxPrezime.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(275, 80);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(123, 20);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(275, 110);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(123, 20);
            this.textBoxTelefon.TabIndex = 11;
            // 
            // labelGrupa
            // 
            this.labelGrupa.AutoSize = true;
            this.labelGrupa.Location = new System.Drawing.Point(204, 172);
            this.labelGrupa.Name = "labelGrupa";
            this.labelGrupa.Size = new System.Drawing.Size(39, 13);
            this.labelGrupa.TabIndex = 12;
            this.labelGrupa.Text = "Grupa:";
            // 
            // comboBoxGrupa
            // 
            this.comboBoxGrupa.DataSource = this.grupaBindingSource;
            this.comboBoxGrupa.FormattingEnabled = true;
            this.comboBoxGrupa.Location = new System.Drawing.Point(275, 169);
            this.comboBoxGrupa.Name = "comboBoxGrupa";
            this.comboBoxGrupa.Size = new System.Drawing.Size(123, 21);
            this.comboBoxGrupa.TabIndex = 13;
            // 
            // grupaBindingSource
            // 
            this.grupaBindingSource.DataSource = typeof(imenik.Grupa);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(207, 210);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 14;
            this.buttonDodaj.Text = "Dodaj novi";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(323, 210);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremi.TabIndex = 15;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 255);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.comboBoxGrupa);
            this.Controls.Add(this.labelGrupa);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.textBoxTrazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxKontakti);
            this.Controls.Add(this.labelKontakti);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KONTAKTI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKontakti;
        private System.Windows.Forms.ListBox listBoxKontakti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTrazi;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label labelGrupa;
        private System.Windows.Forms.ComboBox comboBoxGrupa;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.BindingSource grupaBindingSource;
    }
}

