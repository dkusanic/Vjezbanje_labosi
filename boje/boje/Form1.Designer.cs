namespace boje
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
            this.odaberiBojuBtn = new System.Windows.Forms.Button();
            this.dodajBojuBtn = new System.Windows.Forms.Button();
            this.odabranaBojaPnl = new System.Windows.Forms.Panel();
            this.odabranaBojaLbl = new System.Windows.Forms.Label();
            this.bojeUListiGrpbx = new System.Windows.Forms.GroupBox();
            this.randomBojaPnl = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // odaberiBojuBtn
            // 
            this.odaberiBojuBtn.Location = new System.Drawing.Point(12, 38);
            this.odaberiBojuBtn.Name = "odaberiBojuBtn";
            this.odaberiBojuBtn.Size = new System.Drawing.Size(105, 23);
            this.odaberiBojuBtn.TabIndex = 0;
            this.odaberiBojuBtn.Text = "Odaberi boju";
            this.odaberiBojuBtn.UseVisualStyleBackColor = true;
            this.odaberiBojuBtn.Click += new System.EventHandler(this.odaberiBojuBtn_Click);
            // 
            // dodajBojuBtn
            // 
            this.dodajBojuBtn.Location = new System.Drawing.Point(12, 76);
            this.dodajBojuBtn.Name = "dodajBojuBtn";
            this.dodajBojuBtn.Size = new System.Drawing.Size(105, 23);
            this.dodajBojuBtn.TabIndex = 1;
            this.dodajBojuBtn.Text = "Dodaj boju u listu";
            this.dodajBojuBtn.UseVisualStyleBackColor = true;
            this.dodajBojuBtn.Click += new System.EventHandler(this.dodajBojuBtn_Click);
            // 
            // odabranaBojaPnl
            // 
            this.odabranaBojaPnl.Location = new System.Drawing.Point(123, 38);
            this.odabranaBojaPnl.Name = "odabranaBojaPnl";
            this.odabranaBojaPnl.Size = new System.Drawing.Size(86, 23);
            this.odabranaBojaPnl.TabIndex = 2;
            // 
            // odabranaBojaLbl
            // 
            this.odabranaBojaLbl.AutoSize = true;
            this.odabranaBojaLbl.Location = new System.Drawing.Point(129, 22);
            this.odabranaBojaLbl.Name = "odabranaBojaLbl";
            this.odabranaBojaLbl.Size = new System.Drawing.Size(80, 13);
            this.odabranaBojaLbl.TabIndex = 3;
            this.odabranaBojaLbl.Text = "Odabrana boja:";
            // 
            // bojeUListiGrpbx
            // 
            this.bojeUListiGrpbx.Location = new System.Drawing.Point(12, 105);
            this.bojeUListiGrpbx.Name = "bojeUListiGrpbx";
            this.bojeUListiGrpbx.Size = new System.Drawing.Size(200, 56);
            this.bojeUListiGrpbx.TabIndex = 4;
            this.bojeUListiGrpbx.TabStop = false;
            this.bojeUListiGrpbx.Text = "Boje u listi";
            // 
            // randomBojaPnl
            // 
            this.randomBojaPnl.Location = new System.Drawing.Point(12, 167);
            this.randomBojaPnl.Name = "randomBojaPnl";
            this.randomBojaPnl.Size = new System.Drawing.Size(200, 66);
            this.randomBojaPnl.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 250);
            this.Controls.Add(this.randomBojaPnl);
            this.Controls.Add(this.bojeUListiGrpbx);
            this.Controls.Add(this.odabranaBojaLbl);
            this.Controls.Add(this.odabranaBojaPnl);
            this.Controls.Add(this.dodajBojuBtn);
            this.Controls.Add(this.odaberiBojuBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI - 5.5.2016.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odaberiBojuBtn;
        private System.Windows.Forms.Button dodajBojuBtn;
        private System.Windows.Forms.Panel odabranaBojaPnl;
        private System.Windows.Forms.Label odabranaBojaLbl;
        private System.Windows.Forms.GroupBox bojeUListiGrpbx;
        private System.Windows.Forms.Panel randomBojaPnl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

