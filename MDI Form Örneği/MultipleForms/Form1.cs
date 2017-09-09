using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();

            studentForm.FormClosing += studentForm_FormClosing;
        }

        void studentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StudentForm studentForm = (StudentForm)sender;

            string firstName = studentForm.FirstName;
            string lastName = studentForm.LastName;

            listBox1.Items.Add(firstName + " " + lastName);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >=0)
            {
                StudentDeleteForm studentDeleteForm = new StudentDeleteForm();

                studentDeleteForm.FullName = (string)listBox1.SelectedItem;

                studentDeleteForm.Show();

                studentDeleteForm.FormClosing +=studentDeleteForm_FormClosing;
            }
            else
            {
                MessageBox.Show("Silmek için bir satır seçin");
            }            
        }

        void studentDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StudentDeleteForm studentDeleteForm = (StudentDeleteForm)sender;

            if(studentDeleteForm.IsConfirmed)
            {
                listBox1.Items.Remove(studentDeleteForm.FullName);
            }
        }

        private void btnDeleteDialog_Click(object sender, EventArgs e)
        {
            StudentDeleteForm studentDeleteForm = new StudentDeleteForm();

            studentDeleteForm.FullName = (string)listBox1.SelectedItem;

            DialogResult result = studentDeleteForm.ShowDialog();

            if(result == DialogResult.Yes && listBox1.SelectedIndex > -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }            
        }
    }
}
