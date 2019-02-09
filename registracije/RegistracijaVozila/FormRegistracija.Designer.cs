namespace RegistracijaVozila
{
    partial class FormRegistracija
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
            this.groupBoxPrijava = new System.Windows.Forms.GroupBox();
            this.labelKorime = new System.Windows.Forms.Label();
            this.textBoxKorime = new System.Windows.Forms.TextBox();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.groupBoxPrijava.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPrijava
            // 
            this.groupBoxPrijava.Controls.Add(this.buttonPrijava);
            this.groupBoxPrijava.Controls.Add(this.textBoxLozinka);
            this.groupBoxPrijava.Controls.Add(this.labelLozinka);
            this.groupBoxPrijava.Controls.Add(this.textBoxKorime);
            this.groupBoxPrijava.Controls.Add(this.labelKorime);
            this.groupBoxPrijava.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPrijava.Name = "groupBoxPrijava";
            this.groupBoxPrijava.Size = new System.Drawing.Size(603, 65);
            this.groupBoxPrijava.TabIndex = 0;
            this.groupBoxPrijava.TabStop = false;
            this.groupBoxPrijava.Text = "Prijava";
            // 
            // labelKorime
            // 
            this.labelKorime.AutoSize = true;
            this.labelKorime.Location = new System.Drawing.Point(6, 28);
            this.labelKorime.Name = "labelKorime";
            this.labelKorime.Size = new System.Drawing.Size(78, 13);
            this.labelKorime.TabIndex = 0;
            this.labelKorime.Text = "Korisničko ime:";
            // 
            // textBoxKorime
            // 
            this.textBoxKorime.Location = new System.Drawing.Point(90, 25);
            this.textBoxKorime.Name = "textBoxKorime";
            this.textBoxKorime.Size = new System.Drawing.Size(121, 20);
            this.textBoxKorime.TabIndex = 1;
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(258, 28);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(47, 13);
            this.labelLozinka.TabIndex = 2;
            this.labelLozinka.Text = "Lozinka:";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(311, 25);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.PasswordChar = '*';
            this.textBoxLozinka.Size = new System.Drawing.Size(121, 20);
            this.textBoxLozinka.TabIndex = 3;
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(471, 23);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(110, 23);
            this.buttonPrijava.TabIndex = 4;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // FormRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.groupBoxPrijava);
            this.Name = "FormRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI - Registracija vozila";
            this.groupBoxPrijava.ResumeLayout(false);
            this.groupBoxPrijava.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrijava;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.TextBox textBoxKorime;
        private System.Windows.Forms.Label labelKorime;
    }
}

