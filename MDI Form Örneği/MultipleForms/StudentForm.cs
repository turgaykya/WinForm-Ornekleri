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
    public partial class StudentForm : Form
    {   
        // Global değişkenlerin nesne yönelimli programlamadaki(OOP) adı: FIELD
        // Eğer ki FIELD yanında (hatta PROPERTY ve METHOD yanında) ACCESS MODIFIER(public, private) belirtilmemişse,
        // o üye (FIELD, PROPERTY, METHOD) otomatik olarak PRIVATE ilan edilir.
        // string _firstName = ""; 
        // string _lastName = "";

        public string FirstName = string.Empty;
        public string LastName = "";

        public StudentForm()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                this.FirstName = txtFirstName.Text.Trim();
                this.LastName = txtLastName.Text.Trim();

                this.Close();
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekiyor!");
            }
            
        }
    }
}
