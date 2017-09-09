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
    public partial class GameStart : Form
    {
        public GameStart()
        {
            InitializeComponent();
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            Game oyun = new Game();
            oyun.btnPlayer1.Text = txtPlayer1.Text;
            oyun.btnPlayer2.Text = txtPlayer2.Text;
            oyun.btnPlayer3.Text = txtPlayer3.Text;
            oyun.btnPlayer4.Text = txtPlayer4.Text;
            oyun.Show();
            this.Hide();

        }
    }
}
