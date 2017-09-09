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

namespace _01_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string query = "select * from Categories";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query,SqlHelper.cnn);  //SqlCıommand ın disconnected olanı gibi.
            //SqlDataAdapter => server bağlantısını kendisi açıp kapar.
            
            //DataSet => Bu yapı RAM uzerindeki sanal tablolarımız olarak adlandırılabilir. Ancak DataSet ler uzerinde asla bir veri bulunmaz. Bilgiler herzaman DataTable üzerinde tutulur.
            //DataSet in amacı DataTable ları bir arada tutmaktır.
            DataSet ds = new DataSet(); //bununla tablo çekiyoruz.
            dataAdapter.Fill(ds);
            dgvCategories.DataSource = ds.Tables[0];
        }
    }
}
