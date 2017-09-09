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

namespace _04_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Category> listCat = new List<Category>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select p.ProductID, p.ProductName from Products p JOIN Categories c ON  c.CategoryID = p.CategoryID where c.CategoryName=@Name");
            cmd.Parameters.AddWithValue("@Name", txtCategorySelect.Text);
            cmd.Connection = SqlHelper.cnn;
                    // B' or 1=1 or CategoryName='    sistem acıgıdır. bunu yapınca yine getirir.
            cmd.Connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Category cat = new Category();
                    cat.CategoryID = (int)dataReader[0];
                    cat.CategoryName = (string)dataReader[1];
                    listCat.Add(cat);
                }
            }
            dgvProducts.DataSource = listCat;
            cmd.Connection.Close();
        }
    }
}
