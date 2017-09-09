namespace Iskambil
{
    partial class Game
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
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer4 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnPlayer3 = new System.Windows.Forms.Button();
            this.btnDeckDeal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.Location = new System.Drawing.Point(184, 94);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(396, 23);
            this.btnPlayer1.TabIndex = 0;
            this.btnPlayer1.Text = "button1";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            this.btnPlayer1.Click += new System.EventHandler(this.DesteGöster_Click);
            // 
            // btnPlayer4
            // 
            this.btnPlayer4.Location = new System.Drawing.Point(104, 169);
            this.btnPlayer4.Name = "btnPlayer4";
            this.btnPlayer4.Size = new System.Drawing.Size(18, 278);
            this.btnPlayer4.TabIndex = 0;
            this.btnPlayer4.Text = "button1";
            this.btnPlayer4.UseVisualStyleBackColor = true;
            this.btnPlayer4.Click += new System.EventHandler(this.DesteGöster_Click);
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.Location = new System.Drawing.Point(643, 169);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(18, 278);
            this.btnPlayer2.TabIndex = 0;
            this.btnPlayer2.Text = "button1";
            this.btnPlayer2.UseVisualStyleBackColor = true;
            this.btnPlayer2.Click += new System.EventHandler(this.DesteGöster_Click);
            // 
            // btnPlayer3
            // 
            this.btnPlayer3.Location = new System.Drawing.Point(184, 488);
            this.btnPlayer3.Name = "btnPlayer3";
            this.btnPlayer3.Size = new System.Drawing.Size(396, 23);
            this.btnPlayer3.TabIndex = 0;
            this.btnPlayer3.Text = "button1";
            this.btnPlayer3.UseVisualStyleBackColor = true;
            this.btnPlayer3.Click += new System.EventHandler(this.DesteGöster_Click);
            // 
            // btnDeckDeal
            // 
            this.btnDeckDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeckDeal.Location = new System.Drawing.Point(345, 263);
            this.btnDeckDeal.Name = "btnDeckDeal";
            this.btnDeckDeal.Size = new System.Drawing.Size(85, 88);
            this.btnDeckDeal.TabIndex = 1;
            this.btnDeckDeal.Text = "Deste\r\nDağıt";
            this.btnDeckDeal.UseVisualStyleBackColor = true;
            this.btnDeckDeal.Click += new System.EventHandler(this.btnDeckDeal_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(127, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 42);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(127, 539);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 42);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(30, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(42, 390);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(701, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(42, 390);
            this.panel4.TabIndex = 2;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(766, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeckDeal);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer4);
            this.Controls.Add(this.btnPlayer3);
            this.Controls.Add(this.btnPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeckDeal;
        public System.Windows.Forms.Button btnPlayer1;
        public System.Windows.Forms.Button btnPlayer4;
        public System.Windows.Forms.Button btnPlayer2;
        public System.Windows.Forms.Button btnPlayer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}