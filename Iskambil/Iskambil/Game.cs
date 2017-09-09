using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskambil
{
    public partial class Game : Form
    {
        Form frm;
        List<string> deck = new List<string>();
        List<string> player1 = new List<string>();
        List<string> player2 = new List<string>();
        List<string> player3 = new List<string>();
        List<string> player4 = new List<string>();
        Random rnd = new Random();
        public Game()
        {
            InitializeComponent();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDeckDeal_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 52; i++)
            {
                deck.Add((i+1).ToString());
            }
            DesteKaristir();
            DesteDagit();
        }

        private void DesteDagit()
        {
            for (int i = 0; i < 13; i++)
            {
                PictureBox pBox = new PictureBox();
                pBox.Name = "p1" + i;
                pBox.Size = new Size(30, 42);
                pBox.Location = new Point(i * 40, 0);
                pBox.BackColor = Control.DefaultBackColor;
                panel1.Controls.Add(pBox);
                PictureBox pBox2 = new PictureBox();
                pBox2.Name = "p2" + i;
                pBox2.Size = new Size(30, 42);
                pBox2.Location = new Point(i * 40, 0);
                pBox2.BackColor = Control.DefaultBackColor;
                panel2.Controls.Add(pBox2);
            }
            for (int i = 0; i < 13; i++)
            {
                PictureBox pBox = new PictureBox();
                pBox.Name = "p3" + i;
                pBox.Size = new Size(42, 25);
                pBox.Location = new Point(0, i * 30);
                pBox.BackColor = Control.DefaultBackColor;
                panel3.Controls.Add(pBox);
                PictureBox pBox2 = new PictureBox();
                pBox2.Name = "p4" + i;
                pBox2.Size = new Size(42, 25);
                pBox2.Location = new Point(0, i * 30);
                pBox2.BackColor = Control.DefaultBackColor;
                panel4.Controls.Add(pBox2);
            }
        }

        private void DesteKaristir()
        {
            for (int i = 0; i < 13; i++)
            {
                int index = rnd.Next(0, deck.Count);
                player1.Add(deck[index]);
                deck.RemoveAt(index);
                index = rnd.Next(0, deck.Count);
                player2.Add(deck[index]);
                deck.RemoveAt(index);
                index = rnd.Next(0, deck.Count);
                player3.Add(deck[index]);
                deck.RemoveAt(index);
                index = rnd.Next(0, deck.Count);
                player4.Add(deck[index]);
                deck.RemoveAt(index);
            }

        }

        private void DesteGöster_Click(object sender, EventArgs e)
        {
            frm = new Form();
            frm.Name = "AcilanDetse";
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Size = new Size(800, 120);
            frm.Show();
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnPlayer1":
                    AcilanDeste(player1);
                    break;
                case "btnPlayer2":
                    AcilanDeste(player2);
                    break;
                case "btnPlayer3":
                    AcilanDeste(player3);
                    break;
                case "btnPlayer4":
                    AcilanDeste(player4);
                    break;  
            }
        }

        private void AcilanDeste(List<string> player)
        {
            for (int i = 0; i < player.Count; i++)
            {
                PictureBox pBox = new PictureBox();
                pBox.Size = new Size(60,84);
                pBox.Location = new Point(i *60, 0);
                pBox.Name = "Kagit" + i;
                pBox.ImageLocation="deste/"+player[i]+".png";
                pBox.SizeMode = PictureBoxSizeMode.StretchImage;
                frm.Controls.Add(pBox);
            }
        }
    }
}
