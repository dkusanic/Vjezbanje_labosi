namespace bus_linije
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autobusnaLinijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polazisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odredisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udaljenostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaStudentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaPovratnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusnaLinijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.polazisteDataGridViewTextBoxColumn,
            this.odredisteDataGridViewTextBoxColumn,
            this.udaljenostDataGridViewTextBoxColumn,
            this.cijenaKarteDataGridViewTextBoxColumn,
            this.cijenaStudentiDataGridViewTextBoxColumn,
            this.cijenaPovratnaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autobusnaLinijaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // autobusnaLinijaBindingSource
            // 
            this.autobusnaLinijaBindingSource.DataSource = typeof(bus_linije.AutobusnaLinija);
            // 
            // polazisteDataGridViewTextBoxColumn
            // 
            this.polazisteDataGridViewTextBoxColumn.DataPropertyName = "Polaziste";
            this.polazisteDataGridViewTextBoxColumn.HeaderText = "Polaziste";
            this.polazisteDataGridViewTextBoxColumn.Name = "polazisteDataGridViewTextBoxColumn";
            // 
            // odredisteDataGridViewTextBoxColumn
            // 
            this.odredisteDataGridViewTextBoxColumn.DataPropertyName = "Odrediste";
            this.odredisteDataGridViewTextBoxColumn.HeaderText = "Odrediste";
            this.odredisteDataGridViewTextBoxColumn.Name = "odredisteDataGridViewTextBoxColumn";
            // 
            // udaljenostDataGridViewTextBoxColumn
            // 
            this.udaljenostDataGridViewTextBoxColumn.DataPropertyName = "Udaljenost";
            this.udaljenostDataGridViewTextBoxColumn.HeaderText = "Udaljenost";
            this.udaljenostDataGridViewTextBoxColumn.Name = "udaljenostDataGridViewTextBoxColumn";
            // 
            // cijenaKarteDataGridViewTextBoxColumn
            // 
            this.cijenaKarteDataGridViewTextBoxColumn.DataPropertyName = "CijenaKarte";
            this.cijenaKarteDataGridViewTextBoxColumn.HeaderText = "CijenaKarte";
            this.cijenaKarteDataGridViewTextBoxColumn.Name = "cijenaKarteDataGridViewTextBoxColumn";
            // 
            // cijenaStudentiDataGridViewTextBoxColumn
            // 
            this.cijenaStudentiDataGridViewTextBoxColumn.DataPropertyName = "CijenaStudenti";
            this.cijenaStudentiDataGridViewTextBoxColumn.HeaderText = "CijenaStudenti";
            this.cijenaStudentiDataGridViewTextBoxColumn.Name = "cijenaStudentiDataGridViewTextBoxColumn";
            // 
            // cijenaPovratnaDataGridViewTextBoxColumn
            // 
            this.cijenaPovratnaDataGridViewTextBoxColumn.DataPropertyName = "CijenaPovratna";
            this.cijenaPovratnaDataGridViewTextBoxColumn.HeaderText = "CijenaPovratna";
            this.cijenaPovratnaDataGridViewTextBoxColumn.Name = "cijenaPovratnaDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "AUTOBUSNE LINIJE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusnaLinijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn polazisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odredisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn udaljenostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaStudentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaPovratnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource autobusnaLinijaBindingSource;
    }
}

