using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DialogResult kontrol = new DialogResult();
        Random r = new Random();
        int o1Sayac = 0;
        int o2Sayac = 0;
        
        private void btnOyuncu1_Click(object sender, EventArgs e)
        {
            switch (r.Next(1, 4))
            {
                case 1: lblOyuncu1.Text = ("TAŞ");
                    picTas1.Visible = true;
                    break;
                case 2: lblOyuncu1.Text = ("KAĞIT");
                    picKagit1.Visible = true;
                    break;
                case 3: lblOyuncu1.Text = ("MAKAS");
                    picMakas1.Visible = true;
                    break;
                default: MessageBox.Show("Birşeyler Ters Gitti..");
                    break;
            }
            btnOyuncu2.Enabled = true;
            btnOyuncu1.Enabled = false;
            btnYenile.Enabled = false;
            lblO2Bekleme.Text = "Oyuncu2\nbekleniyor...";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = "Sonuc Bekleniyor...";
            btnOyuncu2.Enabled = false;
            btnYenile.Enabled = false;
            lblOyuncu1.Visible = false;
            lblOyuncu2.Visible = false;
            picTas1.Visible = false;
            picTas2.Visible = false;
            picKagit1.Visible = false;
            picKagit2.Visible = false;
            picMakas1.Visible = false;
            picMakas2.Visible = false;


        }

        private void btnOyuncu2_Click(object sender, EventArgs e)
        {
            switch (r.Next(1, 4))
            {
                case 1: lblOyuncu2.Text = ("TAŞ");
                    picTas2.Visible = true;
                    break;
                case 2: lblOyuncu2.Text = ("KAĞIT");
                    picKagit2.Visible = true;
                    break;
                case 3: lblOyuncu2.Text = ("MAKAS");
                    picMakas2.Visible = true;
                    break;
                default: MessageBox.Show("Birşeyler Ters Gitti..");
                    break;
            }
            if (o1Sayac < 3 && o2Sayac < 3)
            {
                if (lblOyuncu1.Text == "TAŞ" && lblOyuncu2.Text == "KAĞIT")
                {
                    lblSonuc.Text = "Oyuncu2 sayı aldı.";
                    o2Sayac++;
                }
                else if (lblOyuncu2.Text == "TAŞ" && lblOyuncu1.Text == "KAĞIT")
                {
                    lblSonuc.Text = "Oyuncu1 sayı aldı.";
                    o1Sayac++;
                }
                else if (lblOyuncu1.Text == "TAŞ" && lblOyuncu2.Text == "MAKAS")
                {
                    lblSonuc.Text = "Oyuncu1 sayı aldı.";
                    o1Sayac++;
                }
                else if (lblOyuncu2.Text == "TAŞ" && lblOyuncu1.Text == "MAKAS")
                {
                    lblSonuc.Text = "Oyuncu2 sayı aldı.";
                    o2Sayac++;
                }
                else if (lblOyuncu1.Text == "KAĞIT" && lblOyuncu2.Text == "MAKAS")
                {
                    lblSonuc.Text = "Oyuncu2 sayı aldı.";
                    o2Sayac++;
                }
                else if (lblOyuncu2.Text == "KAĞIT" && lblOyuncu1.Text == "MAKAS")
                {
                    lblSonuc.Text = "Oyuncu1 sayı aldı.";
                    o1Sayac++;
                }
                else
                {
                    lblSonuc.Text = "Berbere";
                }
                lblO2Bekleme.Text = "";
                btnOyuncu2.Enabled = false;

                lblSkor1.Text = o1Sayac.ToString();
                lblSkor2.Text = o2Sayac.ToString();
            }
            btnYenile.Enabled = true;
            

            if (o1Sayac == 3)
            {


                kontrol = MessageBox.Show("Oyuncu1 Kazandı...\nTekrar oynamak istermisiniz?", "Sonuc", MessageBoxButtons.YesNo);
                if (kontrol == DialogResult.Yes)
                {
                    this.Show();
                    btnOyuncu2.Enabled = false;
                    btnYenile.Enabled = false;
                    lblOyuncu1.Visible = false;
                    lblOyuncu2.Visible = false;
                    picTas1.Visible = false;
                    picTas2.Visible = false;
                    picKagit1.Visible = false;
                    picKagit2.Visible = false;
                    picMakas1.Visible = false;
                    picMakas2.Visible = false;
                    o1Sayac = 0;
                    o2Sayac = 0;
                    btnOyuncu1.Enabled = true;
                    btnOyuncu2.Enabled = false;
                    btnYenile.Enabled = false;
                    lblSkor1.Text = "0";
                    lblSkor2.Text = "0";

                    
                }
                else if (kontrol == DialogResult.No)
                {
                    Application.Exit();
                }
                btnYenile.Enabled = false;
                
                
                

            }
            else if (o2Sayac == 3)
            {
                kontrol = MessageBox.Show("Oyuncu2 Kazandı...\nTekrar oynamak istermisiniz?", "Sonuc", MessageBoxButtons.YesNo);
                if (kontrol == DialogResult.Yes)
                {
                    this.Show();
                    btnOyuncu2.Enabled = false;
                    btnYenile.Enabled = false;
                    lblOyuncu1.Visible = false;
                    lblOyuncu2.Visible = false;
                    picTas1.Visible = false;
                    picTas2.Visible = false;
                    picKagit1.Visible = false;
                    picKagit2.Visible = false;
                    picMakas1.Visible = false;
                    picMakas2.Visible = false;
                    o1Sayac = 0;
                    o2Sayac = 0;
                    btnOyuncu1.Enabled = true;
                    btnOyuncu2.Enabled = false;
                    btnYenile.Enabled = false;
                    lblSkor1.Text = "0";
                    lblSkor2.Text = "0";
                }
                else if (kontrol == DialogResult.No)
                {
                    Application.Exit();
                }


                btnYenile.Enabled = false;
                

            }

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            picTas1.Visible = false;
            picTas2.Visible = false;
            picKagit1.Visible = false;
            picKagit2.Visible = false;
            picMakas1.Visible = false;
            picMakas2.Visible = false;
            btnOyuncu1.Enabled = true;
            btnOyuncu2.Enabled = false;
            btnYenile.Enabled = false;
            lblOyuncu1.Text = "(   )";
            lblOyuncu2.Text = "      (   )";
            lblSonuc.Text = "Sonuc Bekleniyor...";
           

        }
    }
}
