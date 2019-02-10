namespace PolozeneVjezbe
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMentor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVjezbe = new System.Windows.Forms.ComboBox();
            this.korisnickaOznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mentorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polozeneVjezbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnickaOznakaDataGridViewTextBoxColumn,
            this.mentorDataGridViewTextBoxColumn,
            this.polozeneVjezbeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mentor:";
            // 
            // txtMentor
            // 
            this.txtMentor.Location = new System.Drawing.Point(58, 22);
            this.txtMentor.Name = "txtMentor";
            this.txtMentor.Size = new System.Drawing.Size(100, 20);
            this.txtMentor.TabIndex = 2;
            this.txtMentor.TextChanged += new System.EventHandler(this.txtMentor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Položene Vježbe:";
            // 
            // cmbVjezbe
            // 
            this.cmbVjezbe.FormattingEnabled = true;
            this.cmbVjezbe.Items.AddRange(new object[] {
            "None",
            "Da",
            "Ne"});
            this.cmbVjezbe.Location = new System.Drawing.Point(302, 22);
            this.cmbVjezbe.Name = "cmbVjezbe";
            this.cmbVjezbe.Size = new System.Drawing.Size(121, 21);
            this.cmbVjezbe.TabIndex = 4;
            this.cmbVjezbe.SelectedIndexChanged += new System.EventHandler(this.cmbVjezbe_SelectedIndexChanged);
            // 
            // korisnickaOznakaDataGridViewTextBoxColumn
            // 
            this.korisnickaOznakaDataGridViewTextBoxColumn.DataPropertyName = "KorisnickaOznaka";
            this.korisnickaOznakaDataGridViewTextBoxColumn.HeaderText = "Korisnička oznaka";
            this.korisnickaOznakaDataGridViewTextBoxColumn.Name = "korisnickaOznakaDataGridViewTextBoxColumn";
            // 
            // mentorDataGridViewTextBoxColumn
            // 
            this.mentorDataGridViewTextBoxColumn.DataPropertyName = "Mentor";
            this.mentorDataGridViewTextBoxColumn.HeaderText = "Mentor";
            this.mentorDataGridViewTextBoxColumn.Name = "mentorDataGridViewTextBoxColumn";
            // 
            // polozeneVjezbeDataGridViewTextBoxColumn
            // 
            this.polozeneVjezbeDataGridViewTextBoxColumn.DataPropertyName = "PolozeneVjezbe";
            this.polozeneVjezbeDataGridViewTextBoxColumn.HeaderText = "Položene vježbe";
            this.polozeneVjezbeDataGridViewTextBoxColumn.Name = "polozeneVjezbeDataGridViewTextBoxColumn";
            this.polozeneVjezbeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.polozeneVjezbeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(PolozeneVjezbe.Student);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 471);
            this.Controls.Add(this.cmbVjezbe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMentor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija položenih vježbi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickaOznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mentorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn polozeneVjezbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMentor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVjezbe;
    }
}

