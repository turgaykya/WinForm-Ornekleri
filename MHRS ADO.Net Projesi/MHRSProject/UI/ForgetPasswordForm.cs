using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{ 
    public partial class ForgetPasswordForm : Form
    {
        UserBLL _userBLL;
        User _user;

        public ForgetPasswordForm()
        {
            InitializeComponent();

            _userBLL = new UserBLL();
            _user = new User();
        }


        
        private void txtEposta_Enter(object sender, EventArgs e)
        {
            txtTC.Text = "";
        }

        private void btnSendEposta_Click(object sender, EventArgs e)
        {
            if (btnSendControl.Text == "Gönder")
            {
                _user  = _userBLL.SendPassword(txtTC.Text);
            try
            {
                // User user = _userBLL.Get(UserID);
                lblPasswordStatus.Text = _user.SecretQuestion.Question;
                
                
                this.Height = 300;
                txtTC.Text = "";
                lblPasswordStatus.ForeColor = Color.Red;
                btnSendControl.Text = "Şifreyi Gönder";
            }
            catch (Exception)
            {

                MessageBox.Show("Mail Gönderilemedi MHRS Sisteminde Böyle Bir Mail Yok!", "Merkezi Hastane Randevu Sistemi Şifre Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            else if(btnSendControl.Text == "Şifreyi Gönder")
            {
                if (txtTC.Text == _user.SecretAnswer)
                {
                    try
                    {
                        SendMail(_user.Email, "Merkezi Hastane Randevu Sistemi Şifre Hatırlatma", "Merhaba " + _user.FirstName + " " + _user.LastName + ",\n\n\n" + "Şifreniz: " + _user.Password + "\n\n İyi Günler.");
                        MessageBox.Show("Şifreniz " + _user.Email + " Mail Adresine Gönderilmiştir", "Merkezi Hastane Randevu Sistemi Şifre Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Gizli Cevabınız Doğru Değil!", "Merkezi Hastane Randevu Sistemi Şifre Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Gizli Cevabınız Doğru Değil!", "Merkezi Hastane Randevu Sistemi Şifre Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            
        }

        private void SendMail(string toMail,string subject,string body)
        {
            MailMessage eMail = new MailMessage();
            eMail.From = new MailAddress("mehmetavci39@gmail.com");
            eMail.To.Add(toMail);
            eMail.Subject = subject;
            eMail.Body = string.Format(body);
            SmtpClient smptp = new SmtpClient();
            smptp.Credentials = new System.Net.NetworkCredential("mehmetavci39@gmail.com", "aslankral123");
            smptp.Port = 587;
            smptp.Host = "smtp.gmail.com";
            smptp.EnableSsl = true;
            smptp.Send(eMail);
        }

       

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
