using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataTable dt;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
        }

        SqlCommandBuilder builder;
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult DRs = MessageBox.Show("Değişiklikleri veritabanına kaydetmek istediğinize emin misiniz?", "Senkron Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (DRs == DialogResult.Yes)
            {
                builder = new SqlCommandBuilder();
                builder.DataAdapter = da;
                da.Update(dt);
                DataGridDoldur();
            }
            else
            {
                MessageBox.Show("işleminiz iptal oldu!","iptal uyarısı",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DataGridDoldur()
        {
            da = new SqlDataAdapter("select * from Shippers", SqlHelper.cnn);
            dt = new DataTable();
            da.Fill(dt);
            dgvShippers.DataSource = dt;
        }
    }
}
