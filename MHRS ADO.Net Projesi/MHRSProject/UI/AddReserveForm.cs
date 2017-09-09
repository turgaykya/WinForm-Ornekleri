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
    public partial class AddReserveForm : Form
    {
        CityBLL _cityBLL;
        City _city;

        Town _town;
        TownBLL _townBLL;

        Clinic _clinic;
        ClinicBLL _clinicBLL;

        Policlinic _policlinic;
        PolicilinicBLL _policlinicBLL;

        Doctor _doctor;
        DoctorBLL _doctorBLL;

        Hospital _hospital;
        HospitalBLL _hospitalBLL;

        Reserve _reserve;
        ReverseBLL _reserveBLL;

        User _user;
        UserBLL _userBLL;



        public AddReserveForm()
        {
            InitializeComponent();
            _city = new City();
            _cityBLL = new CityBLL();

            _town = new Town();
            _townBLL = new TownBLL();

            _clinic = new Clinic();
            _clinicBLL = new ClinicBLL();

            _hospital = new Hospital();
            _hospitalBLL = new HospitalBLL();

            _policlinic = new Policlinic();
            _policlinicBLL = new PolicilinicBLL();

            _doctor = new Doctor();
            _doctorBLL = new DoctorBLL();

            _reserve = new Reserve();
            _reserveBLL = new ReverseBLL();

            _user = new User();
            _userBLL = new UserBLL();
        }

        //UserInformation userInformation = new UserInformation();

        private void ReserveClear()
        {
            groupBox.Controls.Clear();
        }
        private void FormClear()
        {
            foreach (Control ctrlForm in this.Controls)
            {
                if (ctrlForm is GroupBox)
                {
                    foreach (Control ctrlGroupBox in ctrlForm.Controls)
                    {
                        if (ctrlGroupBox is ComboBox)
                        {
                            ((ComboBox)ctrlGroupBox).SelectedIndex = 0;
                        }
                        if (ctrlGroupBox is DateTimePicker)
                        {
                            ((DateTimePicker)ctrlGroupBox).Value = DateTime.Now;
                        }
                    }
                }
            }
        }

        private void AddReserveForm_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Date.DayOfWeek == DayOfWeek.Friday || DateTime.Now.Date.DayOfWeek == DayOfWeek.Thursday || DateTime.Now.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                dtpReserveDateTime.MaxDate = DateTime.Now.AddDays(4);
            }else if (DateTime.Now.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                dtpReserveDateTime.MaxDate = DateTime.Now.AddDays(5);
            }else if (DateTime.Now.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                dtpReserveDateTime.MaxDate = DateTime.Now.AddDays(3);
            }
            else
            {
                dtpReserveDateTime.MaxDate = DateTime.Now.AddDays(2);
            }
            
            cmbCity.DataSource = _cityBLL.GetAll();

            dtpReserveDateTime.MinDate = DateTime.Now;
           


            User user = _userBLL.Get(Form1._userID);
            lblUserName.Text = user.FirstName + " " + user.LastName;

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                City city = (City)cmbCity.SelectedValue;
                cmbTown.DataSource = _townBLL.GetTown(city.LicensePlate);
                ReserveClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbTown_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Town town = (Town)cmbTown.SelectedValue;
                cmbClinic.DataSource = _clinicBLL.GetClinic(town.Id);
                ReserveClear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmbClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Town town = (Town)cmbTown.SelectedValue;
                Clinic clinic = (Clinic)cmbClinic.SelectedValue;
                cmbHospital.DataSource = _hospitalBLL.GetHospital(town.Id, clinic.Id);
                ReserveClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Town town = (Town)cmbTown.SelectedValue;
                Clinic clinic = (Clinic)cmbClinic.SelectedValue;
                Hospital hospital = (Hospital)cmbHospital.SelectedValue;
                cmbPoliclinic.DataSource = _policlinicBLL.GetPoliclinic(town.Id, clinic.Id, hospital.Id);
                ReserveClear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmbPoliclinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Town town = (Town)cmbTown.SelectedValue;
                Clinic clinic = (Clinic)cmbClinic.SelectedValue;
                Hospital hospital = (Hospital)cmbHospital.SelectedValue;
                Policlinic policlinic = (Policlinic)cmbPoliclinic.SelectedValue;

                cmbDoctor.DataSource = _doctorBLL.GetDoctor(town.Id, clinic.Id, hospital.Id, policlinic.Id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        List<Button> buttonList;

        string reserveTime = string.Empty;
        private void Button_Click(object sender, EventArgs e)
        {
            Button reserveTimeButton = (Button)sender;
            reserveTime = "08-08-1994 " + reserveTimeButton.Text + ":00";
            lblReserveTime.Text = Convert.ToDateTime(reserveTime).ToShortTimeString();
        }

        private void btnReserveSave_Click(object sender, EventArgs e)
        {
            Clinic clinic = (Clinic)cmbClinic.SelectedValue;
            Hospital hospital = (Hospital)cmbHospital.SelectedValue;
            Policlinic policlinic = (Policlinic)cmbPoliclinic.SelectedValue;
            Doctor doctor = (Doctor)cmbDoctor.SelectedValue;

            try
            {
                int hcpdID = _reserveBLL.HCPDID(hospital.Id, clinic.Id, policlinic.Id, doctor.ID);
                if (reserveTime != "")
                {
                    _reserve.UserID = Form1._userID;
                    _reserve.hcpdID = hcpdID;
                    _reserve.IsDrop = false;
                    _reserve.IsPassed = false;
                    _reserve.ReserveDate = dtpReserveDateTime.Value;
                    _reserve.ReserveTime = Convert.ToDateTime(reserveTime);

                    int reserveControl = _reserveBLL.ReserveControl(Form1._userID, clinic.Id);


                    if (reserveControl == 0)
                    {
                        DialogResult dr = MessageBox.Show("Randevunuzu Onaylıyor musunuz?\n\nHastane Adı: "+hospital.Name+"\nKlinik: "+clinic.Name+"\nPoliklinik: "+policlinic.Name+"\nDoktor Adı: "+doctor.FullName+"\nRandevu Tarihi:"+dtpReserveDateTime.Value.ToShortDateString()+"\nRandevu Saati:"+ DateTime.Parse(reserveTime.ToString()).ToShortTimeString(), "Randevu Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            int affectedRows = _reserveBLL.Insert(_reserve);

                            if (affectedRows == 1)
                            {
                                MessageBox.Show("Randevunuz Kaydedilmiştir","Randevu işlemi Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                          
                                ReserveSearch();
                            }
                            else
                            {
                                MessageBox.Show("Hata Var");
                            }
                        }
                        else
                        {
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Zaten " + clinic.Name + " bölümüne ait randevunuz bulunmaktadır.");
                    }
                }
                else
                {
                    MessageBox.Show("Randevunuzu Tamamlamak için saat seçmeniz gerekmektedir.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
        }

        private void btnReserveSearch_Click(object sender, EventArgs e)
        {
           
            ReserveSearch();
        }

        public void ReserveSearch()
        {
            ReserveClear();
            buttonList = new List<Button>();

            Clinic clinic = (Clinic)cmbClinic.SelectedValue;
            Doctor doctor = (Doctor)cmbDoctor.SelectedValue;

            DayOfWeek dayOfWeek = dtpReserveDateTime.Value.DayOfWeek;

            if (dayOfWeek == System.DayOfWeek.Saturday || dayOfWeek == System.DayOfWeek.Sunday)
            {
                MessageBox.Show("Randevu günün haftasonu için seçemezsiniz!", "Randevu Günü Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpReserveDateTime.Value = DateTime.Now;
                return;
            }

            groupBox.Controls.Clear();
            int period = _clinicBLL.GetClinicPeriod(clinic.Id);
            String startTime = "09:00";
            bool flag = true;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button button = new Button();
                    button.Width = 70;
                    button.Height = 30;
                    button.Top = (i + 1) * 40;
                    button.Left = (j + 1) * 80;
                    button.BackColor = Color.GreenYellow;

                    button.Text = Convert.ToDateTime(startTime).ToShortTimeString();
                    startTime = Convert.ToDateTime(startTime).AddMinutes(period).ToString();
                    groupBox.Controls.Add(button);

                    button.Click += Button_Click;
                    buttonList.Add(button);
                    if (button.Text == "12:00")
                    {
                        startTime = "13:00";
                    }
                    if (button.Text == "17:00")
                    {
                        flag = false;
                        break;
                    }

                }

                if (flag == false)
                {
                    break;
                }
            }

            List<String> listReserve = new List<String>();
            listReserve.AddRange(_reserveBLL.GetAll(dtpReserveDateTime.Value.Date, doctor.ID));

            for (int i = 0; i < buttonList.Count; i++)
            {
                for (int j = 0; j < listReserve.Count; j++)
                {
                    if (buttonList[i].Text == Convert.ToDateTime(listReserve[j]).ToShortTimeString())
                    {
                        buttonList[i].Enabled = false;
                        buttonList[i].BackColor = Color.PaleVioletRed;
                    }
                }

            }

            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].Enabled)
                {
                    txtDoctorFirstName.Text = doctor.FullName;
                    txtDoctorClinic.Text = clinic.Name;
                    txtReserveTime.Text = buttonList[i].Text;
                    dtpDoctorReserveTime.Value = dtpReserveDateTime.Value;
                    break;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReserveClear();
        }

        private void dtpReserveDateTime_ValueChanged(object sender, EventArgs e)
        {
            ReserveClear();
        }
    }
}
