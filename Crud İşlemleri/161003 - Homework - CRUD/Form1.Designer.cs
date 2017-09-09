namespace _161003___Homework___CRUD
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEkle,
            this.menuItemGuncelle,
            this.menuItemSil});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.dosyaToolStripMenuItem.Text = "Product İşlemleri";
            // 
            // menuItemEkle
            // 
            this.menuItemEkle.Name = "menuItemEkle";
            this.menuItemEkle.Size = new System.Drawing.Size(120, 22);
            this.menuItemEkle.Text = "Ekle";
            this.menuItemEkle.Click += new System.EventHandler(this.menuItemEkle_Click);
            // 
            // menuItemGuncelle
            // 
            this.menuItemGuncelle.Name = "menuItemGuncelle";
            this.menuItemGuncelle.Size = new System.Drawing.Size(120, 22);
            this.menuItemGuncelle.Text = "Güncelle";
            this.menuItemGuncelle.Click += new System.EventHandler(this.menuItemGuncelle_Click);
            // 
            // menuItemSil
            // 
            this.menuItemSil.Name = "menuItemSil";
            this.menuItemSil.Size = new System.Drawing.Size(120, 22);
            this.menuItemSil.Text = "Sil";
            this.menuItemSil.Click += new System.EventHandler(this.menuItemSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(831, 309);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(847, 347);
            this.MinimumSize = new System.Drawing.Size(847, 347);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemEkle;
        private System.Windows.Forms.ToolStripMenuItem menuItemGuncelle;
        private System.Windows.Forms.ToolStripMenuItem menuItemSil;
    }
}

