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
    public partial class EmployeeForm : Form
    {
        public string _FirstName = string.Empty;
        public string _LastName = string.Empty;       

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _FirstName = textBox1.Text;
            _LastName = textBox2.Text;

        }
    }
}
