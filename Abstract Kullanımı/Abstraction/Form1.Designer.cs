namespace Abstraction
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
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.lblCarSound = new System.Windows.Forms.Label();
            this.btnStartCar = new System.Windows.Forms.Button();
            this.btnCreateTruck = new System.Windows.Forms.Button();
            this.lblTruckDetails = new System.Windows.Forms.Label();
            this.lblTruckSound = new System.Windows.Forms.Label();
            this.btnStartTruck = new System.Windows.Forms.Button();
            this.lblCarHorn = new System.Windows.Forms.Label();
            this.btnCarHorn = new System.Windows.Forms.Button();
            this.lblTruckHorn = new System.Windows.Forms.Label();
            this.btnTruckHorn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(67, 33);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(138, 23);
            this.btnCreateCar.TabIndex = 0;
            this.btnCreateCar.Text = "Araba Oluştur";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarDetails.Location = new System.Drawing.Point(67, 59);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(138, 149);
            this.lblCarDetails.TabIndex = 1;
            // 
            // lblCarSound
            // 
            this.lblCarSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarSound.Location = new System.Drawing.Point(67, 246);
            this.lblCarSound.Name = "lblCarSound";
            this.lblCarSound.Size = new System.Drawing.Size(138, 23);
            this.lblCarSound.TabIndex = 2;
            // 
            // btnStartCar
            // 
            this.btnStartCar.Location = new System.Drawing.Point(67, 220);
            this.btnStartCar.Name = "btnStartCar";
            this.btnStartCar.Size = new System.Drawing.Size(138, 23);
            this.btnStartCar.TabIndex = 3;
            this.btnStartCar.Text = "Arabayı Çalıştır";
            this.btnStartCar.UseVisualStyleBackColor = true;
            this.btnStartCar.Click += new System.EventHandler(this.btnStartCar_Click);
            // 
            // btnCreateTruck
            // 
            this.btnCreateTruck.Location = new System.Drawing.Point(267, 33);
            this.btnCreateTruck.Name = "btnCreateTruck";
            this.btnCreateTruck.Size = new System.Drawing.Size(138, 23);
            this.btnCreateTruck.TabIndex = 0;
            this.btnCreateTruck.Text = "Kamyon Oluştur";
            this.btnCreateTruck.UseVisualStyleBackColor = true;
            this.btnCreateTruck.Click += new System.EventHandler(this.btnCreateTruck_Click);
            // 
            // lblTruckDetails
            // 
            this.lblTruckDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTruckDetails.Location = new System.Drawing.Point(267, 59);
            this.lblTruckDetails.Name = "lblTruckDetails";
            this.lblTruckDetails.Size = new System.Drawing.Size(138, 149);
            this.lblTruckDetails.TabIndex = 1;
            // 
            // lblTruckSound
            // 
            this.lblTruckSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTruckSound.Location = new System.Drawing.Point(267, 246);
            this.lblTruckSound.Name = "lblTruckSound";
            this.lblTruckSound.Size = new System.Drawing.Size(138, 23);
            this.lblTruckSound.TabIndex = 2;
            // 
            // btnStartTruck
            // 
            this.btnStartTruck.Location = new System.Drawing.Point(267, 220);
            this.btnStartTruck.Name = "btnStartTruck";
            this.btnStartTruck.Size = new System.Drawing.Size(138, 23);
            this.btnStartTruck.TabIndex = 3;
            this.btnStartTruck.Text = "Kamyonu Çalıştır";
            this.btnStartTruck.UseVisualStyleBackColor = true;
            this.btnStartTruck.Click += new System.EventHandler(this.btnStartTruck_Click);
            // 
            // lblCarHorn
            // 
            this.lblCarHorn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarHorn.Location = new System.Drawing.Point(67, 318);
            this.lblCarHorn.Name = "lblCarHorn";
            this.lblCarHorn.Size = new System.Drawing.Size(138, 23);
            this.lblCarHorn.TabIndex = 2;
            // 
            // btnCarHorn
            // 
            this.btnCarHorn.Location = new System.Drawing.Point(67, 292);
            this.btnCarHorn.Name = "btnCarHorn";
            this.btnCarHorn.Size = new System.Drawing.Size(138, 23);
            this.btnCarHorn.TabIndex = 3;
            this.btnCarHorn.Text = "Korna Çal";
            this.btnCarHorn.UseVisualStyleBackColor = true;
            this.btnCarHorn.Click += new System.EventHandler(this.btnCarHorn_Click);
            // 
            // lblTruckHorn
            // 
            this.lblTruckHorn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTruckHorn.Location = new System.Drawing.Point(267, 318);
            this.lblTruckHorn.Name = "lblTruckHorn";
            this.lblTruckHorn.Size = new System.Drawing.Size(138, 23);
            this.lblTruckHorn.TabIndex = 2;
            // 
            // btnTruckHorn
            // 
            this.btnTruckHorn.Location = new System.Drawing.Point(267, 292);
            this.btnTruckHorn.Name = "btnTruckHorn";
            this.btnTruckHorn.Size = new System.Drawing.Size(138, 23);
            this.btnTruckHorn.TabIndex = 3;
            this.btnTruckHorn.Text = "Korna Çal";
            this.btnTruckHorn.UseVisualStyleBackColor = true;
            this.btnTruckHorn.Click += new System.EventHandler(this.btnTruckHorn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 383);
            this.Controls.Add(this.btnStartTruck);
            this.Controls.Add(this.btnTruckHorn);
            this.Controls.Add(this.btnCarHorn);
            this.Controls.Add(this.lblTruckHorn);
            this.Controls.Add(this.btnStartCar);
            this.Controls.Add(this.lblCarHorn);
            this.Controls.Add(this.lblTruckSound);
            this.Controls.Add(this.lblCarSound);
            this.Controls.Add(this.lblTruckDetails);
            this.Controls.Add(this.lblCarDetails);
            this.Controls.Add(this.btnCreateTruck);
            this.Controls.Add(this.btnCreateCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Label lblCarDetails;
        private System.Windows.Forms.Label lblCarSound;
        private System.Windows.Forms.Button btnStartCar;
        private System.Windows.Forms.Button btnCreateTruck;
        private System.Windows.Forms.Label lblTruckDetails;
        private System.Windows.Forms.Label lblTruckSound;
        private System.Windows.Forms.Button btnStartTruck;
        private System.Windows.Forms.Label lblCarHorn;
        private System.Windows.Forms.Button btnCarHorn;
        private System.Windows.Forms.Label lblTruckHorn;
        private System.Windows.Forms.Button btnTruckHorn;
    }
}

