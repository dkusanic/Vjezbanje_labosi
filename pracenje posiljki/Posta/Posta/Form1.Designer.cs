namespace Posta
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
            this.dgvPosiljke = new System.Windows.Forms.DataGridView();
            this.dKPosiljkadgvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postaDataSet = new Posta.PostaDataSet();
            this.grbPosiljatelj = new System.Windows.Forms.GroupBox();
            this.txtPosiljatelj = new System.Windows.Forms.TextBox();
            this.grbPrimatelj = new System.Windows.Forms.GroupBox();
            this.txtPrimatelj = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dK_Posiljka_dgvTableAdapter = new Posta.PostaDataSetTableAdapters.DK_Posiljka_dgvTableAdapter();
            this.postaDataSet1 = new Posta.PostaDataSet1();
            this.dKGradoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dK_GradoviTableAdapter = new Posta.PostaDataSet1TableAdapters.DK_GradoviTableAdapter();
            this.postaDataSet2 = new Posta.PostaDataSet2();
            this.dKGradoviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dK_GradoviTableAdapter1 = new Posta.PostaDataSet2TableAdapters.DK_GradoviTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isporucenoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.polazisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.odredisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.primateljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posiljateljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiljke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKPosiljkadgvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaDataSet)).BeginInit();
            this.grbPosiljatelj.SuspendLayout();
            this.grbPrimatelj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKGradoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKGradoviBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosiljke
            // 
            this.dgvPosiljke.AutoGenerateColumns = false;
            this.dgvPosiljke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosiljke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiljke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.isporucenoDataGridViewCheckBoxColumn,
            this.polazisteDataGridViewTextBoxColumn,
            this.odredisteDataGridViewTextBoxColumn,
            this.primateljDataGridViewTextBoxColumn,
            this.posiljateljDataGridViewTextBoxColumn});
            this.dgvPosiljke.DataSource = this.dKPosiljkadgvBindingSource;
            this.dgvPosiljke.Location = new System.Drawing.Point(11, 12);
            this.dgvPosiljke.Name = "dgvPosiljke";
            this.dgvPosiljke.Size = new System.Drawing.Size(491, 158);
            this.dgvPosiljke.TabIndex = 0;
            // 
            // dKPosiljkadgvBindingSource
            // 
            this.dKPosiljkadgvBindingSource.DataMember = "DK_Posiljka_dgv";
            this.dKPosiljkadgvBindingSource.DataSource = this.postaDataSet;
            // 
            // postaDataSet
            // 
            this.postaDataSet.DataSetName = "PostaDataSet";
            this.postaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbPosiljatelj
            // 
            this.grbPosiljatelj.Controls.Add(this.txtPosiljatelj);
            this.grbPosiljatelj.Location = new System.Drawing.Point(12, 176);
            this.grbPosiljatelj.Name = "grbPosiljatelj";
            this.grbPosiljatelj.Size = new System.Drawing.Size(239, 100);
            this.grbPosiljatelj.TabIndex = 1;
            this.grbPosiljatelj.TabStop = false;
            this.grbPosiljatelj.Text = "Pošiljatelj";
            // 
            // txtPosiljatelj
            // 
            this.txtPosiljatelj.Location = new System.Drawing.Point(6, 19);
            this.txtPosiljatelj.Multiline = true;
            this.txtPosiljatelj.Name = "txtPosiljatelj";
            this.txtPosiljatelj.Size = new System.Drawing.Size(227, 75);
            this.txtPosiljatelj.TabIndex = 0;
            // 
            // grbPrimatelj
            // 
            this.grbPrimatelj.Controls.Add(this.txtPrimatelj);
            this.grbPrimatelj.Location = new System.Drawing.Point(257, 176);
            this.grbPrimatelj.Name = "grbPrimatelj";
            this.grbPrimatelj.Size = new System.Drawing.Size(246, 100);
            this.grbPrimatelj.TabIndex = 2;
            this.grbPrimatelj.TabStop = false;
            this.grbPrimatelj.Text = "Primatelj";
            // 
            // txtPrimatelj
            // 
            this.txtPrimatelj.Location = new System.Drawing.Point(6, 19);
            this.txtPrimatelj.Multiline = true;
            this.txtPrimatelj.Name = "txtPrimatelj";
            this.txtPrimatelj.Size = new System.Drawing.Size(227, 75);
            this.txtPrimatelj.TabIndex = 1;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(382, 282);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(121, 23);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi promjene";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // dK_Posiljka_dgvTableAdapter
            // 
            this.dK_Posiljka_dgvTableAdapter.ClearBeforeFill = true;
            // 
            // postaDataSet1
            // 
            this.postaDataSet1.DataSetName = "PostaDataSet1";
            this.postaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dKGradoviBindingSource
            // 
            this.dKGradoviBindingSource.DataMember = "DK_Gradovi";
            this.dKGradoviBindingSource.DataSource = this.postaDataSet1;
            // 
            // dK_GradoviTableAdapter
            // 
            this.dK_GradoviTableAdapter.ClearBeforeFill = true;
            // 
            // postaDataSet2
            // 
            this.postaDataSet2.DataSetName = "PostaDataSet2";
            this.postaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dKGradoviBindingSource1
            // 
            this.dKGradoviBindingSource1.DataMember = "DK_Gradovi";
            this.dKGradoviBindingSource1.DataSource = this.postaDataSet2;
            // 
            // dK_GradoviTableAdapter1
            // 
            this.dK_GradoviTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // isporucenoDataGridViewCheckBoxColumn
            // 
            this.isporucenoDataGridViewCheckBoxColumn.DataPropertyName = "Isporuceno";
            this.isporucenoDataGridViewCheckBoxColumn.HeaderText = "Isporuceno";
            this.isporucenoDataGridViewCheckBoxColumn.Name = "isporucenoDataGridViewCheckBoxColumn";
            // 
            // polazisteDataGridViewTextBoxColumn
            // 
            this.polazisteDataGridViewTextBoxColumn.DataPropertyName = "Polaziste";
            this.polazisteDataGridViewTextBoxColumn.DataSource = this.dKGradoviBindingSource;
            this.polazisteDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.polazisteDataGridViewTextBoxColumn.HeaderText = "Polaziste";
            this.polazisteDataGridViewTextBoxColumn.Name = "polazisteDataGridViewTextBoxColumn";
            this.polazisteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.polazisteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.polazisteDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // odredisteDataGridViewTextBoxColumn
            // 
            this.odredisteDataGridViewTextBoxColumn.DataPropertyName = "Odrediste";
            this.odredisteDataGridViewTextBoxColumn.DataSource = this.dKGradoviBindingSource1;
            this.odredisteDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.odredisteDataGridViewTextBoxColumn.HeaderText = "Odrediste";
            this.odredisteDataGridViewTextBoxColumn.Name = "odredisteDataGridViewTextBoxColumn";
            this.odredisteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.odredisteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.odredisteDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // primateljDataGridViewTextBoxColumn
            // 
            this.primateljDataGridViewTextBoxColumn.DataPropertyName = "Primatelj";
            this.primateljDataGridViewTextBoxColumn.HeaderText = "Primatelj";
            this.primateljDataGridViewTextBoxColumn.Name = "primateljDataGridViewTextBoxColumn";
            this.primateljDataGridViewTextBoxColumn.Visible = false;
            // 
            // posiljateljDataGridViewTextBoxColumn
            // 
            this.posiljateljDataGridViewTextBoxColumn.DataPropertyName = "Posiljatelj";
            this.posiljateljDataGridViewTextBoxColumn.HeaderText = "Posiljatelj";
            this.posiljateljDataGridViewTextBoxColumn.Name = "posiljateljDataGridViewTextBoxColumn";
            this.posiljateljDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 316);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.grbPrimatelj);
            this.Controls.Add(this.grbPosiljatelj);
            this.Controls.Add(this.dgvPosiljke);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaprimanje pošiljke";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiljke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKPosiljkadgvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaDataSet)).EndInit();
            this.grbPosiljatelj.ResumeLayout(false);
            this.grbPosiljatelj.PerformLayout();
            this.grbPrimatelj.ResumeLayout(false);
            this.grbPrimatelj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKGradoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKGradoviBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosiljke;
        private System.Windows.Forms.GroupBox grbPosiljatelj;
        private System.Windows.Forms.TextBox txtPosiljatelj;
        private System.Windows.Forms.GroupBox grbPrimatelj;
        private System.Windows.Forms.TextBox txtPrimatelj;
        private System.Windows.Forms.Button btnSpremi;
        private PostaDataSet postaDataSet;
        private System.Windows.Forms.BindingSource dKPosiljkadgvBindingSource;
        private PostaDataSetTableAdapters.DK_Posiljka_dgvTableAdapter dK_Posiljka_dgvTableAdapter;
        private PostaDataSet1 postaDataSet1;
        private System.Windows.Forms.BindingSource dKGradoviBindingSource;
        private PostaDataSet1TableAdapters.DK_GradoviTableAdapter dK_GradoviTableAdapter;
        private PostaDataSet2 postaDataSet2;
        private System.Windows.Forms.BindingSource dKGradoviBindingSource1;
        private PostaDataSet2TableAdapters.DK_GradoviTableAdapter dK_GradoviTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isporucenoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn polazisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn odredisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primateljDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posiljateljDataGridViewTextBoxColumn;
    }
}

