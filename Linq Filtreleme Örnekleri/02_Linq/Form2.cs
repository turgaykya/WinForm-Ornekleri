using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Linq
{
    public partial class Form2 : Form
    {
        List<Category> catList;
        List<Product> proList;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            catList = new List<Category>();
            //Uzun yazımı
            //Category cat = new Category();
            //cat.CategoryID = 1;
            //cat.CategoryName = "Elektronik";
            //catList.Add(cat);


            //Kısa Yazımı
            catList.Add(new Category() { CategoryID = 1, CategoryName = "Elektronik" });
            catList.Add(new Category() { CategoryID = 2, CategoryName = "Giyim" });
            catList.Add(new Category() { CategoryID = 3, CategoryName = "Yiyecek" });
            catList.Add(new Category() { CategoryID = 4, CategoryName = "Sağlık" });


            proList = new List<Product>();

            proList = new List<Product>();
            proList.Add(new Product() { ProductID = 1, ProductName = "HP Laptop", CategoryID = 1 });
            proList.Add(new Product() { ProductID = 2, ProductName = "Lenovo Masaüstü", CategoryID = 1 });
            proList.Add(new Product() { ProductID = 3, ProductName = "DELL Laptop", CategoryID = 1 });
            proList.Add(new Product() { ProductID = 4, ProductName = "T-Shirt", CategoryID = 2 });
            proList.Add(new Product() { ProductID = 5, ProductName = "Gömlek", CategoryID = 2 });
            proList.Add(new Product() { ProductID = 6, ProductName = "Pantolon", CategoryID = 2 });
            proList.Add(new Product() { ProductID = 7, ProductName = "Hamburger", CategoryID = 3 });
            proList.Add(new Product() { ProductID = 8, ProductName = "Kek", CategoryID = 3 });
            proList.Add(new Product() { ProductID = 9, ProductName = "Kısır", CategoryID = 3 });
            proList.Add(new Product() { ProductID = 10, ProductName = "Aspirin", CategoryID = 4 });


            cmbCategory.DataSource = catList;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProduct.DataSource = null;

            var result = (          // joinlediğin tablo equals'ten sonra
                         from cat in catList
                         join pro in proList on cat.CategoryID equals pro.CategoryID
                         where cat.CategoryID == ((Category)
                             cmbCategory.SelectedItem).CategoryID
                         select pro.ProductName);

            lstProduct.DataSource = result.ToList();

            //select ProductName from products where categoryID = "VALUE" GROUP BY ProductName


           
        }
    }
}
