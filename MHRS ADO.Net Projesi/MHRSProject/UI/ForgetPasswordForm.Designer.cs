namespace UI
{
    partial class ForgetPasswordForm
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
            this.btnSendControl = new System.Windows.Forms.Button();
            this.lblPasswordStatus = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendControl
            // 
            this.btnSendControl.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSendControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendControl.ForeColor = System.Drawing.Color.DimGray;
            this.btnSendControl.Location = new System.Drawing.Point(170, 72);
            this.btnSendControl.Name = "btnSendControl";
            this.btnSendControl.Size = new System.Drawing.Size(164, 31);
            this.btnSendControl.TabIndex = 2;
            this.btnSendControl.Text = "Gönder";
            this.btnSendControl.UseVisualStyleBackColor = false;
            this.btnSendControl.Click += new System.EventHandler(this.btnSendEposta_Click);
            // 
            // lblPasswordStatus
            // 
            this.lblPasswordStatus.AutoSize = true;
            this.lblPasswordStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblPasswordStatus.Location = new System.Drawing.Point(12, 9);
            this.lblPasswordStatus.Name = "lblPasswordStatus";
            this.lblPasswordStatus.Size = new System.Drawing.Size(168, 17);
            this.lblPasswordStatus.TabIndex = 5;
            this.lblPasswordStatus.Text = "TC Kimlik Numaranızı Girin";
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTC.Location = new System.Drawing.Point(15, 29);
            this.txtTC.Multiline = true;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(319, 37);
            this.txtTC.TabIndex = 1;
            this.txtTC.Enter += new System.EventHandler(this.txtEposta_Enter);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(346, 113);
            this.Controls.Add(this.btnSendControl);
            this.Controls.Add(this.lblPasswordStatus);
            this.Controls.Add(this.txtTC);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(362, 151);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 151);
            this.Name = "ForgetPasswordForm";
            this.Text = "ForgetPasswordForm";
            this.Load += new System.EventHandler(this.ForgetPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendControl;
        private System.Windows.Forms.Label lblPasswordStatus;
        private System.Windows.Forms.TextBox txtTC;
    }
}