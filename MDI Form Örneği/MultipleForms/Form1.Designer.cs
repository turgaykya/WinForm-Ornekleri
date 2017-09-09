namespace MultipleForms
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnDeleteDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 368);
            this.listBox1.TabIndex = 0;
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(12, 12);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(75, 23);
            this.btnNewStudent.TabIndex = 1;
            this.btnNewStudent.Text = "Yeni Ekle";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(93, 12);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 1;
            this.btnDeleteStudent.Text = "Sil";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnDeleteDialog
            // 
            this.btnDeleteDialog.Location = new System.Drawing.Point(228, 11);
            this.btnDeleteDialog.Name = "btnDeleteDialog";
            this.btnDeleteDialog.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDialog.TabIndex = 2;
            this.btnDeleteDialog.Text = "Sil (Dialog)";
            this.btnDeleteDialog.UseVisualStyleBackColor = true;
            this.btnDeleteDialog.Click += new System.EventHandler(this.btnDeleteDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 425);
            this.Controls.Add(this.btnDeleteDialog);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDeleteDialog;
    }
}

