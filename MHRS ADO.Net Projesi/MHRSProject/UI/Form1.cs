using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using BusinessLayer;

namespace UI
{
    public partial class Form1 : Form
    {
        ReverseBLL _reserve;


        public Form1()
        {
            InitializeComponent();
            lblRefresh.BringToFront();
            _reserve = new ReverseBLL();
        }


        internal int _random;
        public static int _userID = 0;


        private void btnSingUp_Click(object sender, EventArgs e)
        {
            SingUpForm signUpForm = new SingUpForm();
            signUpForm.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ("     " + txtChapta.Text == lblChapta.Text)
            {
                int control = 0;
                UserBLL _userBLL = new UserBLL();
                control = _userBLL.LoginControl(txtTC.Text, txtPassword.Text);
                if (control == -1)
                {
                    DialogResult DRs = new DialogResult();
                    DRs = MessageBox.Show("Henüz üye değilsiniz\nÜye olmak istermisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DRs == DialogResult.Yes)
                    {
                        SingUpForm singUpForm = new SingUpForm();
                        singUpForm.Show();
                    }
                }
                if (control >= 1)
                {
                    AddReserveForm addReserveForm = new AddReserveForm();

                    _userID = control;
                    this.Hide();
                    addReserveForm.Show();
                }
                else if (control == 0)
                {
                    MessageBox.Show("Hatalı şifre girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Random rnd = new Random();
                    _random = rnd.Next(10000, 99999);
                    lblChapta.Text = "     " + _random;
                }
            }
            else if ("     " + txtChapta.Text != lblChapta.Text)
            {
                txtChapta.Text = "Sağda ne yazıyor?";
                MessageBox.Show("Eşleşmeyen veya Doldurulmamış alanlar var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Random rnd = new Random();
                _random = rnd.Next(10000, 99999);
                lblChapta.Text = "     " + _random;
            }
        }
        private void btnForget_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgetPasswordForm = new ForgetPasswordForm();
            forgetPasswordForm.Show();
        }
        private void txtTC_Enter(object sender, EventArgs e)
        {
            txtTC.Text = "";
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }
        private void txtChapta_Enter(object sender, EventArgs e)
        {
            txtChapta.Text = "";
        }
        private void lblRefresh_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _random = rnd.Next(10000, 99999);
            lblChapta.Text = "     " + _random;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _random = rnd.Next(10000, 99999);
            lblChapta.Text = "     " + _random;

            _reserve.ReserveUpdate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
