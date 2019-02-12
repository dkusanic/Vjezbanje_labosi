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
            this.grbPosiljatelj = new System.Windows.Forms.GroupBox();
            this.grbPrimatelj = new System.Windows.Forms.GroupBox();
            this.txtPosiljatelj = new System.Windows.Forms.TextBox();
            this.txtPrimatelj = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.postaDataSet = new Posta.PostaDataSet();
            this.dKPosiljkadgvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dK_Posiljka_dgvTableAdapter = new Posta.PostaDataSetTableAdapters.DK_Posiljka_dgvTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isporucenoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.polazisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odredisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primateljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posiljateljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiljke)).BeginInit();
            this.grbPosiljatelj.SuspendLayout();
            this.grbPrimatelj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKPosiljkadgvBindingSource)).BeginInit();
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
            // txtPosiljatelj
            // 
            this.txtPosiljatelj.Location = new System.Drawing.Point(6, 19);
            this.txtPosiljatelj.Multiline = true;
            this.txtPosiljatelj.Name = "txtPosiljatelj";
            this.txtPosiljatelj.Size = new System.Drawing.Size(227, 75);
            this.txtPosiljatelj.TabIndex = 0;
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
            // postaDataSet
            // 
            this.postaDataSet.DataSetName = "PostaDataSet";
            this.postaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dKPosiljkadgvBindingSource
            // 
            this.dKPosiljkadgvBindingSource.DataMember = "DK_Posiljka_dgv";
            this.dKPosiljkadgvBindingSource.DataSource = this.postaDataSet;
            // 
            // dK_Posiljka_dgvTableAdapter
            // 
            this.dK_Posiljka_dgvTableAdapter.ClearBeforeFill = true;
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
            this.polazisteDataGridViewTextBoxColumn.HeaderText = "Polaziste";
            this.polazisteDataGridViewTextBoxColumn.Name = "polazisteDataGridViewTextBoxColumn";
            this.polazisteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // odredisteDataGridViewTextBoxColumn
            // 
            this.odredisteDataGridViewTextBoxColumn.DataPropertyName = "Odrediste";
            this.odredisteDataGridViewTextBoxColumn.HeaderText = "Odrediste";
            this.odredisteDataGridViewTextBoxColumn.Name = "odredisteDataGridViewTextBoxColumn";
            this.odredisteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.grbPosiljatelj.ResumeLayout(false);
            this.grbPosiljatelj.PerformLayout();
            this.grbPrimatelj.ResumeLayout(false);
            this.grbPrimatelj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKPosiljkadgvBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isporucenoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polazisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odredisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primateljDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posiljateljDataGridViewTextBoxColumn;
    }
}

