using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTimeKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*for (int i = 0; i < length; i++)
			{
			 Önce başlangıç noktası; sonrasında bitiş koşulu; indisin bu aralıkta nasıl hareket edeceği
			}
        */
        int i, j = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    
                    Button btn = new Button();
                    btn.Name = "btn" + i + j;
                    btn.Text = "Button" + i + " , " + j;
                    btn.Size = new Size(80,60);
                    btn.Location = new Point(i*80, j*60);
                    btn.Click += YeniOlusturulanButonunKlikOlayi;
                    panel1.Controls.Add(btn);
                }
            }
        }
        void YeniOlusturulanButonunKlikOlayi(object sender, EventArgs e)
        {
            Button tiklananButonNesnesi = sender as Button;
            //Button tiklananButonNesnesi1 = (Button)sender;
            tiklananButonNesnesi.BackColor = Color.Red;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void btnRenkReset_Click(object sender, EventArgs e)
        {
            //Button denek = panel1.Controls[0] as Button;
            //denek.BackColor = Color.Blue;     // Tekli versiyon

            for (int k = 0; k <= ((i) * (j)); k++)
            {
                if (panel1.Controls[k] is Button)
                {
                    panel1.Controls[k].BackColor = Color.Salmon;

                }
            }
            
        }
    }
}
