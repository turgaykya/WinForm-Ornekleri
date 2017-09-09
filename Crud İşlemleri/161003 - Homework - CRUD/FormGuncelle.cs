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
    public partial class FormGuncelle : Form
    {
        public FormGuncelle()
        {
            InitializeComponent();
            
        }

        Product prod;

        private void FormGuncelle_Load(object sender, EventArgs e)
        {
            lvGoster();
        }

        public void lvGoster()
        {
            lvProducts.Items.Clear();
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

        private void btnUpdate_Click(object sender, EventArgs e)
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
                
                SqlHelper.cnn.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("UPDATE Products SET ProductName='{0}',SupplierID={1},CategoryID={2},QuantityPerUnit='{3}',UnitPrice={4},UnitsInStock={5},UnitsOnOrder={6},ReorderLevel={7},Discontinued={8} WHERE ProductID={9}",
                    txtProductName.Text,
                    txtSupplierID.Text,
                    txtCategoryID.Text,
                    txtQuantityPerUnit.Text,
                    txtUnitPrice.Text,
                    txtUnitsInStock.Text,
                    txtUnitsInOrder.Text,
                    txtReorderLevel.Text,
                    txtProdIuctID.Text,
                    txtProdIuctID.Text
                    );

                cmd.Connection = SqlHelper.cnn;

                try
                {
                    cmd.Connection.Open();
                    int etkilenen = cmd.ExecuteNonQuery();
                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Ürün Güncellendi.");
                        txtProductName.Text = "";
                        txtSupplierID.Text = "";
                        txtCategoryID.Text = "";
                        txtQuantityPerUnit.Text = "";
                        txtUnitPrice.Text = "";
                        txtUnitsInStock.Text = "";
                        txtUnitsInOrder.Text = "";
                        txtReorderLevel.Text = "";
                        txtProdIuctID.Text = "";
                        txtDiscounted.Text = "";
                        lvProducts.Items.Clear();
                        lvGoster();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme işleminde bir hata olustu..");
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            prod = (Product)lvProducts.SelectedItems[0].Tag;
            txtProdIuctID.Text = prod.ProductID.ToString();
            txtProductName.Text = prod.ProductName;
            txtSupplierID.Text = prod.SupplierID.ToString();
            txtCategoryID.Text = prod.CategoryID.ToString();
            txtQuantityPerUnit.Text = prod.QuantityPerUnit;
            txtUnitPrice.Text = prod.UnitPrice.ToString();
            txtUnitsInStock.Text = prod.UnitsInStock.ToString();
            txtUnitsInOrder.Text = prod.UnitsOnOrder.ToString();
            txtReorderLevel.Text = prod.RecorderOrder.ToString();
            txtDiscounted.Text = prod.Discontinued.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            lvGoster();
        }

    }
}
