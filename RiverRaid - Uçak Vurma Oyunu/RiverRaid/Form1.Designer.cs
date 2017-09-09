namespace RiverRaid
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.imgEfekt4 = new System.Windows.Forms.PictureBox();
            this.imgEfekt2 = new System.Windows.Forms.PictureBox();
            this.imgEfekt3 = new System.Windows.Forms.PictureBox();
            this.imgEfekt = new System.Windows.Forms.PictureBox();
            this.imgUcak = new System.Windows.Forms.PictureBox();
            this.ArkaPlan = new System.Windows.Forms.PictureBox();
            this.SagKenar = new System.Windows.Forms.PictureBox();
            this.SolKenar = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.lblSkor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfekt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfekt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfekt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfekt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUcak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SagKenar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolKenar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // imgEfekt4
            // 
            this.imgEfekt4.Image = global::RiverRaid.Properties.Resources.efekt1;
            this.imgEfekt4.Location = new System.Drawing.Point(832, 342);
            this.imgEfekt4.Name = "imgEfekt4";
            this.imgEfekt4.Size = new System.Drawing.Size(93, 67);
            this.imgEfekt4.TabIndex = 3;
            this.imgEfekt4.TabStop = false;
            // 
            // imgEfekt2
            // 
            this.imgEfekt2.Image = global::RiverRaid.Properties.Resources.efekt1;
            this.imgEfekt2.Location = new System.Drawing.Point(832, 35);
            this.imgEfekt2.Name = "imgEfekt2";
            this.imgEfekt2.Size = new System.Drawing.Size(93, 67);
            this.imgEfekt2.TabIndex = 3;
            this.imgEfekt2.TabStop = false;
            // 
            // imgEfekt3
            // 
            this.imgEfekt3.Image = global::RiverRaid.Properties.Resources.efekt1;
            this.imgEfekt3.Location = new System.Drawing.Point(57, 342);
            this.imgEfekt3.Name = "imgEfekt3";
            this.imgEfekt3.Size = new System.Drawing.Size(93, 67);
            this.imgEfekt3.TabIndex = 3;
            this.imgEfekt3.TabStop = false;
            // 
            // imgEfekt
            // 
            this.imgEfekt.Image = global::RiverRaid.Properties.Resources.efekt1;
            this.imgEfekt.Location = new System.Drawing.Point(57, 35);
            this.imgEfekt.Name = "imgEfekt";
            this.imgEfekt.Size = new System.Drawing.Size(93, 67);
            this.imgEfekt.TabIndex = 3;
            this.imgEfekt.TabStop = false;
            // 
            // imgUcak
            // 
            this.imgUcak.Image = global::RiverRaid.Properties.Resources.ucak;
            this.imgUcak.Location = new System.Drawing.Point(478, 551);
            this.imgUcak.Name = "imgUcak";
            this.imgUcak.Size = new System.Drawing.Size(46, 50);
            this.imgUcak.TabIndex = 2;
            this.imgUcak.TabStop = false;
            this.imgUcak.Click += new System.EventHandler(this.imgUcak_Click);
            // 
            // ArkaPlan
            // 
            this.ArkaPlan.Image = global::RiverRaid.Properties.Resources.arkaplan1;
            this.ArkaPlan.Location = new System.Drawing.Point(245, -3);
            this.ArkaPlan.Name = "ArkaPlan";
            this.ArkaPlan.Size = new System.Drawing.Size(521, 716);
            this.ArkaPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArkaPlan.TabIndex = 1;
            this.ArkaPlan.TabStop = false;
            // 
            // SagKenar
            // 
            this.SagKenar.Image = global::RiverRaid.Properties.Resources.kenar;
            this.SagKenar.Location = new System.Drawing.Point(764, -3);
            this.SagKenar.Name = "SagKenar";
            this.SagKenar.Size = new System.Drawing.Size(249, 739);
            this.SagKenar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SagKenar.TabIndex = 0;
            this.SagKenar.TabStop = false;
            // 
            // SolKenar
            // 
            this.SolKenar.Image = global::RiverRaid.Properties.Resources.kenar;
            this.SolKenar.Location = new System.Drawing.Point(-2, -12);
            this.SolKenar.Name = "SolKenar";
            this.SolKenar.Size = new System.Drawing.Size(249, 739);
            this.SolKenar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SolKenar.TabIndex = 0;
            this.SolKenar.TabStop = false;
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(-1, 595);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(41, 13);
            this.lblSkor.TabIndex = 4;
            this.lblSkor.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1002, 654);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.imgEfekt4);
            this.Controls.Add(this.imgEfekt2);
            this.Controls.Add(this.imgEfekt3);
            this.Controls.Add(this.imgEfekt);
            this.Controls.Add(this.imgUcak);
            this.Controls.Add(this.ArkaPlan);
            this.Controls.Add(this.SagKenar);
            this.Controls.Add(this.SolKenar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1018, 693);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_Keydown);
            ((System.ComponentModel.ISupportInitialize)(this.imgEfekt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfekt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfekt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEfekt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUcak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SagKenar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolKenar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SolKenar;
        private System.Windows.Forms.PictureBox SagKenar;
        private System.Windows.Forms.PictureBox ArkaPlan;
        private System.Windows.Forms.PictureBox imgUcak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox imgEfekt;
        private System.Windows.Forms.PictureBox imgEfekt2;
        private System.Windows.Forms.PictureBox imgEfekt3;
        private System.Windows.Forms.PictureBox imgEfekt4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label lblSkor;
    }
}

