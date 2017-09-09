using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace FileExp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Harddiskteki mantıksal sürücüleri getiren kod:
            DriveInfo[] suruculer = DriveInfo.GetDrives();
            //butun suruculerin ayrı ayrı eklenmesi için AddRange (Add değil).
            cmbSuruculer.Items.AddRange(suruculer);
            //Belirli bir dizin içerisindeki dosyaları gösteren kod:
            foreach (DriveInfo surucu in suruculer) //suruculerde dolastı
            {
                TreeNode aNodes = tvSol.Nodes.Add(surucu.Name); //hangi surucuyu eklediysek o surucuyu treeNode değişkeninde(nesne) tuttu
                try
                {
                    DirectoryInfo d = new DirectoryInfo(surucu.Name); //hangi surucudeyse alt klasorlerini tutuyo
                    DirectoryInfo[] klasor = d.GetDirectories();
                    foreach (DirectoryInfo folder in klasor)
                    {
                        aNodes.Nodes.Add(surucu.Name + folder.Name);
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void tvSol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                
            lstSag.Items.Clear();
                string[] dizindekiKlasorler = Directory.GetDirectories(tvSol.SelectedNode.Text);
                DirectoryInfo directory = new DirectoryInfo(tvSol.SelectedNode.Text);

                int j = 0;
                //sadece klasorleri sol ve sag tarafa
                for (j = 0; j < dizindekiKlasorler.Length; j++)
                {
                    string klasor = dizindekiKlasorler[j].ToString();
                    DirectoryInfo directoryInfo = new DirectoryInfo(klasor);
                    string klasorAdi = directoryInfo.Name;
                    tvSol.SelectedNode.Nodes.Add(tvSol.SelectedNode.Text + "/" + klasorAdi);
                    lstSag.Items.Add(klasorAdi);
                }
                // dosyaları sağ tarafa
                FileInfo[] dosyalar = directory.GetFiles();
                for (int i = 0; i < dosyalar.Length; i++)
                {                  
                        lstSag.Items.Add(dosyalar[i].ToString());
                }           
            }
            catch (Exception)
            {

          
            }
        }
    }
}