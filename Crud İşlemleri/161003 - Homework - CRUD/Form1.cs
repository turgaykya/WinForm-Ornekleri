using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _161003___Homework___CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        FormEkle frmEkle = new FormEkle();
        FormGuncelle frmGuncelle = new FormGuncelle();
        FormSil frmSil = new FormSil();

        internal static List<Product> prodList = new List<Product>();

        

        private void Form1_Load(object sender, EventArgs e)
        {
            frmEkle.MdiParent = this;
            frmGuncelle.MdiParent = this;
            frmSil.MdiParent = this;
            
            

        }
        private void menuItemEkle_Click(object sender, EventArgs e)
        {
           
            frmEkle.Show();
            frmGuncelle.Hide();
            frmSil.Hide();
            
           
          
        }

        private void menuItemGuncelle_Click(object sender, EventArgs e)
        {
            
            frmGuncelle.Show();
            frmEkle.Hide();
            frmSil.Hide();
        }

        private void menuItemSil_Click(object sender, EventArgs e)
        {
            frmSil.Show();
            frmEkle.Hide();
            frmGuncelle.Hide();

          
        }

        
    }
}
