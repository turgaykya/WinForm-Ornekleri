using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIForms
{
    public partial class Form1 : Form
    {
        // MDI
        // Multiple Document Arayüzü
        public EmployeeForm employeeForm = new EmployeeForm();
        public EmployeeListForm employeeListForm = new EmployeeListForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemCalculator_Click(object sender, EventArgs e)
        {
            CalculatorForm calculator = new CalculatorForm();
            calculator.MdiParent = this;
            calculator.Show();
        }

        #region Görünüm Methodları
        private void menuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuItemVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuItemHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuItemArrangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        } 
        #endregion

        private void menuItemCloseAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm pencereleri kapatmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                //    for (int i = 0; i <this.MdiChildren.Length ; i++)
                //    {
                //        this.MdiChildren[i].Close();
                //    }


                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
            }
        }

        private void menuItemNewEmployee_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is EmployeeForm)
                {
                    form.BringToFront();
                    return;
                }
                /* BASİT BİR REFLECTION ÖRNEĞİ */
                //if (form.GetType() == typeof(EmployeeForm))
                //{
                //    form.BringToFront();
                //    return;
                //}
            }
            foreach (Form form in this.MdiChildren)
            {
                if (form is EmployeeListForm)
                {
                    form.BringToFront();
                }
            }           

            employeeForm.MdiParent = this;

            employeeForm.Show();

            employeeForm.btnSave.Click += new EventHandler(btnSave_Click);

            employeeListForm.MdiParent = this;

            employeeListForm.Show();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = employeeForm._FirstName;
            string lastName = employeeForm._LastName;
            employeeListForm.listBox1.Items.Add(firstName + " " + lastName);
           
        }

        private void menuItemAddProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.MdiParent = this;
            productForm.Show();
            productForm.FormClosing += productForm_FormClosing;

            //((ToolStripMenuItem)sender).Enabled = false;
            //menuItemAddProduct.Enabled = false;
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            menuItem.Enabled = false;
        }

        void productForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuItemAddProduct.Enabled = true;
        }

        private void menuItemEmployeeList_Click(object sender, EventArgs e)
        {
            employeeListForm = new EmployeeListForm();

            employeeListForm.Show();
        }
    }
}
