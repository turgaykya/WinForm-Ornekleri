namespace UI
{
    partial class AddReserveForm
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
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbTown = new System.Windows.Forms.ComboBox();
            this.cmbClinic = new System.Windows.Forms.ComboBox();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.cmbPoliclinic = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReserveSearch = new System.Windows.Forms.Button();
            this.grpReserveSearch = new System.Windows.Forms.GroupBox();
            this.dtpReserveDateTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnReserveSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDoctorReserveTime = new System.Windows.Forms.DateTimePicker();
            this.txtReserveTime = new System.Windows.Forms.TextBox();
            this.txtDoctorClinic = new System.Windows.Forms.TextBox();
            this.txtDoctorFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblReserveTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpReserveSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(133, 67);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(307, 29);
            this.cmbCity.TabIndex = 1;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // cmbTown
            // 
            this.cmbTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTown.FormattingEnabled = true;
            this.cmbTown.Location = new System.Drawing.Point(133, 109);
            this.cmbTown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTown.Name = "cmbTown";
            this.cmbTown.Size = new System.Drawing.Size(307, 29);
            this.cmbTown.TabIndex = 2;
            this.cmbTown.SelectedIndexChanged += new System.EventHandler(this.cmbTown_SelectedIndexChanged);
            // 
            // cmbClinic
            // 
            this.cmbClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClinic.FormattingEnabled = true;
            this.cmbClinic.Location = new System.Drawing.Point(133, 149);
            this.cmbClinic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClinic.Name = "cmbClinic";
            this.cmbClinic.Size = new System.Drawing.Size(307, 29);
            this.cmbClinic.TabIndex = 3;
            this.cmbClinic.SelectedIndexChanged += new System.EventHandler(this.cmbClinic_SelectedIndexChanged);
            // 
            // cmbHospital
            // 
            this.cmbHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Location = new System.Drawing.Point(133, 190);
            this.cmbHospital.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(307, 29);
            this.cmbHospital.TabIndex = 4;
            this.cmbHospital.SelectedIndexChanged += new System.EventHandler(this.cmbHospital_SelectedIndexChanged);
            // 
            // cmbPoliclinic
            // 
            this.cmbPoliclinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliclinic.FormattingEnabled = true;
            this.cmbPoliclinic.Location = new System.Drawing.Point(134, 230);
            this.cmbPoliclinic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPoliclinic.Name = "cmbPoliclinic";
            this.cmbPoliclinic.Size = new System.Drawing.Size(307, 29);
            this.cmbPoliclinic.TabIndex = 5;
            this.cmbPoliclinic.SelectedIndexChanged += new System.EventHandler(this.cmbPoliclinic_SelectedIndexChanged);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(133, 272);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(310, 29);
            this.cmbDoctor.TabIndex = 7;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(100, 460);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 49);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReserveSearch
            // 
            this.btnReserveSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReserveSearch.Location = new System.Drawing.Point(309, 460);
            this.btnReserveSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReserveSearch.Name = "btnReserveSearch";
            this.btnReserveSearch.Size = new System.Drawing.Size(201, 49);
            this.btnReserveSearch.TabIndex = 9;
            this.btnReserveSearch.Text = "Randevu Ara";
            this.btnReserveSearch.UseVisualStyleBackColor = true;
            this.btnReserveSearch.Click += new System.EventHandler(this.btnReserveSearch_Click);
            // 
            // grpReserveSearch
            // 
            this.grpReserveSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpReserveSearch.Controls.Add(this.dtpReserveDateTime);
            this.grpReserveSearch.Controls.Add(this.label13);
            this.grpReserveSearch.Controls.Add(this.label14);
            this.grpReserveSearch.Controls.Add(this.label12);
            this.grpReserveSearch.Controls.Add(this.label11);
            this.grpReserveSearch.Controls.Add(this.label10);
            this.grpReserveSearch.Controls.Add(this.label9);
            this.grpReserveSearch.Controls.Add(this.label8);
            this.grpReserveSearch.Controls.Add(this.cmbCity);
            this.grpReserveSearch.Controls.Add(this.cmbTown);
            this.grpReserveSearch.Controls.Add(this.cmbDoctor);
            this.grpReserveSearch.Controls.Add(this.cmbClinic);
            this.grpReserveSearch.Controls.Add(this.cmbHospital);
            this.grpReserveSearch.Controls.Add(this.cmbPoliclinic);
            this.grpReserveSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReserveSearch.Location = new System.Drawing.Point(13, 53);
            this.grpReserveSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReserveSearch.Name = "grpReserveSearch";
            this.grpReserveSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpReserveSearch.Size = new System.Drawing.Size(497, 399);
            this.grpReserveSearch.TabIndex = 10;
            this.grpReserveSearch.TabStop = false;
            this.grpReserveSearch.Text = "Randevu Ara";
            // 
            // dtpReserveDateTime
            // 
            this.dtpReserveDateTime.Location = new System.Drawing.Point(134, 317);
            this.dtpReserveDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpReserveDateTime.Name = "dtpReserveDateTime";
            this.dtpReserveDateTime.Size = new System.Drawing.Size(310, 29);
            this.dtpReserveDateTime.TabIndex = 17;
            this.dtpReserveDateTime.ValueChanged += new System.EventHandler(this.dtpReserveDateTime_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tarih : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 21);
            this.label14.TabIndex = 15;
            this.label14.Text = "Doktor : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Poliklinik :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Hastane :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Klinik : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "İlçe :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "İl : ";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(520, 51);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Size = new System.Drawing.Size(628, 401);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Randevu Saati";
            // 
            // btnReserveSave
            // 
            this.btnReserveSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReserveSave.Location = new System.Drawing.Point(949, 517);
            this.btnReserveSave.Name = "btnReserveSave";
            this.btnReserveSave.Size = new System.Drawing.Size(199, 49);
            this.btnReserveSave.TabIndex = 18;
            this.btnReserveSave.Text = "Randevu Kaydet";
            this.btnReserveSave.UseVisualStyleBackColor = true;
            this.btnReserveSave.Click += new System.EventHandler(this.btnReserveSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDoctorReserveTime);
            this.groupBox2.Controls.Add(this.txtReserveTime);
            this.groupBox2.Controls.Add(this.txtDoctorClinic);
            this.groupBox2.Controls.Add(this.txtDoctorFirstName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(13, 517);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 133);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçilen Doktorun En Yakın Randevu Tarihi";
            // 
            // dtpDoctorReserveTime
            // 
            this.dtpDoctorReserveTime.Enabled = false;
            this.dtpDoctorReserveTime.Location = new System.Drawing.Point(568, 83);
            this.dtpDoctorReserveTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDoctorReserveTime.Name = "dtpDoctorReserveTime";
            this.dtpDoctorReserveTime.Size = new System.Drawing.Size(153, 29);
            this.dtpDoctorReserveTime.TabIndex = 2;
            // 
            // txtReserveTime
            // 
            this.txtReserveTime.Enabled = false;
            this.txtReserveTime.Location = new System.Drawing.Point(752, 82);
            this.txtReserveTime.Name = "txtReserveTime";
            this.txtReserveTime.Size = new System.Drawing.Size(123, 29);
            this.txtReserveTime.TabIndex = 1;
            // 
            // txtDoctorClinic
            // 
            this.txtDoctorClinic.Enabled = false;
            this.txtDoctorClinic.Location = new System.Drawing.Point(380, 82);
            this.txtDoctorClinic.Name = "txtDoctorClinic";
            this.txtDoctorClinic.Size = new System.Drawing.Size(154, 29);
            this.txtDoctorClinic.TabIndex = 1;
            // 
            // txtDoctorFirstName
            // 
            this.txtDoctorFirstName.Enabled = false;
            this.txtDoctorFirstName.Location = new System.Drawing.Point(109, 84);
            this.txtDoctorFirstName.Name = "txtDoctorFirstName";
            this.txtDoctorFirstName.Size = new System.Drawing.Size(252, 29);
            this.txtDoctorFirstName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Randevu Saati : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Randevu Tarihi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bölümü : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doktorun :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı ve Soyadı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(644, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hoşgeldiniz : ";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(751, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(226, 25);
            this.lblUserName.TabIndex = 20;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfile.Location = new System.Drawing.Point(1001, 11);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(147, 35);
            this.btnProfile.TabIndex = 21;
            this.btnProfile.Text = "Profile Git >>";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.IndianRed;
            this.label15.Location = new System.Drawing.Point(6, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(431, 37);
            this.label15.TabIndex = 22;
            this.label15.Text = "Merkezi Hastane Randevu Sistemi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(526, 460);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Seçilen Randevu Saati : ";
            // 
            // lblReserveTime
            // 
            this.lblReserveTime.AutoSize = true;
            this.lblReserveTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReserveTime.Location = new System.Drawing.Point(712, 460);
            this.lblReserveTime.Name = "lblReserveTime";
            this.lblReserveTime.Size = new System.Drawing.Size(0, 20);
            this.lblReserveTime.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(949, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 49);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1164, 666);
            this.Controls.Add(this.lblReserveTime);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReserveSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.grpReserveSearch);
            this.Controls.Add(this.btnReserveSearch);
            this.Controls.Add(this.btnClear);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 704);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1180, 704);
            this.Name = "AddReserveForm";
            this.Text = "Randevu Kayıt Formu";
            this.Load += new System.EventHandler(this.AddReserveForm_Load);
            this.grpReserveSearch.ResumeLayout(false);
            this.grpReserveSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbTown;
        private System.Windows.Forms.ComboBox cmbClinic;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.ComboBox cmbPoliclinic;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReserveSearch;
        private System.Windows.Forms.GroupBox grpReserveSearch;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReserveTime;
        private System.Windows.Forms.TextBox txtDoctorClinic;
        private System.Windows.Forms.TextBox txtDoctorFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpReserveDateTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnReserveSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblReserveTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpDoctorReserveTime;
    }
}