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
    public partial class UserInformation : Form
    {
        UserBLL _userBLL;
        User _user;
        SecretQuestionBLL _secretQuestionBLL;

        public UserInformation()
        {
            _secretQuestionBLL = new SecretQuestionBLL();
            _userBLL = new UserBLL();
            _user = new User();
            InitializeComponent();
        }



        private void UserInformation_Load(object sender, EventArgs e)
        {
            
            _user = _userBLL.Get(Form1._userID);
            txtTC.Text = _user.TC;
            txtPassword.Text = _user.Password;
            txtName.Text = _user.FirstName;
            txtLastName.Text = _user.LastName;
            cmbGender.SelectedIndex = _user.Gender == true ? 0 : 1;
            dtpDateOfBirth.Value = _user.DateOfBirth;
            txtPlaceOfBirth.Text = _user.PlaceOfBirth;
            txtFatherName.Text = _user.FatherName;
            txtMotherName.Text = _user.MotherName;
            txtPhone.Text = _user.Phone;
            txtEposta.Text = _user.Email;

            cmbSecretQuestion.DataSource = _secretQuestionBLL.GetAll();
            cmbSecretQuestion.DisplayMember = "Question";
            cmbSecretQuestion.ValueMember = "Id";
            dtpDateOfBirth.MaxDate = DateTime.Now;


            txtSecretAnswer.Text = _user.SecretAnswer;


        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {

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


            bool result;

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
                    result = _userBLL.Update(_user);
                    if (result == true)
                    {
                        MessageBox.Show("Kaydınız güncellenmiştir","Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme işlemi sırasında bir hata meydana geldi.");
                    }
                }
                else
                {
                    MessageBox.Show("Zorunlu alanlar boş bırakılamaz!","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnReserveHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReserveHistory reserveHistory = new ReserveHistory();
            reserveHistory.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddReserveForm addReserveForm = new AddReserveForm();
            addReserveForm.Show();
        }
    }
}
