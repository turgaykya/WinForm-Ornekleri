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

namespace _02_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            string query = "select CategoryID, CategoryName, Description from Categories";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query,SqlHelper.cnn);

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item["CategoryID"].ToString();
                li.SubItems.Add(item[1].ToString());
                li.SubItems.Add(item[2].ToString());

                lvCategory.Items.Add(li);
            }

            cmbCategories.DataSource = dt;
            cmbCategories.DisplayMember = "CategoryName";   //bunlar gozuksun
            cmbCategories.ValueMember = "CategoryID";      //valuesi bu olsun 
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  COMBOBOX UN KENDI OZELLIGI OLARAK YUKARIDAKI OZELLIKLER ILE ID YI DIREK SECEBILIYORUZ. DEBUG DE BAK
            //string deger = cmbCategories.SelectedValue.ToString();
        }

       
    }
}
