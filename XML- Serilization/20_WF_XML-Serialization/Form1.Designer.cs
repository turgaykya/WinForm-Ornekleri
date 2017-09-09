namespace _20_WF_XML_Serialization
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.nudOkulNo = new System.Windows.Forms.NumericUpDown();
            this.dtpDoğumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTekOgrenci = new System.Windows.Forms.Button();
            this.btnHepsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOkulNo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(96, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(185, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(96, 61);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(185, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // nudOkulNo
            // 
            this.nudOkulNo.Location = new System.Drawing.Point(96, 105);
            this.nudOkulNo.Name = "nudOkulNo";
            this.nudOkulNo.Size = new System.Drawing.Size(185, 20);
            this.nudOkulNo.TabIndex = 2;
            // 
            // dtpDoğumTarihi
            // 
            this.dtpDoğumTarihi.Location = new System.Drawing.Point(96, 146);
            this.dtpDoğumTarihi.Name = "dtpDoğumTarihi";
            this.dtpDoğumTarihi.Size = new System.Drawing.Size(185, 20);
            this.dtpDoğumTarihi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Okul No : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 188);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(410, 190);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Okul No";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doğum Tarihi";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yaş";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(310, 21);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 39);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTekOgrenci
            // 
            this.btnTekOgrenci.Location = new System.Drawing.Point(310, 66);
            this.btnTekOgrenci.Name = "btnTekOgrenci";
            this.btnTekOgrenci.Size = new System.Drawing.Size(88, 39);
            this.btnTekOgrenci.TabIndex = 10;
            this.btnTekOgrenci.Text = "Tek Öğrenci Serilize Et";
            this.btnTekOgrenci.UseVisualStyleBackColor = true;
            this.btnTekOgrenci.Click += new System.EventHandler(this.btnTekOgrenci_Click);
            // 
            // btnHepsi
            // 
            this.btnHepsi.Location = new System.Drawing.Point(310, 111);
            this.btnHepsi.Name = "btnHepsi";
            this.btnHepsi.Size = new System.Drawing.Size(88, 39);
            this.btnHepsi.TabIndex = 11;
            this.btnHepsi.Text = "Hepsini Serilize Et";
            this.btnHepsi.UseVisualStyleBackColor = true;
            this.btnHepsi.Click += new System.EventHandler(this.btnHepsi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 377);
            this.Controls.Add(this.btnHepsi);
            this.Controls.Add(this.btnTekOgrenci);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDoğumTarihi);
            this.Controls.Add(this.nudOkulNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudOkulNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.NumericUpDown nudOkulNo;
        private System.Windows.Forms.DateTimePicker dtpDoğumTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTekOgrenci;
        private System.Windows.Forms.Button btnHepsi;
    }
}

