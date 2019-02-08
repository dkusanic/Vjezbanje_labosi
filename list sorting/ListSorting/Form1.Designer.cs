namespace ListSorting
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
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNameLastName = new System.Windows.Forms.TextBox();
            this.labelNameLastName = new System.Windows.Forms.Label();
            this.groupBoxSortMethod = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSortLastname = new System.Windows.Forms.Button();
            this.buttonSortName = new System.Windows.Forms.Button();
            this.listBoxPopis = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxData.SuspendLayout();
            this.groupBoxSortMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.buttonAdd);
            this.groupBoxData.Controls.Add(this.textBoxNameLastName);
            this.groupBoxData.Controls.Add(this.labelNameLastName);
            this.groupBoxData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(330, 57);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(244, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNameLastName
            // 
            this.textBoxNameLastName.Location = new System.Drawing.Point(138, 22);
            this.textBoxNameLastName.Name = "textBoxNameLastName";
            this.textBoxNameLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameLastName.TabIndex = 1;
            // 
            // labelNameLastName
            // 
            this.labelNameLastName.AutoSize = true;
            this.labelNameLastName.Location = new System.Drawing.Point(19, 25);
            this.labelNameLastName.Name = "labelNameLastName";
            this.labelNameLastName.Size = new System.Drawing.Size(113, 13);
            this.labelNameLastName.TabIndex = 0;
            this.labelNameLastName.Text = "Name and Last Name:";
            // 
            // groupBoxSortMethod
            // 
            this.groupBoxSortMethod.Controls.Add(this.buttonClear);
            this.groupBoxSortMethod.Controls.Add(this.buttonSortLastname);
            this.groupBoxSortMethod.Controls.Add(this.buttonSortName);
            this.groupBoxSortMethod.Location = new System.Drawing.Point(12, 75);
            this.groupBoxSortMethod.Name = "groupBoxSortMethod";
            this.groupBoxSortMethod.Size = new System.Drawing.Size(330, 57);
            this.groupBoxSortMethod.TabIndex = 1;
            this.groupBoxSortMethod.TabStop = false;
            this.groupBoxSortMethod.Text = "Sort Method";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(244, 19);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear List";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSortLastname
            // 
            this.buttonSortLastname.Location = new System.Drawing.Point(119, 19);
            this.buttonSortLastname.Name = "buttonSortLastname";
            this.buttonSortLastname.Size = new System.Drawing.Size(89, 23);
            this.buttonSortLastname.TabIndex = 1;
            this.buttonSortLastname.Text = "By Lastname";
            this.buttonSortLastname.UseVisualStyleBackColor = true;
            this.buttonSortLastname.Click += new System.EventHandler(this.buttonSortLastname_Click);
            // 
            // buttonSortName
            // 
            this.buttonSortName.Location = new System.Drawing.Point(6, 19);
            this.buttonSortName.Name = "buttonSortName";
            this.buttonSortName.Size = new System.Drawing.Size(75, 23);
            this.buttonSortName.TabIndex = 0;
            this.buttonSortName.Text = "By Name";
            this.buttonSortName.UseVisualStyleBackColor = true;
            this.buttonSortName.Click += new System.EventHandler(this.buttonSortName_Click);
            // 
            // listBoxPopis
            // 
            this.listBoxPopis.FormattingEnabled = true;
            this.listBoxPopis.Location = new System.Drawing.Point(12, 138);
            this.listBoxPopis.Name = "listBoxPopis";
            this.listBoxPopis.Size = new System.Drawing.Size(330, 160);
            this.listBoxPopis.TabIndex = 2;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ListSorting.User);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 313);
            this.Controls.Add(this.listBoxPopis);
            this.Controls.Add(this.groupBoxSortMethod);
            this.Controls.Add(this.groupBoxData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Sorting";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxSortMethod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNameLastName;
        private System.Windows.Forms.Label labelNameLastName;
        private System.Windows.Forms.GroupBox groupBoxSortMethod;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSortLastname;
        private System.Windows.Forms.Button buttonSortName;
        private System.Windows.Forms.ListBox listBoxPopis;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}

