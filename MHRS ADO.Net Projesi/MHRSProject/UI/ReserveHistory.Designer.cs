namespace UI
{
    partial class ReserveHistory
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReserveCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstReserveHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReserveCancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 58);
            // 
            // ReserveCancelToolStripMenuItem
            // 
            this.ReserveCancelToolStripMenuItem.Name = "ReserveCancelToolStripMenuItem";
            this.ReserveCancelToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.ReserveCancelToolStripMenuItem.Text = "RANDEVU İPTAL";
            this.ReserveCancelToolStripMenuItem.Click += new System.EventHandler(this.ReserveCancelToolStripMenuItem_Click);
            // 
            // lstReserveHistory
            // 
            this.lstReserveHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.a,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstReserveHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.lstReserveHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstReserveHistory.FullRowSelect = true;
            this.lstReserveHistory.Location = new System.Drawing.Point(16, 89);
            this.lstReserveHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstReserveHistory.Name = "lstReserveHistory";
            this.lstReserveHistory.Size = new System.Drawing.Size(1193, 404);
            this.lstReserveHistory.TabIndex = 1;
            this.lstReserveHistory.UseCompatibleStateImageBehavior = false;
            this.lstReserveHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hastane Adı";
            this.columnHeader1.Width = 133;
            // 
            // a
            // 
            this.a.Text = "Doktor Adı";
            this.a.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Klinik";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Polikilinik";
            this.columnHeader3.Width = 149;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Randevu Tarihi";
            this.columnHeader4.Width = 117;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Randevu Zamanı";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Randevu Durumu";
            this.columnHeader6.Width = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Randevu Geçmişiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(105, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Aktif randevularınızı sağ tuş iptal et seçeneğine tıklayarak iptal edebilirsiniz." +
    "";
            // 
            // btnGetProfile
            // 
            this.btnGetProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetProfile.Location = new System.Drawing.Point(1043, 28);
            this.btnGetProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetProfile.Name = "btnGetProfile";
            this.btnGetProfile.Size = new System.Drawing.Size(168, 47);
            this.btnGetProfile.TabIndex = 23;
            this.btnGetProfile.Text = "<< Profile Git";
            this.btnGetProfile.UseVisualStyleBackColor = true;
            this.btnGetProfile.Click += new System.EventHandler(this.btnGetProfile_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "►";
            // 
            // ReserveHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstReserveHistory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1245, 541);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1245, 541);
            this.Name = "ReserveHistory";
            this.Text = "Randevu Geçmişi";
            this.Load += new System.EventHandler(this.ReserveHistory_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView lstReserveHistory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader a;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetProfile;
        private System.Windows.Forms.ToolStripMenuItem ReserveCancelToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}