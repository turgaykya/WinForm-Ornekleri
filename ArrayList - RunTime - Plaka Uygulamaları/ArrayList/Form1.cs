using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayList2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList kisiList = new ArrayList();

        string[] intDizisi = new string[5];

        private void Yenile() 
        {
            txBxData.Clear();
            foreach (var item in kisiList)
            {
                listBox1.Items.Add(item);
            }
            kisiList.Clear();
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txBxData.Text != "" && txBxData.Text != null)
            {
                kisiList.Add(txBxData.Text);
                //txBxData.Text = "";
                //kisiList.Clear();
                Yenile();
            }
            else
            {
                MessageBox.Show("Lütfen gecerli bir değer giriniz.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string mesaj = listBox1.Items.Count.ToString();
            MessageBox.Show(mesaj);
        }

        private void btnIsFixedSize_Click(object sender, EventArgs e)
        {



            if (kisiList.IsFixedSize)
            {
                MessageBox.Show("String Dizisinin Geçerli bir sınır değeri vardır.");
            }
            else
            {
                MessageBox.Show("String Dizisinin Geçerli bir sınır değeri yoktur.");
            }
            //--
            if (intDizisi.IsFixedSize)
            {
                MessageBox.Show("String Dizisinin Gecerli bir sınır değeri vardır. Ve hatta o değer: "+ intDizisi.Length);
            }
            else
            {
                MessageBox.Show("String Dizisinin Gecerli bir sınır degeri yoktur.");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            kisiList.Clear();
            kisiList.AddRange(listBox1.Items);
            listBox1.Items.Clear();
            kisiList.Sort();


            foreach (var item in kisiList)
            {
                
                listBox1.Items.Add(item);
            }
            kisiList.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            kisiList.AddRange(listBox1.Items);
            listBox1.Items.Clear();

            if (txBxData.Text != "" && txBxData.Text != null)
            {
                kisiList.Insert(2, txBxData.Text);
                //txBxData.Text = "";
                //kisiList.Clear();
                Yenile();
            }
            else
            {
                MessageBox.Show("Boşsa ekleme yapılamaz");
            }
            Yenile();
            foreach (var item in kisiList)
            {
                listBox1.Items.Add(item);
            }
            txBxData.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Yenile();          
        }


        
    }
}
