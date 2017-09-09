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

namespace _161003___Homework___CRUD
{
    public partial class FormEkle : Form
    {
        public FormEkle()
        {
            InitializeComponent();

        }



        private void FormEkle_Load(object sender, EventArgs e)
        {

            lvGoster();



        }

        public void lvGoster()
        {
            lvProducts.Items.Clear();
            Form1.prodList.Clear();
            Product prod;
            SqlHelper.cnn.Close();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Products";
            cmd.Connection = SqlHelper.cnn;

            cmd.Connection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    prod = new Product();
                    prod.ProductID = (int)dataReader[0];
                    prod.ProductName = dataReader[1].ToString();
                    prod.SupplierID = (int)dataReader[2];
                    prod.CategoryID = (int)dataReader[3];
                    prod.QuantityPerUnit = dataReader[4].ToString();
                    prod.UnitPrice = double.Parse((dataReader[5].ToString()));
                    prod.UnitsInStock = (short)dataReader[6];
                    prod.UnitsOnOrder = (short)dataReader[7];
                    prod.RecorderOrder = (short)dataReader[8];
                    prod.Discontinued = (bool)dataReader[9];

                    Form1.prodList.Add(prod);
                    ListViewItem li = new ListViewItem();
                    li.Tag = prod;
                    li.Text = prod.ProductID.ToString();
                    li.SubItems.Add(prod.ProductName);
                    li.SubItems.Add(prod.SupplierID.ToString());
                    li.SubItems.Add(prod.CategoryID.ToString());
                    li.SubItems.Add(prod.QuantityPerUnit.ToString());
                    li.SubItems.Add(prod.UnitPrice.ToString());
                    li.SubItems.Add(prod.UnitsInStock.ToString());
                    li.SubItems.Add(prod.UnitsOnOrder.ToString());
                    li.SubItems.Add(prod.RecorderOrder.ToString());
                    li.SubItems.Add(prod.Discontinued.ToString());
                    lvProducts.Items.Add(li);
                }

            }
            cmd.Connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ProductAdd();

        }

        private void ProductAdd()
        {
            if (txtProductName.Text != "" &&
                txtSupplierID.Text != "" &&
                txtCategoryID.Text != "" &&
                txtQuantityPerUnit.Text != "" &&
                txtUnitPrice.Text != "" &&
                txtUnitsInStock.Text != "" &&
                txtUnitsInOrder.Text != "" &&
                txtReorderLevel.Text != "")
            {
                Product p = new Product();
                SqlHelper.cnn.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("INSERT INTO Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) VALUES ('{0}',{1},{2},'{3}',{4},{5},{6},{7},1);",
                    txtProductName.Text,
                    txtSupplierID.Text,
                    txtCategoryID.Text,
                    txtQuantityPerUnit.Text,
                    txtUnitPrice.Text,
                    txtUnitsInStock.Text,
                    txtUnitsInOrder.Text,
                    txtReorderLevel.Text
                    );

                cmd.Connection = SqlHelper.cnn;

                try
                {
                    cmd.Connection.Open();
                    int etkilenen = cmd.ExecuteNonQuery();
                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Ürün eklendi.");
                        txtProductName.Text = "";
                        txtSupplierID.Text = "";
                        txtCategoryID.Text = "";
                        txtQuantityPerUnit.Text = "";
                        txtUnitPrice.Text = "";
                        txtUnitsInStock.Text = "";
                        txtUnitsInOrder.Text = "";
                        txtReorderLevel.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ekleme işleminde bir hata olustu..");
                    }
                    cmd.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cmd.Connection.Close();
                }


                lvGoster();
            }

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            lvGoster();
        }


    }
}
