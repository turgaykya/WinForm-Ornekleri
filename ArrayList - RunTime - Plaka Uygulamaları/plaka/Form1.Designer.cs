namespace plaka
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
            this.lblSehirler = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.txtBxPlaka = new System.Windows.Forms.TextBox();
            this.txtBxSehir = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKayitlar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(259, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 2;
            // 
            // lblSehirler
            // 
            this.lblSehirler.AutoSize = true;
            this.lblSehirler.Location = new System.Drawing.Point(112, 50);
            this.lblSehirler.Name = "lblSehirler";
            this.lblSehirler.Size = new System.Drawing.Size(42, 13);
            this.lblSehirler.TabIndex = 3;
            this.lblSehirler.Text = "Şehirler";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(112, 76);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 4;
            this.lblPlaka.Text = "Plaka";
            // 
            // txtBxPlaka
            // 
            this.txtBxPlaka.Location = new System.Drawing.Point(153, 76);
            this.txtBxPlaka.Name = "txtBxPlaka";
            this.txtBxPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtBxPlaka.TabIndex = 1;
            // 
            // txtBxSehir
            // 
            this.txtBxSehir.Location = new System.Drawing.Point(153, 50);
            this.txtBxSehir.Name = "txtBxSehir";
            this.txtBxSehir.Size = new System.Drawing.Size(100, 20);
            this.txtBxSehir.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(153, 102);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKayitlar
            // 
            this.lblKayitlar.AutoSize = true;
            this.lblKayitlar.Location = new System.Drawing.Point(256, 25);
            this.lblKayitlar.Name = "lblKayitlar";
            this.lblKayitlar.Size = new System.Drawing.Size(41, 13);
            this.lblKayitlar.TabIndex = 5;
            this.lblKayitlar.Text = "Kayıtlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 376);
            this.Controls.Add(this.lblKayitlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBxSehir);
            this.Controls.Add(this.txtBxPlaka);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblSehirler);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblSehirler;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox txtBxPlaka;
        private System.Windows.Forms.TextBox txtBxSehir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblKayitlar;
    }
}

