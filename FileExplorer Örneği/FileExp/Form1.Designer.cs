namespace FileExp
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
            this.tvSol = new System.Windows.Forms.TreeView();
            this.cmbSuruculer = new System.Windows.Forms.ComboBox();
            this.lstSag = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tvSol
            // 
            this.tvSol.Location = new System.Drawing.Point(1, 24);
            this.tvSol.Name = "tvSol";
            this.tvSol.Size = new System.Drawing.Size(209, 360);
            this.tvSol.TabIndex = 0;
            this.tvSol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSol_AfterSelect);
            // 
            // cmbSuruculer
            // 
            this.cmbSuruculer.FormattingEnabled = true;
            this.cmbSuruculer.Location = new System.Drawing.Point(1, 1);
            this.cmbSuruculer.Name = "cmbSuruculer";
            this.cmbSuruculer.Size = new System.Drawing.Size(209, 21);
            this.cmbSuruculer.TabIndex = 1;
            // 
            // lstSag
            // 
            this.lstSag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstSag.FullRowSelect = true;
            this.lstSag.Location = new System.Drawing.Point(212, 1);
            this.lstSag.MultiSelect = false;
            this.lstSag.Name = "lstSag";
            this.lstSag.Size = new System.Drawing.Size(513, 383);
            this.lstSag.TabIndex = 2;
            this.lstSag.UseCompatibleStateImageBehavior = false;
            this.lstSag.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İçindekiler";
            this.columnHeader1.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(727, 385);
            this.Controls.Add(this.lstSag);
            this.Controls.Add(this.cmbSuruculer);
            this.Controls.Add(this.tvSol);
            this.MaximumSize = new System.Drawing.Size(743, 423);
            this.MinimumSize = new System.Drawing.Size(743, 423);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvSol;
        private System.Windows.Forms.ComboBox cmbSuruculer;
        private System.Windows.Forms.ListView lstSag;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

