using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DialogResult kontrol = new DialogResult();

        int skor = 0;
        int kalanSure = 60;
        int kackere = 0;
        int yan;
        private void Form1_Load(object sender, EventArgs e)
        {
            disabler();
        }
        public void tumrenkler() {
            btn1.BackColor = Color.Black;
            btn2.BackColor = Color.Black;
            btn3.BackColor = Color.Black;
            btn4.BackColor = Color.Black;
            btn5.BackColor = Color.Black;
            btn6.BackColor = Color.Black;
            btn7.BackColor = Color.Black;
            btn8.BackColor = Color.Black;
            btn9.BackColor = Color.Black;
            btn10.BackColor = Color.Black;
            btn11.BackColor = Color.Black;
            btn12.BackColor = Color.Black;
            btn13.BackColor = Color.Black;
            btn14.BackColor = Color.Black;
            btn15.BackColor = Color.Black;
            btn16.BackColor = Color.Black;
            btn17.BackColor = Color.Black;
            btn18.BackColor = Color.Black;
            btn19.BackColor = Color.Black;
            btn20.BackColor = Color.Black;
            btn21.BackColor = Color.Black;
            btn22.BackColor = Color.Black;
            btn23.BackColor = Color.Black;
            btn24.BackColor = Color.Black;
            btn25.BackColor = Color.Black;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "BAŞLAT")
            {
                    sayac.Enabled = true;
                    toplamSure.Enabled = true;
                    saniyeSayar.Enabled = true;
                    button1.Text = "DUR!";
                    enabler();

            }
            else if (button1.Text == "DUR!") {
                toplamSure.Interval = Convert.ToInt16(kalan_sure_label.Text) * 1000;
                saniyeSayar.Enabled = false;
                toplamSure.Enabled = false;
                sayac.Enabled = false;
                button1.Text = "BAŞLAT";
                disabler();
            }
        }

        private void sayac_Tick(object sender, EventArgs e)
        {
            toplamSure.Interval = 60000;
            enabler();    
            tumrenkler();

         

            

            Random rnd = new Random();
            
              
             yan = rnd.Next(1,26);
            

            switch (yan)
            {
                    
                case 1:
                    btn1.BackColor = Color.White;
                    break;
                case 2:
                    btn2.BackColor = Color.White;
                    break;
                case 3:
                    btn3.BackColor = Color.White;
                    break;
                case 4:
                    btn4.BackColor = Color.White;
                    break;
                case 5:
                    btn5.BackColor = Color.White;
                    break;
                case 6:
                    btn6.BackColor = Color.White;
                    break;
                case 7:
                    btn7.BackColor = Color.White;
                    break;
                case 8:
                    btn8.BackColor = Color.White;
                    break;
                case 9:
                    btn9.BackColor = Color.White;
                    break;
                case 10:
                    btn10.BackColor = Color.White;
                    break;
                case 11:
                    btn11.BackColor = Color.White;
                    break;
                case 12:
                    btn12.BackColor = Color.White;
                    break;
                case 13:
                    btn13.BackColor = Color.White;
                    break;
                case 14:
                    btn14.BackColor = Color.White;
                    break;
                case 15:
                    btn15.BackColor = Color.White;
                    break;
                case 16:
                    btn16.BackColor = Color.White;
                    break;
                case 17:
                    btn17.BackColor = Color.White;
                    break;
                case 18:
                    btn18.BackColor = Color.White;
                    break;
                case 19:
                    btn19.BackColor = Color.White;
                    break;
                case 20:
                    btn20.BackColor = Color.White;
                    break;
                case 21:
                    btn21.BackColor = Color.White;
                    break;
                case 22:
                    btn22.BackColor = Color.White;
                    break;
                case 23:
                    btn23.BackColor = Color.White;
                    break;
                case 24:
                    btn24.BackColor = Color.White;
                    break;
                case 25:
                    btn25.BackColor = Color.White;
                    break;

            }
            int hatalar = kackere - skor;
            hata_label.Text ="HATA : "+ hatalar.ToString();
            skor_label.Text = "SKOR : " + skor;
            kackere++;

        }
        public void disabler()
        {

            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn13.Enabled = false;
            btn14.Enabled = false;
            btn15.Enabled = false;
            btn16.Enabled = false;
            btn17.Enabled = false;
            btn18.Enabled = false;
            btn19.Enabled = false;
            btn20.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
            btn23.Enabled = false;
            btn24.Enabled = false;
            btn25.Enabled = false;
        }
        public void enabler() {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn14.Enabled = true;
            btn15.Enabled = true;
            btn16.Enabled = true;
            btn17.Enabled = true;
            btn18.Enabled = true;
            btn19.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn24.Enabled = true;
            btn25.Enabled = true;

        }

        private void toplamSure_Tick(object sender, EventArgs e)
        {
            kalan_sure_label.Text = Convert.ToString(toplamSure.Interval / 1000);

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            
            string yanan=Convert.ToString(yan);
            disabler();

            if (yanan=="1")
            {
                btn1.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "1")
            {
                btn1.BackColor = Color.Red;

            }
            
        }
     
        private void btn2_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "2")
            {
                btn2.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "2")
            {
                btn2.BackColor = Color.Red;

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "3")
            {
                btn3.BackColor = Color.Green;
                skor = skor + 1;               
            }
            if (yanan != "3")
            {
                btn3.BackColor = Color.Red;

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "4")
            {
                btn4.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "4")
            {
                btn4.BackColor = Color.Red;

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "5")
            {
                btn5.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "5")
            {
                btn5.BackColor = Color.Red;

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "6")
            {
                btn6.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "6")
            {
                btn6.BackColor = Color.Red;

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "7")
            {
                btn7.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "7")
            {
                btn7.BackColor = Color.Red;

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "8")
            {
                btn8.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "8")
            {
                btn8.BackColor = Color.Red;

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "9")
            {
                btn9.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "9")
            {
                btn9.BackColor = Color.Red;

            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "10")
            {
                btn10.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "10")
            {
                btn10.BackColor = Color.Red;

            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "11")
            {
                btn11.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "11")
            {
                btn11.BackColor = Color.Red;

            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "12")
                btn12.BackColor = Color.Green;            {
                skor = skor + 1;
            }
            if (yanan != "12")
            {
                btn12.BackColor = Color.Red;

            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "13")
            {
                btn13.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "13")
            {
                btn13.BackColor = Color.Red;

            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "14")
            {
                btn14.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "14")
            {
                btn14.BackColor = Color.Red;

            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "15")
            {
                btn15.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "15")
            {
                btn15.BackColor = Color.Red;

            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "16")
            {
                btn16.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "16")
            {
                btn16.BackColor = Color.Red;

            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "17")
            {
                btn17.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "17")
            {
                btn17.BackColor = Color.Red;

            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "18")
            {
                btn18.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "18")
            {
                btn18.BackColor = Color.Red;

            }
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "19")
            {
                btn19.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "19")
            {
                btn19.BackColor = Color.Red;

            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "20")
            {
                btn20.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "20")
            {
                btn20.BackColor = Color.Red;

            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "21")
            {
                btn21.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "21")
            {
                btn21.BackColor = Color.Red;

            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "22")
            {
                btn22.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "22")
            {
                btn22.BackColor = Color.Red;

            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);
            disabler();

            if (yanan == "23")
            {
                btn23.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "23")
            {
                btn23.BackColor = Color.Red;

            }
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);

            disabler();
            if (yanan == "24")
            {
                btn24.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "24")
            {
                btn24.BackColor = Color.Red;

            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            string yanan = Convert.ToString(yan);

            disabler();
            if (yanan == "25")
            {
                btn25.BackColor = Color.Green;
                skor = skor + 1;
            }
            if (yanan != "25")
            {
                btn25.BackColor = Color.Red;

            }
        }

        private void saniyeSayar_Tick(object sender, EventArgs e)
        {
            kalanSure = kalanSure - 1;
            kalan_sure_label.Text = kalanSure.ToString();
            if (kalanSure == 0)
            {
                toplamSure.Enabled = false;
                sayac.Enabled = false;
                saniyeSayar.Enabled = false;
                button1.Text = "BAŞLAT";
                
                kontrol = MessageBox.Show("Skorunuz : " + skor + "\n Tekrar oynamak istermisiniz?","Sonuc",MessageBoxButtons.YesNo);
                if (kontrol == DialogResult.Yes)
                {
                    this.Show();
                    skor = 0;
                    kalanSure = 60;
                    kackere = 0;
                    yan = 0;
                    disabler();
                }
                else if (kontrol == DialogResult.No)
                {
                    Application.Exit();
                }
                 
                }
                

            }
        }

       
    }

