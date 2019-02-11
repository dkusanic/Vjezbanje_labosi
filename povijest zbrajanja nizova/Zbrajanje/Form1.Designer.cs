namespace Zbrajanje
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.grbHistory = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grbInput.SuspendLayout();
            this.grbHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtSum);
            this.grbInput.Controls.Add(this.label1);
            this.grbInput.Controls.Add(this.btnSum);
            this.grbInput.Controls.Add(this.txtInput);
            this.grbInput.Location = new System.Drawing.Point(12, 12);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(184, 161);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Operation input";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(172, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(6, 45);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(172, 23);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current sum:";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(6, 125);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(172, 20);
            this.txtSum.TabIndex = 3;
            // 
            // grbHistory
            // 
            this.grbHistory.Controls.Add(this.listBox1);
            this.grbHistory.Location = new System.Drawing.Point(202, 12);
            this.grbHistory.Name = "grbHistory";
            this.grbHistory.Size = new System.Drawing.Size(184, 161);
            this.grbHistory.TabIndex = 1;
            this.grbHistory.TabStop = false;
            this.grbHistory.Text = "Operation history";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 134);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 182);
            this.Controls.Add(this.grbHistory);
            this.Controls.Add(this.grbInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Povijest zbrajanja nizova";
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grbHistory;
        private System.Windows.Forms.ListBox listBox1;
    }
}

