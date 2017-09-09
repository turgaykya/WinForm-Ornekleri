using _161013_ProductCRUD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _161013_ProductCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategories.DataSource = db.Categories.ToList();
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DisplayMember = "CategoryName";
            GetProducts();

        }

        private void GetProducts()
        {
            dgvProduct.DataSource = db.Products.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.CategoryID = (int)cmbCategories.SelectedValue;
            prod.ProductName = txtProductName.Text;
            db.Products.Add(prod);
            db.SaveChanges();
            GetProducts();


            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                int id = (int)dgvProduct.SelectedRows[0].Cells["ProductID"].Value;
                Product prod = db.Products.Where(x => x.ProductID == id).FirstOrDefault();

                db.Products.Remove(prod);
                db.SaveChanges();
                GetProducts();

            }
        }

        Product guncellenecek;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvProduct.SelectedRows[0].Cells["ProductID"].Value;
            guncellenecek = db.Products
                              .Where(x => x.ProductID == id)
                              .FirstOrDefault();
            txtProductName.Text = guncellenecek.ProductName;
            cmbCategories.SelectedValue = guncellenecek.CategoryID;
            btnSave.Visible = false;
            btnEdit.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            guncellenecek.ProductName = txtProductName.Text;
            guncellenecek.CategoryID = (int)cmbCategories.SelectedValue;
            db.SaveChanges();
            GetProducts();
            txtProductName.Text = "";
            btnSave.Visible = true;
            btnEdit.Visible = false;
        }
    }
}
