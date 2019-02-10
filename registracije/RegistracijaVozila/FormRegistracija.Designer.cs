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
            this.components = new System.ComponentModel.Container();
            this.groupBoxPrijava = new System.Windows.Forms.GroupBox();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.textBoxKorime = new System.Windows.Forms.TextBox();
            this.labelKorime = new System.Windows.Forms.Label();
            this.groupBoxDodajVozilo = new System.Windows.Forms.GroupBox();
            this.comboBoxTipGoriva = new System.Windows.Forms.ComboBox();
            this.textBoxCO2 = new System.Windows.Forms.TextBox();
            this.textBoxZapremnina = new System.Windows.Forms.TextBox();
            this.textBoxSnagaVozila = new System.Windows.Forms.TextBox();
            this.textBoxBrojSasije = new System.Windows.Forms.TextBox();
            this.textBoxGodisteVozila = new System.Windows.Forms.TextBox();
            this.textBoxPrezimeVlasnika = new System.Windows.Forms.TextBox();
            this.textBoxImeVlasnika = new System.Windows.Forms.TextBox();
            this.labelCO2 = new System.Windows.Forms.Label();
            this.labelTipGoriva = new System.Windows.Forms.Label();
            this.labelZapremnina = new System.Windows.Forms.Label();
            this.labelSnagaVozila = new System.Windows.Forms.Label();
            this.labelBrojSasije = new System.Windows.Forms.Label();
            this.labelGodisteVozila = new System.Windows.Forms.Label();
            this.labelPrezimeVlasnika = new System.Windows.Forms.Label();
            this.labelImeVlasnika = new System.Windows.Forms.Label();
            this.groupBoxPregledVozila = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrikaziVozila = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObnoviReg = new System.Windows.Forms.Button();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imeVlasnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeVlasnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godisteVozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojSasijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snagaVozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapremninaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipGorivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cO2EmisijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeRegistracijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPrijava.SuspendLayout();
            this.groupBoxDodajVozilo.SuspendLayout();
            this.groupBoxPregledVozila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
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
            this.groupBoxPrijava.Size = new System.Drawing.Size(601, 65);
            this.groupBoxPrijava.TabIndex = 0;
            this.groupBoxPrijava.TabStop = false;
            this.groupBoxPrijava.Text = "Prijava";
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
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(311, 25);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.PasswordChar = '*';
            this.textBoxLozinka.Size = new System.Drawing.Size(121, 20);
            this.textBoxLozinka.TabIndex = 3;
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
            // textBoxKorime
            // 
            this.textBoxKorime.Location = new System.Drawing.Point(90, 25);
            this.textBoxKorime.Name = "textBoxKorime";
            this.textBoxKorime.Size = new System.Drawing.Size(121, 20);
            this.textBoxKorime.TabIndex = 1;
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
            // groupBoxDodajVozilo
            // 
            this.groupBoxDodajVozilo.Controls.Add(this.buttonDodaj);
            this.groupBoxDodajVozilo.Controls.Add(this.comboBoxTipGoriva);
            this.groupBoxDodajVozilo.Controls.Add(this.textBoxCO2);
            this.groupBoxDodajVozilo.Controls.Add(this.textBoxZapremnina);
            this.groupBoxDodajVozilo.Controls.Add(this.textBoxSnagaVozila);
            this.groupBoxDodajVozilo.Controls.Add(this.textBoxBrojSasije);
            this.groupBoxDodajVozilo.Controls.Add(this.textBoxGodisteVozila);
            this.groupBoxDodajVozilo.Controls.Add(this.textBoxPrezimeVlasnika);
            this.groupBoxDodajVozilo.Controls.Add(this.textBoxImeVlasnika);
            this.groupBoxDodajVozilo.Controls.Add(this.labelCO2);
            this.groupBoxDodajVozilo.Controls.Add(this.labelTipGoriva);
            this.groupBoxDodajVozilo.Controls.Add(this.labelZapremnina);
            this.groupBoxDodajVozilo.Controls.Add(this.labelSnagaVozila);
            this.groupBoxDodajVozilo.Controls.Add(this.labelBrojSasije);
            this.groupBoxDodajVozilo.Controls.Add(this.labelGodisteVozila);
            this.groupBoxDodajVozilo.Controls.Add(this.labelPrezimeVlasnika);
            this.groupBoxDodajVozilo.Controls.Add(this.labelImeVlasnika);
            this.groupBoxDodajVozilo.Location = new System.Drawing.Point(12, 83);
            this.groupBoxDodajVozilo.Name = "groupBoxDodajVozilo";
            this.groupBoxDodajVozilo.Size = new System.Drawing.Size(375, 358);
            this.groupBoxDodajVozilo.TabIndex = 1;
            this.groupBoxDodajVozilo.TabStop = false;
            this.groupBoxDodajVozilo.Text = "Dodaj vozilo";
            // 
            // comboBoxTipGoriva
            // 
            this.comboBoxTipGoriva.FormattingEnabled = true;
            this.comboBoxTipGoriva.Location = new System.Drawing.Point(233, 237);
            this.comboBoxTipGoriva.Name = "comboBoxTipGoriva";
            this.comboBoxTipGoriva.Size = new System.Drawing.Size(136, 21);
            this.comboBoxTipGoriva.TabIndex = 15;
            // 
            // textBoxCO2
            // 
            this.textBoxCO2.Location = new System.Drawing.Point(233, 271);
            this.textBoxCO2.Name = "textBoxCO2";
            this.textBoxCO2.Size = new System.Drawing.Size(136, 20);
            this.textBoxCO2.TabIndex = 14;
            // 
            // textBoxZapremnina
            // 
            this.textBoxZapremnina.Location = new System.Drawing.Point(233, 198);
            this.textBoxZapremnina.Name = "textBoxZapremnina";
            this.textBoxZapremnina.Size = new System.Drawing.Size(136, 20);
            this.textBoxZapremnina.TabIndex = 13;
            // 
            // textBoxSnagaVozila
            // 
            this.textBoxSnagaVozila.Location = new System.Drawing.Point(233, 162);
            this.textBoxSnagaVozila.Name = "textBoxSnagaVozila";
            this.textBoxSnagaVozila.Size = new System.Drawing.Size(136, 20);
            this.textBoxSnagaVozila.TabIndex = 12;
            // 
            // textBoxBrojSasije
            // 
            this.textBoxBrojSasije.Location = new System.Drawing.Point(233, 131);
            this.textBoxBrojSasije.Name = "textBoxBrojSasije";
            this.textBoxBrojSasije.Size = new System.Drawing.Size(136, 20);
            this.textBoxBrojSasije.TabIndex = 11;
            // 
            // textBoxGodisteVozila
            // 
            this.textBoxGodisteVozila.Location = new System.Drawing.Point(233, 98);
            this.textBoxGodisteVozila.Name = "textBoxGodisteVozila";
            this.textBoxGodisteVozila.Size = new System.Drawing.Size(136, 20);
            this.textBoxGodisteVozila.TabIndex = 10;
            // 
            // textBoxPrezimeVlasnika
            // 
            this.textBoxPrezimeVlasnika.Location = new System.Drawing.Point(233, 66);
            this.textBoxPrezimeVlasnika.Name = "textBoxPrezimeVlasnika";
            this.textBoxPrezimeVlasnika.Size = new System.Drawing.Size(136, 20);
            this.textBoxPrezimeVlasnika.TabIndex = 9;
            // 
            // textBoxImeVlasnika
            // 
            this.textBoxImeVlasnika.Location = new System.Drawing.Point(233, 33);
            this.textBoxImeVlasnika.Name = "textBoxImeVlasnika";
            this.textBoxImeVlasnika.Size = new System.Drawing.Size(136, 20);
            this.textBoxImeVlasnika.TabIndex = 8;
            // 
            // labelCO2
            // 
            this.labelCO2.AutoSize = true;
            this.labelCO2.Location = new System.Drawing.Point(16, 274);
            this.labelCO2.Name = "labelCO2";
            this.labelCO2.Size = new System.Drawing.Size(248, 13);
            this.labelCO2.TabIndex = 7;
            this.labelCO2.Text = "CO2 (emisije) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            // 
            // labelTipGoriva
            // 
            this.labelTipGoriva.AutoSize = true;
            this.labelTipGoriva.Location = new System.Drawing.Point(16, 240);
            this.labelTipGoriva.Name = "labelTipGoriva";
            this.labelTipGoriva.Size = new System.Drawing.Size(210, 13);
            this.labelTipGoriva.TabIndex = 6;
            this.labelTipGoriva.Text = "Tip goriva . . . . . . . . . . . . . . . . . . . . . . . . . .";
            // 
            // labelZapremnina
            // 
            this.labelZapremnina.AutoSize = true;
            this.labelZapremnina.Location = new System.Drawing.Point(16, 201);
            this.labelZapremnina.Name = "labelZapremnina";
            this.labelZapremnina.Size = new System.Drawing.Size(230, 13);
            this.labelZapremnina.TabIndex = 5;
            this.labelZapremnina.Text = "Zapremnina (ccm) . . . . . . . . . . . . . . . . . . . . . . .";
            // 
            // labelSnagaVozila
            // 
            this.labelSnagaVozila.AutoSize = true;
            this.labelSnagaVozila.Location = new System.Drawing.Point(17, 165);
            this.labelSnagaVozila.Name = "labelSnagaVozila";
            this.labelSnagaVozila.Size = new System.Drawing.Size(232, 13);
            this.labelSnagaVozila.TabIndex = 4;
            this.labelSnagaVozila.Text = "Snaga vozila (kW) . . . . . . . . . . . . . . . . . . . . . . .";
            // 
            // labelBrojSasije
            // 
            this.labelBrojSasije.AutoSize = true;
            this.labelBrojSasije.Location = new System.Drawing.Point(16, 134);
            this.labelBrojSasije.Name = "labelBrojSasije";
            this.labelBrojSasije.Size = new System.Drawing.Size(228, 13);
            this.labelBrojSasije.TabIndex = 3;
            this.labelBrojSasije.Text = "Broj šasije . . . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            // 
            // labelGodisteVozila
            // 
            this.labelGodisteVozila.AutoSize = true;
            this.labelGodisteVozila.Location = new System.Drawing.Point(17, 101);
            this.labelGodisteVozila.Name = "labelGodisteVozila";
            this.labelGodisteVozila.Size = new System.Drawing.Size(229, 13);
            this.labelGodisteVozila.TabIndex = 2;
            this.labelGodisteVozila.Text = "Godište vozila . . . . . . . . . . . . . . . . . . . . . . . . . .";
            // 
            // labelPrezimeVlasnika
            // 
            this.labelPrezimeVlasnika.AutoSize = true;
            this.labelPrezimeVlasnika.Location = new System.Drawing.Point(17, 69);
            this.labelPrezimeVlasnika.Name = "labelPrezimeVlasnika";
            this.labelPrezimeVlasnika.Size = new System.Drawing.Size(227, 13);
            this.labelPrezimeVlasnika.TabIndex = 1;
            this.labelPrezimeVlasnika.Text = "Prezime vlasnika . . . . . . . . . . . . . . . . . . . . . . . ";
            // 
            // labelImeVlasnika
            // 
            this.labelImeVlasnika.AutoSize = true;
            this.labelImeVlasnika.Location = new System.Drawing.Point(19, 36);
            this.labelImeVlasnika.Name = "labelImeVlasnika";
            this.labelImeVlasnika.Size = new System.Drawing.Size(216, 13);
            this.labelImeVlasnika.TabIndex = 0;
            this.labelImeVlasnika.Text = "Ime vlasnika . . . . . . . . . . . . . . . . . . . . . . . . .";
            // 
            // groupBoxPregledVozila
            // 
            this.groupBoxPregledVozila.Controls.Add(this.buttonObnoviReg);
            this.groupBoxPregledVozila.Controls.Add(this.dataGridView1);
            this.groupBoxPregledVozila.Controls.Add(this.comboBoxPrikaziVozila);
            this.groupBoxPregledVozila.Controls.Add(this.label1);
            this.groupBoxPregledVozila.Location = new System.Drawing.Point(393, 83);
            this.groupBoxPregledVozila.Name = "groupBoxPregledVozila";
            this.groupBoxPregledVozila.Size = new System.Drawing.Size(534, 358);
            this.groupBoxPregledVozila.TabIndex = 2;
            this.groupBoxPregledVozila.TabStop = false;
            this.groupBoxPregledVozila.Text = "Pregled vozila";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaži vozila . . . . . . . . . . . . . . . . . . . . .";
            // 
            // comboBoxPrikaziVozila
            // 
            this.comboBoxPrikaziVozila.FormattingEnabled = true;
            this.comboBoxPrikaziVozila.Location = new System.Drawing.Point(206, 33);
            this.comboBoxPrikaziVozila.Name = "comboBoxPrikaziVozila";
            this.comboBoxPrikaziVozila.Size = new System.Drawing.Size(160, 21);
            this.comboBoxPrikaziVozila.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeVlasnikaDataGridViewTextBoxColumn,
            this.prezimeVlasnikaDataGridViewTextBoxColumn,
            this.godisteVozilaDataGridViewTextBoxColumn,
            this.brojSasijeDataGridViewTextBoxColumn,
            this.snagaVozilaDataGridViewTextBoxColumn,
            this.zapremninaDataGridViewTextBoxColumn,
            this.tipGorivaDataGridViewTextBoxColumn,
            this.cO2EmisijeDataGridViewTextBoxColumn,
            this.vrijemeRegistracijeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.voziloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 242);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(233, 329);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(136, 23);
            this.buttonDodaj.TabIndex = 16;
            this.buttonDodaj.Text = "Dodaj u sustav";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObnoviReg
            // 
            this.buttonObnoviReg.Location = new System.Drawing.Point(365, 329);
            this.buttonObnoviReg.Name = "buttonObnoviReg";
            this.buttonObnoviReg.Size = new System.Drawing.Size(163, 23);
            this.buttonObnoviReg.TabIndex = 3;
            this.buttonObnoviReg.Text = "Obnovi registraciju";
            this.buttonObnoviReg.UseVisualStyleBackColor = true;
            this.buttonObnoviReg.Click += new System.EventHandler(this.buttonObnoviReg_Click);
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataSource = typeof(Data.Vozila);
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataSource = typeof(Data.Vozilo);
            // 
            // imeVlasnikaDataGridViewTextBoxColumn
            // 
            this.imeVlasnikaDataGridViewTextBoxColumn.DataPropertyName = "ImeVlasnika";
            this.imeVlasnikaDataGridViewTextBoxColumn.HeaderText = "ImeVlasnika";
            this.imeVlasnikaDataGridViewTextBoxColumn.Name = "imeVlasnikaDataGridViewTextBoxColumn";
            // 
            // prezimeVlasnikaDataGridViewTextBoxColumn
            // 
            this.prezimeVlasnikaDataGridViewTextBoxColumn.DataPropertyName = "PrezimeVlasnika";
            this.prezimeVlasnikaDataGridViewTextBoxColumn.HeaderText = "PrezimeVlasnika";
            this.prezimeVlasnikaDataGridViewTextBoxColumn.Name = "prezimeVlasnikaDataGridViewTextBoxColumn";
            // 
            // godisteVozilaDataGridViewTextBoxColumn
            // 
            this.godisteVozilaDataGridViewTextBoxColumn.DataPropertyName = "GodisteVozila";
            this.godisteVozilaDataGridViewTextBoxColumn.HeaderText = "GodisteVozila";
            this.godisteVozilaDataGridViewTextBoxColumn.Name = "godisteVozilaDataGridViewTextBoxColumn";
            // 
            // brojSasijeDataGridViewTextBoxColumn
            // 
            this.brojSasijeDataGridViewTextBoxColumn.DataPropertyName = "BrojSasije";
            this.brojSasijeDataGridViewTextBoxColumn.HeaderText = "BrojSasije";
            this.brojSasijeDataGridViewTextBoxColumn.Name = "brojSasijeDataGridViewTextBoxColumn";
            // 
            // snagaVozilaDataGridViewTextBoxColumn
            // 
            this.snagaVozilaDataGridViewTextBoxColumn.DataPropertyName = "SnagaVozila";
            this.snagaVozilaDataGridViewTextBoxColumn.HeaderText = "SnagaVozila";
            this.snagaVozilaDataGridViewTextBoxColumn.Name = "snagaVozilaDataGridViewTextBoxColumn";
            // 
            // zapremninaDataGridViewTextBoxColumn
            // 
            this.zapremninaDataGridViewTextBoxColumn.DataPropertyName = "Zapremnina";
            this.zapremninaDataGridViewTextBoxColumn.HeaderText = "Zapremnina";
            this.zapremninaDataGridViewTextBoxColumn.Name = "zapremninaDataGridViewTextBoxColumn";
            // 
            // tipGorivaDataGridViewTextBoxColumn
            // 
            this.tipGorivaDataGridViewTextBoxColumn.DataPropertyName = "TipGoriva";
            this.tipGorivaDataGridViewTextBoxColumn.HeaderText = "TipGoriva";
            this.tipGorivaDataGridViewTextBoxColumn.Name = "tipGorivaDataGridViewTextBoxColumn";
            // 
            // cO2EmisijeDataGridViewTextBoxColumn
            // 
            this.cO2EmisijeDataGridViewTextBoxColumn.DataPropertyName = "CO2Emisije";
            this.cO2EmisijeDataGridViewTextBoxColumn.HeaderText = "CO2Emisije";
            this.cO2EmisijeDataGridViewTextBoxColumn.Name = "cO2EmisijeDataGridViewTextBoxColumn";
            // 
            // vrijemeRegistracijeDataGridViewTextBoxColumn
            // 
            this.vrijemeRegistracijeDataGridViewTextBoxColumn.DataPropertyName = "VrijemeRegistracije";
            this.vrijemeRegistracijeDataGridViewTextBoxColumn.HeaderText = "VrijemeRegistracije";
            this.vrijemeRegistracijeDataGridViewTextBoxColumn.Name = "vrijemeRegistracijeDataGridViewTextBoxColumn";
            // 
            // FormRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 453);
            this.Controls.Add(this.groupBoxPregledVozila);
            this.Controls.Add(this.groupBoxDodajVozilo);
            this.Controls.Add(this.groupBoxPrijava);
            this.Name = "FormRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI - Registracija vozila";
            this.Load += new System.EventHandler(this.FormRegistracija_Load);
            this.groupBoxPrijava.ResumeLayout(false);
            this.groupBoxPrijava.PerformLayout();
            this.groupBoxDodajVozilo.ResumeLayout(false);
            this.groupBoxDodajVozilo.PerformLayout();
            this.groupBoxPregledVozila.ResumeLayout(false);
            this.groupBoxPregledVozila.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrijava;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.TextBox textBoxKorime;
        private System.Windows.Forms.Label labelKorime;
        private System.Windows.Forms.GroupBox groupBoxDodajVozilo;
        private System.Windows.Forms.ComboBox comboBoxTipGoriva;
        private System.Windows.Forms.TextBox textBoxCO2;
        private System.Windows.Forms.TextBox textBoxZapremnina;
        private System.Windows.Forms.TextBox textBoxSnagaVozila;
        private System.Windows.Forms.TextBox textBoxBrojSasije;
        private System.Windows.Forms.TextBox textBoxGodisteVozila;
        private System.Windows.Forms.TextBox textBoxPrezimeVlasnika;
        private System.Windows.Forms.TextBox textBoxImeVlasnika;
        private System.Windows.Forms.Label labelCO2;
        private System.Windows.Forms.Label labelTipGoriva;
        private System.Windows.Forms.Label labelZapremnina;
        private System.Windows.Forms.Label labelSnagaVozila;
        private System.Windows.Forms.Label labelBrojSasije;
        private System.Windows.Forms.Label labelGodisteVozila;
        private System.Windows.Forms.Label labelPrezimeVlasnika;
        private System.Windows.Forms.Label labelImeVlasnika;
        private System.Windows.Forms.GroupBox groupBoxPregledVozila;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObnoviReg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxPrikaziVozila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeVlasnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeVlasnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godisteVozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojSasijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snagaVozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zapremninaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipGorivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cO2EmisijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeRegistracijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource voziloBindingSource;
    }
}

