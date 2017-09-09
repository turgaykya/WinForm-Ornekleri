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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Product> prodList;
        Product prod;
        public object OrderID;
        int urunStogu;


        private void Form2_Load(object sender, EventArgs e)
        {

            UrunGetir();
        }

        private void UrunGetir()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ProductID, ProductName, UnitsInStock from Products";
            cmd.Connection = SqlHelper.cnn;
            cmd.Connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                prodList = new List<Product>();
                while (dataReader.Read())
                {
                    prod = new Product();
                    prod.ProductID = (int)dataReader[0];
                    prod.ProductName = (string)dataReader[1];
                    prod.UnitsInStock = (short)dataReader[2];
                    prodList.Add(prod);
                }
                cmbUrun.DataSource = prodList;
            }
        }

        private void btnSiparisYolla_Click(object sender, EventArgs e)
        {
            SqlHelper.cnn.Close();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.cnn;
            cmd.CommandText = "sp_SiparisYolla";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OrderID", OrderID);
            cmd.Parameters.AddWithValue("@ProductID", prod.ProductID);
            cmd.Parameters.AddWithValue("@Quantity", txtUrunAdedi.Text);

            try
            {
                cmd.Connection.Open();

                foreach (Product item in prodList)
                {
                    if (cmbUrun.SelectedValue.ToString() == item.ProductName)
                    {
                        urunStogu = item.UnitsInStock;
                    }
                }
                if (urunStogu > int.Parse(txtUrunAdedi.Text))
                {
                    int SorguSonucuEtkilenenSatir = cmd.ExecuteNonQuery();

                    if (SorguSonucuEtkilenenSatir > 0)
                    {
                        MessageBox.Show("SİPARİS YOLLANDI.");
                        urunStogu = urunStogu - Convert.ToInt32(txtUrunAdedi.Text);

                        SqlHelper.cnn.Close();

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = SqlHelper.cnn;
                        cmd2.CommandText = "sp_StokAzalt";
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@AzalacakStok", Convert.ToInt16(txtUrunAdedi.Text));
                        cmd2.Parameters.AddWithValue("AzalacakUrun", Convert.ToString(cmbUrun.SelectedValue));

                        try
                        {
                            cmd2.Connection.Open();
                            int SorguKontrol = cmd2.ExecuteNonQuery();
                            
                            if (SorguKontrol > 0)
                            {
                                MessageBox.Show(string.Format("Stokta kalan {0} sayısı : {1}",
                                    cmbUrun.SelectedValue.ToString(),urunStogu.ToString()));
                            }                          
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            cmd2.Connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("SİPARİS YOLLANAMADI !");
                    }
                }
                else
                {
                    MessageBox.Show("STOKTA ÜRÜN AZ !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }






        }


    }
}
