using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> nameList = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            nameList.Add("Burcu Engin");
            nameList.Add("Ali Ozan Pişkin");
            nameList.Add("Serkan Soydam");
            nameList.Add("Doğan Kahveci");
            nameList.Add("Toni Demirci");
            nameList.Add("Burak Kaya");
            nameList.Add("Ferhat Demirci");
            nameList.Add("Bilal Günaydın");
            nameList.Add("Raif Çıplak");
            nameList.Add("Mehmet Avcı");
            nameList.Add("İsmail Can Ateş");
            nameList.Add("Yüğüt Taş");
            nameList.Add("Turgay Kaya");

            BindListBox(nameList);


        }

        void BindListBox(List<string> data)
        {
            lstNames.DataSource = null;
            lstNames.DataSource = data;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string value = txtSearch.Text;

            List<string> result = (
                                from name in nameList //name ara, name listesi içinde
                                where name.Contains(value) // değeri value olanları
                                orderby name //isme gore sırala
                                select name).ToList(); // 
            BindListBox(result);
                
               
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string value = txtSearch.Text.ToLower();

            List<string> result = (
                from item in nameList    // item ara nameList içinde.  GİBİ DÜŞÜN
                where item.ToLower().Contains(value)
                orderby item
                select item).ToList();
            BindListBox(result);

        }



        //LONQ sorgusu => Language Integrated Query
        //Lingq to Object
        //Lingq to SQL
        //Linq to Entity
        //Linqto XML

            // ToLower().StartsWith  ile  sadece baş harflerini alır 

            

    }
}
