﻿namespace Ispit
{
    partial class FrmIspit
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
            this.dgvPitanja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKolegiji = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolegiji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPitanja
            // 
            this.dgvPitanja.AllowUserToResizeColumns = false;
            this.dgvPitanja.AllowUserToResizeRows = false;
            this.dgvPitanja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPitanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitanja.Location = new System.Drawing.Point(15, 257);
            this.dgvPitanja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPitanja.Name = "dgvPitanja";
            this.dgvPitanja.ReadOnly = true;
            this.dgvPitanja.RowHeadersVisible = false;
            this.dgvPitanja.RowTemplate.Height = 24;
            this.dgvPitanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPitanja.Size = new System.Drawing.Size(704, 192);
            this.dgvPitanja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ispitna pitanja";
            // 
            // dgvKolegiji
            // 
            this.dgvKolegiji.AllowUserToResizeColumns = false;
            this.dgvKolegiji.AllowUserToResizeRows = false;
            this.dgvKolegiji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKolegiji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKolegiji.Location = new System.Drawing.Point(15, 30);
            this.dgvKolegiji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKolegiji.Name = "dgvKolegiji";
            this.dgvKolegiji.ReadOnly = true;
            this.dgvKolegiji.RowHeadersVisible = false;
            this.dgvKolegiji.RowTemplate.Height = 24;
            this.dgvKolegiji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKolegiji.Size = new System.Drawing.Size(704, 206);
            this.dgvKolegiji.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolegiji";
            // 
            // FrmIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKolegiji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPitanja);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmIspit";
            this.Text = "Baza ispitnih pitanja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolegiji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPitanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKolegiji;
        private System.Windows.Forms.Label label2;
    }
}
