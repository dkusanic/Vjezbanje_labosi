namespace BojeMatrice
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
            this.grbPostavke = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblVisina = new System.Windows.Forms.Label();
            this.lblSirina = new System.Windows.Forms.Label();
            this.nudSirina = new System.Windows.Forms.NumericUpDown();
            this.nudVisina = new System.Windows.Forms.NumericUpDown();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grbPostavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSirina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisina)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPostavke
            // 
            this.grbPostavke.Controls.Add(this.nudVisina);
            this.grbPostavke.Controls.Add(this.nudSirina);
            this.grbPostavke.Controls.Add(this.btnStop);
            this.grbPostavke.Controls.Add(this.btnStart);
            this.grbPostavke.Controls.Add(this.lblVisina);
            this.grbPostavke.Controls.Add(this.lblSirina);
            this.grbPostavke.Location = new System.Drawing.Point(12, 12);
            this.grbPostavke.Name = "grbPostavke";
            this.grbPostavke.Size = new System.Drawing.Size(321, 83);
            this.grbPostavke.TabIndex = 0;
            this.grbPostavke.TabStop = false;
            this.grbPostavke.Text = "Postavke polja";
            // 
            // btnStop
            // 
            this.helpProvider1.SetHelpString(this.btnStop, "help");
            this.btnStop.Location = new System.Drawing.Point(227, 11);
            this.btnStop.Name = "btnStop";
            this.helpProvider1.SetShowHelp(this.btnStop, true);
            this.btnStop.Size = new System.Drawing.Size(75, 57);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(146, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 57);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblVisina
            // 
            this.lblVisina.AutoSize = true;
            this.lblVisina.Location = new System.Drawing.Point(6, 51);
            this.lblVisina.Name = "lblVisina";
            this.lblVisina.Size = new System.Drawing.Size(38, 13);
            this.lblVisina.TabIndex = 1;
            this.lblVisina.Text = "Visina:";
            // 
            // lblSirina
            // 
            this.lblSirina.AutoSize = true;
            this.lblSirina.Location = new System.Drawing.Point(6, 16);
            this.lblSirina.Name = "lblSirina";
            this.lblSirina.Size = new System.Drawing.Size(36, 13);
            this.lblSirina.TabIndex = 0;
            this.lblSirina.Text = "Širina:";
            // 
            // nudSirina
            // 
            this.nudSirina.Location = new System.Drawing.Point(48, 14);
            this.nudSirina.Name = "nudSirina";
            this.nudSirina.Size = new System.Drawing.Size(92, 20);
            this.nudSirina.TabIndex = 1;
            // 
            // nudVisina
            // 
            this.nudVisina.Location = new System.Drawing.Point(50, 49);
            this.nudVisina.Name = "nudVisina";
            this.nudVisina.Size = new System.Drawing.Size(92, 20);
            this.nudVisina.TabIndex = 6;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Domac\\Documents\\GitHub\\Vjezbanje_labosi\\boje_matrice\\BojeMatrice\\help.ch" +
    "m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbPostavke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbPostavke.ResumeLayout(false);
            this.grbPostavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSirina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVisina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPostavke;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblVisina;
        private System.Windows.Forms.Label lblSirina;
        private System.Windows.Forms.NumericUpDown nudVisina;
        private System.Windows.Forms.NumericUpDown nudSirina;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

