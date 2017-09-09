
using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SingUpForm : Form
    {
        UserBLL _userBLL;
        User _user;

        SecretQuestionBLL _secretQuestionBLL;
  

       
        public SingUpForm()
        {
            _userBLL = new UserBLL();
            _user = new User();
            _secretQuestionBLL = new SecretQuestionBLL();
            InitializeComponent();
     
        }

        private void SingUpForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbGender.SelectedIndex = 0;
                cmbSecretQuestion.DataSource = _secretQuestionBLL.GetAll();
                cmbSecretQuestion.DisplayMember = "Question";
                cmbSecretQuestion.ValueMember = "Id";
                dtpDateOfBirth.MaxDate = DateTime.Now;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ters giden birşeyler var..");
            }
            

            


        }

        private void btnSingSave_Click(object sender, EventArgs e)
        {
            int result;
            _user.TC = txtTC.Text;
            _user.Password = txtPassword.Text;
            _user.FirstName = txtName.Text;
            _user.LastName = txtLastName.Text;
            _user.Gender = cmbGender.SelectedIndex == 0 ? true : false;
            _user.DateOfBirth = dtpDateOfBirth.Value;
            _user.PlaceOfBirth = txtPlaceOfBirth.Text;
            _user.FatherName = txtFatherName.Text;
            _user.MotherName = txtMotherName.Text;
            _user.Phone = txtPhone.Text;
            _user.Email = txtEposta.Text;
            _user.SecretQuestion.Id = (int)cmbSecretQuestion.SelectedValue;
            _user.SecretAnswer = txtSecretAnswer.Text;

            try
            {

                if (
                     txtTC.Text != "" &&
                     txtPassword.Text != "" &&
                     txtName.Text != "" &&
                     txtLastName.Text != "" &&
                     dtpDateOfBirth.Value < DateTime.Now &&
                     txtPhone.Text != "" &&
                     txtEposta.Text != "" &&
                     txtSecretAnswer.Text != ""
                    )
                {
                    result = _userBLL.Insert(_user);
                    if (result > 0)
                    {
                        MessageBox.Show("Kaydınız yapılmıştır");
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı var Kayıt yapılamaz");
                    }
                }
                else
                {
                    MessageBox.Show("Zorunlu alanlar boş bırakılamaz!");
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        

    }
}
