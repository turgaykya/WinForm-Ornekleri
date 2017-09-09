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

namespace plaka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ArrayList
        /*
        şu vakte kadar gordugun dizilerin kısıtlarından ikisi: Tip bagımlı olması be kapasite sınırı
        Ancak ArrayList sayesinde bu kısıtlar ortadan kalkacak. ArrayList verileri object olarak tuacagından dolayı içindeki verileri cekerken unboxinf(casting / convert)
        yapmak gerekir.
        ArrayList'e erismek icin system.Connections kütüphanesini eklemen gerekir
        */
        ArrayList modernDizi = new ArrayList();

        Kayitlar yeniKayit = new Kayitlar();

        string sehirAdi;
        int plakaKodu;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //ArrayList yardimiyla item kaydetme.
            //modernDizi.Add(txtBxSehir.Text + " " + txtBxPlaka.Text);
            //listBox1.Items.Add(modernDizi[0]);
            //modernDizi.Clear();
            //txtBxPlaka.Text = "";
            //txtBxSehir.Text = "";

            yeniKayit.SehirAdi = txtBxSehir.Text;
            yeniKayit.PlakaKodu = txtBxPlaka.Text;
            listBox1.Items.Add(yeniKayit);
            //MessageBox.Show(yeniKayit.ToString());

        }
    }

    public class Kayitlar
    {
        public string PlakaKodu;
        public string SehirAdi;
        public override string ToString()
        {
            return PlakaKodu + " " + SehirAdi;
        }
    }
}
