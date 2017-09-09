namespace _20_WF_XML_Serialization
{
    partial class Form2
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
            this.btnKur = new System.Windows.Forms.Button();
            this.lstKurBilgileri = new System.Windows.Forms.ListBox();
            this.lblKurAdı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblAlışFiyatı = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSatışFiyatı = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKur
            // 
            this.btnKur.Location = new System.Drawing.Point(13, 27);
            this.btnKur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKur.Name = "btnKur";
            this.btnKur.Size = new System.Drawing.Size(227, 36);
            this.btnKur.TabIndex = 0;
            this.btnKur.Text = "Kur Bilgilerini Çek";
            this.btnKur.UseVisualStyleBackColor = true;
            this.btnKur.Click += new System.EventHandler(this.btnKur_Click);
            // 
            // lstKurBilgileri
            // 
            this.lstKurBilgileri.FormattingEnabled = true;
            this.lstKurBilgileri.ItemHeight = 16;
            this.lstKurBilgileri.Location = new System.Drawing.Point(13, 71);
            this.lstKurBilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstKurBilgileri.Name = "lstKurBilgileri";
            this.lstKurBilgileri.Size = new System.Drawing.Size(225, 404);
            this.lstKurBilgileri.TabIndex = 1;
            // 
            // lblKurAdı
            // 
            this.lblKurAdı.AutoSize = true;
            this.lblKurAdı.Location = new System.Drawing.Point(284, 95);
            this.lblKurAdı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKurAdı.Name = "lblKurAdı";
            this.lblKurAdı.Size = new System.Drawing.Size(123, 17);
            this.lblKurAdı.TabIndex = 2;
            this.lblKurAdı.Text = "(Henüz Seçilmedi)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birim : ";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(371, 166);
            this.lblBirim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(16, 17);
            this.lblBirim.TabIndex = 4;
            this.lblBirim.Text = "0";
            // 
            // lblAlışFiyatı
            // 
            this.lblAlışFiyatı.AutoSize = true;
            this.lblAlışFiyatı.Location = new System.Drawing.Point(371, 210);
            this.lblAlışFiyatı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlışFiyatı.Name = "lblAlışFiyatı";
            this.lblAlışFiyatı.Size = new System.Drawing.Size(16, 17);
            this.lblAlışFiyatı.TabIndex = 6;
            this.lblAlışFiyatı.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alış Fiyatı : ";
            // 
            // lblSatışFiyatı
            // 
            this.lblSatışFiyatı.AutoSize = true;
            this.lblSatışFiyatı.Location = new System.Drawing.Point(371, 251);
            this.lblSatışFiyatı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSatışFiyatı.Name = "lblSatışFiyatı";
            this.lblSatışFiyatı.Size = new System.Drawing.Size(16, 17);
            this.lblSatışFiyatı.TabIndex = 8;
            this.lblSatışFiyatı.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Satış Fiyatı : ";
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(265, 300);
            this.nudMiktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(160, 22);
            this.nudMiktar.TabIndex = 9;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(265, 352);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(160, 33);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(299, 430);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(16, 17);
            this.lblSonuc.TabIndex = 11;
            this.lblSonuc.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 507);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.lblSatışFiyatı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAlışFiyatı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKurAdı);
            this.Controls.Add(this.lstKurBilgileri);
            this.Controls.Add(this.btnKur);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKur;
        private System.Windows.Forms.ListBox lstKurBilgileri;
        private System.Windows.Forms.Label lblKurAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblAlışFiyatı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSatışFiyatı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}