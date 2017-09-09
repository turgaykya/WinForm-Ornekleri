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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        Form1 f1 = new Form1();

        DialogResult secim = new DialogResult();
        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            f1.ShowDialog();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            lblAciklama.Text = "TAŞ KAĞIT MAKAS OYUNU\n\n3 olan taraf oyunu kazanır.\nBaşlamak için butona basın";
        }
        }
    }

