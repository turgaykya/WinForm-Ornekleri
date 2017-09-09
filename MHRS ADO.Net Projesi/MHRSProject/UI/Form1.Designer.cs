namespace UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblChapta = new System.Windows.Forms.Label();
            this.txtChapta = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnSingUp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForget = new System.Windows.Forms.Button();
            this.lblRefresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblChapta
            // 
            this.lblChapta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChapta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChapta.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChapta.Image = ((System.Drawing.Image)(resources.GetObject("lblChapta.Image")));
            this.lblChapta.Location = new System.Drawing.Point(577, 262);
            this.lblChapta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChapta.Name = "lblChapta";
            this.lblChapta.Size = new System.Drawing.Size(201, 46);
            this.lblChapta.TabIndex = 7;
            this.lblChapta.Text = "     32453";
            // 
            // txtChapta
            // 
            this.txtChapta.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtChapta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtChapta.Location = new System.Drawing.Point(53, 266);
            this.txtChapta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChapta.Multiline = true;
            this.txtChapta.Name = "txtChapta";
            this.txtChapta.Size = new System.Drawing.Size(495, 45);
            this.txtChapta.TabIndex = 3;
            this.txtChapta.Text = "Sağda ne yazıyor?";
            this.txtChapta.Enter += new System.EventHandler(this.txtChapta_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Location = new System.Drawing.Point(53, 213);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(495, 45);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "MHRS şifrenizi giriniz";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTC.Location = new System.Drawing.Point(53, 159);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTC.Multiline = true;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(724, 45);
            this.txtTC.TabIndex = 1;
            this.txtTC.Text = "T.C. Kimlik numaranızı giriniz";
            this.txtTC.Enter += new System.EventHandler(this.txtTC_Enter);
            // 
            // btnSingUp
            // 
            this.btnSingUp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSingUp.FlatAppearance.BorderSize = 0;
            this.btnSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSingUp.ForeColor = System.Drawing.Color.DimGray;
            this.btnSingUp.Location = new System.Drawing.Point(53, 373);
            this.btnSingUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(725, 47);
            this.btnSingUp.TabIndex = 6;
            this.btnSingUp.Text = "Üye Ol";
            this.btnSingUp.UseVisualStyleBackColor = false;
            this.btnSingUp.Click += new System.EventHandler(this.btnSingUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(53, 319);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(725, 47);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForget
            // 
            this.btnForget.BackColor = System.Drawing.Color.Teal;
            this.btnForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForget.FlatAppearance.BorderSize = 0;
            this.btnForget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForget.ForeColor = System.Drawing.Color.White;
            this.btnForget.Location = new System.Drawing.Point(577, 212);
            this.btnForget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(201, 47);
            this.btnForget.TabIndex = 4;
            this.btnForget.Text = "Hatırlamıyorum";
            this.btnForget.UseVisualStyleBackColor = false;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // lblRefresh
            // 
            this.lblRefresh.BackColor = System.Drawing.Color.Transparent;
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lblRefresh.Image")));
            this.lblRefresh.Location = new System.Drawing.Point(581, 265);
            this.lblRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(23, 23);
            this.lblRefresh.TabIndex = 5;
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(835, 490);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.lblChapta);
            this.Controls.Add(this.txtChapta);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btnSingUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(853, 537);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(853, 537);
            this.Name = "Form1";
            this.Text = "Giriş Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChapta;
        private System.Windows.Forms.TextBox txtChapta;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnSingUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForget;
        private System.Windows.Forms.Label lblRefresh;


    }
}

