using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiverRaid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int skor = 0;
        byte yon = 0;
        Random rnd = new Random();
        DialogResult DRs = new DialogResult();
        string kontrol = string.Empty;
          
        private void Form1_Load(object sender, EventArgs e)
        {
           Size = new System.Drawing.Size(1024, 668);
           timer3.Start();
           timer2.Start();        
        }

        List<PictureBox> hedefList = new List<PictureBox>();
        List<PictureBox> ates = new List<PictureBox>();

        public void timer2_Tick(object sender, EventArgs e)
        {           
            imgEfekt.Top += 4;
            imgEfekt2.Top += 4;
            imgEfekt3.Top += 4;
            imgEfekt4.Top += 4;

            if (imgEfekt.Top >= 650 || imgEfekt2.Top >= 650)
            {
                imgEfekt.Top = 0;
                imgEfekt2.Top = 0;
            }

            if (imgEfekt3.Top >= 650 || imgEfekt4.Top >= 650)
            {
                imgEfekt3.Top = 0;
                imgEfekt4.Top = 0;
            }
        }

        public void NewPictureBoxGemi()
        {
            int yon = rnd.Next(248, 680);
            PictureBox pcBox = new PictureBox();
            pcBox.Name = "pcBoxGemi";
            pcBox.Size = new Size(80, 30);
            pcBox.Location = new Point(yon, -30);
            pcBox.BackgroundImage = Properties.Resources.gemi;
            pcBox.BackgroundImageLayout = ImageLayout.Stretch;
            hedefList.Add(pcBox);
            this.Controls.Add(pcBox);
        }

        public void NewPictureBoxHelikopter()
        {
            int yon = rnd.Next(248, 680);
            PictureBox pcBox = new PictureBox();
            pcBox.Name = "pcBoxHelikopter";
            pcBox.Size = new Size(80, 30);
            pcBox.Location = new Point(yon, -30);
            pcBox.BackgroundImage = Properties.Resources.helikopter;
            pcBox.BackgroundImageLayout = ImageLayout.Stretch;
            hedefList.Add(pcBox);
            this.Controls.Add(pcBox);        
        }

        private void timer3_Tick(object sender, EventArgs e)
        {           
            timer3.Interval = 1;
            int rndSayi = rnd.Next(1, 3);

            if(rndSayi == 1)
            {
                NewPictureBoxHelikopter();
            }
            else if(rndSayi == 2)
            {
                NewPictureBoxGemi();
            }      
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            hedefList[0].BringToFront();
            timer1.Interval = 10;
            hedefList[0].Top += 5;
            lblSkor.Text = "    PUAN = " + skor + "\nkordinat(uçak) = " + imgUcak.Left + "  " + "\nkordinat(hedef) = " + hedefList[0].Left + " ";           
            
            if(hedefList[0].Top == 530)
            {
                if (hedefList[0].Top == 530 && hedefList[0].Visible == true)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timer5.Stop();
                    DRs = MessageBox.Show("Puanınız : " + skor + "\n\nYeniden oynamak istermisiniz ?", "Oyun Bitti", MessageBoxButtons.YesNo);
                    if (DRs == DialogResult.Yes)
                    {
                        skor = 0;
                        yon = 0;
                        timer2.Start();
                    }
                    else if (DRs == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }

                hedefList[0].Visible = false;
                hedefList.Remove(hedefList[0]);
                timer1.Stop();
                timer3.Start();
            }
        }


        void Move()
        {
            switch (yon)
            {
                case 1:
                    if (imgUcak.Left > 260)
                        imgUcak.Left -= 15;
                    break;
                case 2:
                    if (imgUcak.Left < 710)
                    imgUcak.Left += 15;
                    break;

                default:
                    break;
            }
        }

        private void Form1_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                yon = 1;
                Move();
            }
            else if (e.KeyData == Keys.Right)
            {
                yon = 2;
                Move();
            }

            if (e.KeyData == Keys.Space)
            {
                if (timer4.Enabled==false)
                {
                    if (hedefList[0].Left - imgUcak.Left >= -45 && hedefList[0].Left - imgUcak.Left <= 0 && hedefList[0].Visible==true)
                    {
                        hedefList[0].Visible = false;
                        skor = skor + 1;
                    }
                    timer4.Start(); 
                }
            }
        }
       
        private void timer4_Tick(object sender, EventArgs e)
        {
            int yon = imgUcak.Left;
            PictureBox ates1 = new PictureBox();
            ates1.Name = "atess";
            ates1.Size = new Size(3, 40);
            ates1.Location = new Point(yon + 21, 500);
            ates1.BackgroundImage = Properties.Resources.ates;
            ates1.BackgroundImageLayout = ImageLayout.Stretch;
            ates.Add(ates1);
            ates[0].Visible = true;
            this.Controls.Add(ates1);
            ates[0].BringToFront();
            timer4.Stop();

            timer5.Start();            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            ates[0].Visible = false;
            ates.Remove(ates[0]);
            timer5.Stop();
        }

        private void imgUcak_Click(object sender, EventArgs e)
        {

        }

    }
}
