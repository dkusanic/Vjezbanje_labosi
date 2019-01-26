namespace frekvencije_slova
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
            this.textBoxUnos = new System.Windows.Forms.TextBox();
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUnos
            // 
            this.textBoxUnos.Location = new System.Drawing.Point(12, 12);
            this.textBoxUnos.Multiline = true;
            this.textBoxUnos.Name = "textBoxUnos";
            this.textBoxUnos.Size = new System.Drawing.Size(480, 426);
            this.textBoxUnos.TabIndex = 0;
            this.textBoxUnos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(498, 12);
            this.textBoxIspis.Multiline = true;
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.ReadOnly = true;
            this.textBoxIspis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIspis.Size = new System.Drawing.Size(170, 426);
            this.textBoxIspis.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.textBoxIspis);
            this.Controls.Add(this.textBoxUnos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI FOI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnos;
        private System.Windows.Forms.TextBox textBoxIspis;
    }
}

