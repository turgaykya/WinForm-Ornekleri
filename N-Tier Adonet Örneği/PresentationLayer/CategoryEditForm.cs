using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class CategoryEditForm : Form
    {
        CategoryBLL _categoryBLL;
        Category _cat;
        bool isSave = false;
        public CategoryEditForm()
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
            _cat = new Category();
            isSave = true;
            btnSave.Text = "Kaydet";
        }

        public CategoryEditForm(int id)
        {
            InitializeComponent();
            _categoryBLL = new CategoryBLL();
            _cat = _categoryBLL.Get(id);
            isSave = false;
            btnSave.Text = "Güncelle";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _cat.CategoryName = txtName.Text;
            _cat.Description = txtDesc.Text;
            bool result;
            if (isSave == true)
            {
                result = _categoryBLL.Insert(_cat);
            }
            else
            {
                result = _categoryBLL.Update(_cat);
            }
            if (result)
            {
                MessageBox.Show("İşlem başarıyla gerçekleşti.");
            }
            else
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu.");
            }
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
            if (isSave == false)
            {
                txtDesc.Text = _cat.Description;
                txtName.Text = _cat.CategoryName;
            }
        }

     
    }
}
