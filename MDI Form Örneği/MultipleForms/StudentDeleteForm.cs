using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class StudentDeleteForm : Form
    {
        public string FullName = string.Empty;
        public bool IsConfirmed = false;

        public StudentDeleteForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;            
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void StudentDeleteForm_Load(object sender, EventArgs e)
        {
            lblWarning.Text = FullName + " isimli kayıt silinecek!\nDevam etmek istiyor musunuz?";
        }
    }
}
