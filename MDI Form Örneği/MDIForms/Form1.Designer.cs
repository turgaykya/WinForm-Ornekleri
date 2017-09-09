namespace MDIForms
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
            this.personelYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.stokYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.personelYönetimiToolStripMenuItem,
            this.stokYönetimiToolStripMenuItem,
            this.uygulamalarToolStripMenuItem,
            this.görünümToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(681, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // personelYönetimiToolStripMenuItem
            // 
            this.personelYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewEmployee,
            this.menuItemEmployeeList});
            this.personelYönetimiToolStripMenuItem.Name = "personelYönetimiToolStripMenuItem";
            this.personelYönetimiToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.personelYönetimiToolStripMenuItem.Text = "Personel Yönetimi";
            // 
            // menuItemNewEmployee
            // 
            this.menuItemNewEmployee.Name = "menuItemNewEmployee";
            this.menuItemNewEmployee.Size = new System.Drawing.Size(183, 26);
            this.menuItemNewEmployee.Text = "Yeni Personel";
            this.menuItemNewEmployee.Click += new System.EventHandler(this.menuItemNewEmployee_Click);
            // 
            // menuItemEmployeeList
            // 
            this.menuItemEmployeeList.Name = "menuItemEmployeeList";
            this.menuItemEmployeeList.Size = new System.Drawing.Size(183, 26);
            this.menuItemEmployeeList.Text = "Personel Listesi";
            this.menuItemEmployeeList.Click += new System.EventHandler(this.menuItemEmployeeList_Click);
            // 
            // stokYönetimiToolStripMenuItem
            // 
            this.stokYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddProduct});
            this.stokYönetimiToolStripMenuItem.Name = "stokYönetimiToolStripMenuItem";
            this.stokYönetimiToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.stokYönetimiToolStripMenuItem.Text = "Stok Yönetimi";
            // 
            // menuItemAddProduct
            // 
            this.menuItemAddProduct.Name = "menuItemAddProduct";
            this.menuItemAddProduct.Size = new System.Drawing.Size(181, 26);
            this.menuItemAddProduct.Text = "Yeni Ürün";
            this.menuItemAddProduct.Click += new System.EventHandler(this.menuItemAddProduct_Click);
            // 
            // uygulamalarToolStripMenuItem
            // 
            this.uygulamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCalculator});
            this.uygulamalarToolStripMenuItem.Name = "uygulamalarToolStripMenuItem";
            this.uygulamalarToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.uygulamalarToolStripMenuItem.Text = "Uygulamalar";
            // 
            // menuItemCalculator
            // 
            this.menuItemCalculator.Name = "menuItemCalculator";
            this.menuItemCalculator.Size = new System.Drawing.Size(188, 26);
            this.menuItemCalculator.Text = "Hesap Makinesi";
            this.menuItemCalculator.Click += new System.EventHandler(this.menuItemCalculator_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCascade,
            this.menuItemVertical,
            this.menuItemHorizontal,
            this.menuItemArrangeIcons,
            this.menuItemCloseAll});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // menuItemCascade
            // 
            this.menuItemCascade.Name = "menuItemCascade";
            this.menuItemCascade.Size = new System.Drawing.Size(191, 26);
            this.menuItemCascade.Text = "Basamak";
            this.menuItemCascade.Click += new System.EventHandler(this.menuItemCascade_Click);
            // 
            // menuItemVertical
            // 
            this.menuItemVertical.Name = "menuItemVertical";
            this.menuItemVertical.Size = new System.Drawing.Size(191, 26);
            this.menuItemVertical.Text = "Dikey";
            this.menuItemVertical.Click += new System.EventHandler(this.menuItemVertical_Click);
            // 
            // menuItemHorizontal
            // 
            this.menuItemHorizontal.Name = "menuItemHorizontal";
            this.menuItemHorizontal.Size = new System.Drawing.Size(191, 26);
            this.menuItemHorizontal.Text = "Yatay";
            this.menuItemHorizontal.Click += new System.EventHandler(this.menuItemHorizontal_Click);
            // 
            // menuItemArrangeIcons
            // 
            this.menuItemArrangeIcons.Name = "menuItemArrangeIcons";
            this.menuItemArrangeIcons.Size = new System.Drawing.Size(191, 26);
            this.menuItemArrangeIcons.Text = "İkonları Düzenle";
            this.menuItemArrangeIcons.Click += new System.EventHandler(this.menuItemArrangeIcons_Click);
            // 
            // menuItemCloseAll
            // 
            this.menuItemCloseAll.Name = "menuItemCloseAll";
            this.menuItemCloseAll.Size = new System.Drawing.Size(191, 26);
            this.menuItemCloseAll.Text = "Hepsini Kapat";
            this.menuItemCloseAll.Click += new System.EventHandler(this.menuItemCloseAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 558);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCalculator;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemCascade;
        private System.Windows.Forms.ToolStripMenuItem menuItemVertical;
        private System.Windows.Forms.ToolStripMenuItem menuItemHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuItemArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem menuItemCloseAll;
        private System.Windows.Forms.ToolStripMenuItem personelYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem stokYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddProduct;
        private System.Windows.Forms.ToolStripMenuItem menuItemEmployeeList;
    }
}

