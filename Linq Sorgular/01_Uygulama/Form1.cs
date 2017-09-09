using _01_Uygulama.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Form1_Load(object sender, EventArgs e)
        {

            NorthwindEntities db = new NorthwindEntities();

            #region Sorgu 1

            //var query = (
            //            from c in db.Categories
            //            join p in db.Products on c.CategoryID equals p.CategoryID
            //            join od in db.Order_Details on p.ProductID equals od.ProductID
            //            join o in db.Orders on od.OrderID equals o.OrderID
            //            where c.CategoryName == "Condiments"
            //            select new
            //            {
            //                p.UnitsInStock,
            //                o.OrderDate
            //            }).Distinct().ToList();
            //dgvTest.DataSource = query;
            #endregion
            #region Sorgu 2


            //var query = (
            //            from p in db.Products
            //            join od in db.Order_Details on p.ProductID equals od.ProductID
            //            join o in db.Orders on od.OrderID equals o.OrderID
            //            join c in db.Customers on o.CustomerID equals c.CustomerID
            //            where p.ProductName == "Chai" || p.ProductName == "Tofu"
            //                    && o.OrderDate < new DateTime(1997, 07, 01)
            //            select new
            //            {
            //                p.ProductName,
            //                p.UnitsInStock,
            //                c.City
            //            }).ToList();
            //dgvTest.DataSource = query;


            #endregion
            #region Sorgu 3


            //var query = (
            //   from od in db.Order_Details
            //   join o in db.Orders on od.OrderID equals o.OrderID
            //   join c in db.Customers on o.CustomerID equals c.CustomerID
            //   join emp in db.Employees on o.EmployeeID equals emp.EmployeeID
            //   from et in emp.Territories
            //   join t in db.Territories on et.TerritoryID equals t.TerritoryID
            //   join r in db.Regions on t.RegionID equals r.RegionID
            //   select new
            //   {
            //       c.ContactName,
            //       c.Phone
            //   }).Distinct();

            //dgvTest.DataSource = query.ToList();

            #endregion
            #region Sorgu 4


            //var query = (
            //            from p in db.Products
            //            join s in db.Suppliers on p.SupplierID equals s.SupplierID
            //            join od in db.Order_Details on p.ProductID equals od.ProductID
            //            join o in db.Orders on od.OrderID equals o.OrderID
            //            join sh in db.Shippers on o.ShipVia equals sh.ShipperID
            //            where sh.CompanyName == "United Package"
            //            select new
            //            {
            //                p.ProductID,
            //                p.ProductName,
            //                p.Order_Details,
            //                p.QuantityPerUnit,
            //                p.ReorderLevel,
            //                p.Supplier,
            //                p.SupplierID,
            //                p.UnitsInStock,
            //                p.UnitsOnOrder,
            //                sh.CompanyName
            //            }).ToList();
            //dgvTest.DataSource = query;

            #endregion
            #region Sorgu 5


            //var query = (
            //            from e1 in db.Employees
            //            join e2 in db.Employees on e1.EmployeeID equals e2.ReportsTo
            //            join o in db.Orders on e1.EmployeeID equals o.EmployeeID
            //            join sh in db.Shippers on o.ShipVia equals sh.ShipperID
            //            join c in db.Customers on o.CustomerID equals c.CustomerID
            //            where o.ShipCountry == "Venezuela"
            //            select new
            //            {
            //                CalisanAdi = e1.FirstName,
            //                Amiri = e2.ReportsTo,
            //                Kargocu = sh.CompanyName,
            //                Musteri = c.CompanyName,
            //                KargocuTelefon = sh.Phone
            //            }).ToList();
            //dgvTest.DataSource = query;

            #endregion
            #region Sorgu 6


            //var query = (
            //            from p in db.Products
            //            join od in db.Order_Details on p.ProductID equals od.ProductID
            //            join o in db.Orders on od.OrderID equals o.OrderID
            //            join c in db.Customers on o.CustomerID equals c.CustomerID
            //            join emp in db.Employees on o.EmployeeID equals emp.EmployeeID
            //            where emp.FirstName == "Nancy" && c.CustomerID == "ALFKI"
            //            select new
            //            {
            //                Stok = p.UnitsInStock                         
            //            }).ToList();
            //dgvTest.DataSource = query;


            #endregion

        }
    }
}
