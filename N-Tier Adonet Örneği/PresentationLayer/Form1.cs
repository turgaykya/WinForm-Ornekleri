using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEditForm frm = new CategoryEditForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kategoriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryListForm frm = new CategoryListForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
