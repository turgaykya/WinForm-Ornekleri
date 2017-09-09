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
    public partial class Form1 : Form
    {
        List<Category> catList;
        List<Product> proList;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
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
            proList.Add(new Product() { ProductID = 1, ProductName = "HP Laptop", CategoryID = 1, Stock = 100, Price = 23.10 });
            proList.Add(new Product() { ProductID = 2, ProductName = "Lenovo", CategoryID = 1, Stock = 21, Price = 23.10 });
            proList.Add(new Product() { ProductID = 3, ProductName = "DELL", CategoryID = 1, Stock = 3, Price = 53.10 });

            proList.Add(new Product() { ProductID = 4, ProductName = "T-Shirt", CategoryID = 2, Stock = 34, Price = 223.10 });
            proList.Add(new Product() { ProductID = 5, ProductName = "Gömlek", CategoryID = 2, Stock = 34, Price = 243.10 });
            proList.Add(new Product() { ProductID = 6, ProductName = "Pantolon", CategoryID = 2, Stock = 67, Price = 723.10 });

            proList.Add(new Product() { ProductID = 7, ProductName = "Hamburger", CategoryID = 3, Stock = 1004, Price = 823.10 });
            proList.Add(new Product() { ProductID = 8, ProductName = "Kek", CategoryID = 3, Stock = 6, Price = 13.10 });
            proList.Add(new Product() { ProductID = 9, ProductName = "Kısır", CategoryID = 3, Stock = 546, Price = 123.10 });

            proList.Add(new Product() { ProductID = 10, ProductName = "Aspirin", CategoryID = 4, Stock = 75, Price = 3.10 });






        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            //Tüm Liste
            var result = (
                            from cat in catList
                            join pro in proList on cat.CategoryID equals pro.CategoryID
                            select new  // birden fazla değer gelecekse select new şeklinde yazılır.
                            {
                                CategoryID = cat.CategoryID,
                                CategotyName = cat.CategoryName,
                                ProductID = pro.ProductID,
                                ProductName = pro.ProductName,
                                FullName = cat.CategoryName + " " + pro.ProductName
                            }
                   ).ToList();
            lstQuery.ValueMember = "ProductID";   // arkada seçilen
            lstQuery.DisplayMember = "FullName";  // önde gorunen
            lstQuery.DataSource = result;
            dgvQuery.DataSource = result;
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            lstQuery.DataSource = null;
            var result = (
                        from cat in catList
                        join pro in proList on cat.CategoryID equals pro.CategoryID
                        group cat by cat.CategoryName into g
                        select new
                        {
                            Key = g.Key,  //gruplanacak şey key olur
                            ToplamSayi = g.Count()
                        }
                ).ToList();
            lstQuery.DataSource = result;
            dgvQuery.DataSource = result;

        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            //Kategorilere göre toplam stok sayısı
            /*
             SELECT
                c.CategoryName,
                SUM(p.UnitsInStock) AS SumStock
              FROM Categories c
              JOIN Products p ON c.CategoryID = p.CategoryID
              GROUP BY c.CategoryName
             */
            var result = (
                        from c in catList
                        join p in proList on c.CategoryID equals p.CategoryID
                        group new { p, c } by c.CategoryName into g
                        select new
                        {
                            Name = g.Key,
                            SumStock = g.Sum(x => x.p.Stock)
                            // x oyleki x in içindeki product tablosundan stocka git.
                        }
                ).ToList();

            dgvQuery.DataSource = result;
        }


    }
}
