namespace BrojacUlaza
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
            this.listBoxIspis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxUnos
            // 
            this.textBoxUnos.Location = new System.Drawing.Point(12, 12);
            this.textBoxUnos.Multiline = true;
            this.textBoxUnos.Name = "textBoxUnos";
            this.textBoxUnos.Size = new System.Drawing.Size(268, 152);
            this.textBoxUnos.TabIndex = 0;
            this.textBoxUnos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxUnos_KeyUp);
            // 
            // listBoxIspis
            // 
            this.listBoxIspis.FormattingEnabled = true;
            this.listBoxIspis.Location = new System.Drawing.Point(12, 170);
            this.listBoxIspis.Name = "listBoxIspis";
            this.listBoxIspis.Size = new System.Drawing.Size(268, 316);
            this.listBoxIspis.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 490);
            this.Controls.Add(this.listBoxIspis);
            this.Controls.Add(this.textBoxUnos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnos;
        private System.Windows.Forms.ListBox listBoxIspis;
    }
}

