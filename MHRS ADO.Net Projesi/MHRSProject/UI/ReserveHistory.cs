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
    public partial class ReserveHistory : Form
    {

        ReverseBLL _reserveBLL;
        
        public ReserveHistory()
        {
            InitializeComponent();
            _reserveBLL = new ReverseBLL();
            
        }

        
        private void ReserveHistory_Load(object sender, EventArgs e)
        {
            //dgvReserveHistory.DataSource = _reserveBLL.GetReserveHistory(Form1._userID);
            GetReserveHistory();
        }


        private void GetReserveHistory()
        {
            lstReserveHistory.Items.Clear();
            List<Reserve> _reserve = new List<Reserve>();
            _reserve.AddRange( _reserveBLL.GetReserveHistory(Form1._userID));

            foreach (var item in _reserve)
            {
                ListViewItem li = new ListViewItem();
                li.Tag = item;
                li.Text = item.Hospital.Name;
                li.SubItems.Add(item.Doctor.FullName);
                li.SubItems.Add(item.Clinic.Name);
                li.SubItems.Add(item.Policlinic.Name);
                li.SubItems.Add(((DateTime)item.ReserveDate).ToShortDateString());
                li.SubItems.Add(((DateTime)item.ReserveTime).ToShortTimeString());
                if (item.IsDrop)
                {
                    li.SubItems.Add("İptal");
                }
                else if(item.IsPassed){
                    li.SubItems.Add("Geçmiş");
                }
                else
                {
                    li.SubItems.Add("Aktif");
                }
                
                lstReserveHistory.Items.Add(li);
            }
        }



        private void btnGetProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
           
            }

        private void ReserveCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Reserve reserve = (Reserve)lstReserveHistory.SelectedItems[0].Tag;

                DialogResult dr = MessageBox.Show("Randevunuzu İptal Etmek İstediğinize Emin Misiniz?", reserve.Clinic.Name + " Randevu İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (_reserveBLL.ReserveCancel(reserve.Id) == true)
                    {
                        MessageBox.Show("Randevunuz İptal Edilmiştir.", "Randevu İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetReserveHistory();

                    }
                    else
                    {
                        MessageBox.Show("Bu Geçmiş veya İptal Edilmiş Randevuyu Güncelleyemezsiniz!", "Randevu İptal Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception)
            {


            }
        }
    }
    }

