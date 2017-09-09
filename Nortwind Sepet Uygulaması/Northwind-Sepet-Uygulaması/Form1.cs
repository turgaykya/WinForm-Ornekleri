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

namespace Northwind_Sepet_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm2 = new Form2();
        List<Employee> empList;
        List<Custommer> custList;
        List<Shipper> shipList;
        Shipper ship;
        Custommer cust;
        Employee emp;
        object sonuc;


        private void btnSipariseBasla_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.cnn;
            cmd.CommandText = "sp_SiparisEkle";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID",cust.CustommerID);
            cmd.Parameters.AddWithValue("EmployeeID", emp.EmployeeID);
            cmd.Parameters.AddWithValue("@ShipVia", ship.ShipperID);

            cmd.Connection.Open();
            sonuc = cmd.ExecuteScalar();
            cmd.Connection.Close();
            if (sonuc != null)
            {
                MessageBox.Show("Sipariş Oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Sipariş Oluşturulmadı.");
            }

            frm2.OrderID = sonuc;

            this.Hide();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalisanGetir();
            MusteriGetir();
            KargocuGetir();

        }

        private void KargocuGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ShipperID, CompanyName from Shippers";
            cmd.Connection = SqlHelper.cnn;
            cmd.Connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                shipList = new List<Shipper>();
                while (dataReader.Read())
                {
                    ship = new Shipper();
                    ship.ShipperID = (int)dataReader[0];
                    ship.CompanyName = (string)dataReader[1];
                    shipList.Add(ship);
                }
                cmbKargocu.DataSource = shipList;
            }
            cmd.Connection.Close();
        }
        private void MusteriGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CustomerID, CompanyName from Customers";
            cmd.Connection = SqlHelper.cnn;
            cmd.Connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                custList = new List<Custommer>();
                while (dataReader.Read())
                {
                    cust = new Custommer();
                    cust.CustommerID = (string)dataReader[0];
                    cust.CompanyName = (string)dataReader[1];
                    custList.Add(cust);
                }
                cmbMusteri.DataSource = custList;
            }
            cmd.Connection.Close();
        }
        private void CalisanGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select EmployeeID, FirstName, LastName from Employees";
            cmd.Connection = SqlHelper.cnn;
            cmd.Connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                empList = new List<Employee>();
                while (dataReader.Read())
                {
                    emp = new Employee();
                    emp.EmployeeID = (int)dataReader[0];
                    emp.FirstName = (string)dataReader[1];
                    emp.LastName = (string)dataReader[2];
                    empList.Add(emp);
                }
                cmbCalisan.DataSource = empList;
            }
            cmd.Connection.Close();
        }
       
    }
}
