using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _20_WF_XML_Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!(txtAd.Text.Length > 0 && txtSoyad.Text.Length > 0 && nudOkulNo.Value > 0))
                return;

            Öğrenci ogr = new Öğrenci();
            ogr.Ad = txtAd.Text;
            ogr.Soyad = txtSoyad.Text;
            ogr.OkulNo = (int)nudOkulNo.Value;
            ogr.DoğumTarihi = dtpDoğumTarihi.Value;
            ogr.Yaş = DateTime.Now.Year - ogr.DoğumTarihi.Year;

            ListViewItem lvi = new ListViewItem();
            lvi.Text = ogr.Ad;
            lvi.SubItems.Add(ogr.Soyad);
            lvi.SubItems.Add(ogr.OkulNo.ToString());
            lvi.SubItems.Add(ogr.DoğumTarihi.ToShortDateString());
            lvi.SubItems.Add(ogr.Yaş.ToString());

            //ListView içerisindeki Item'ların (satırların) Tag'ine öğrenci nesnesini attık.
            lvi.Tag = ogr;

            listView1.Items.Add(lvi);

            MessageBox.Show("Yeni öğrenci eklenmiştir.");

            Temizle();

        }

        /// <summary>
        /// Form içerisindeki kontrolleri temizler.
        /// </summary>
        private void Temizle()
        {
            //FOR
            //for (int i = 0; i < this.Controls.Count; i++)
            //{
            //    if (Controls[i] is TextBox)
            //    {
            //        Controls[i].Text = "";
            //        //Controls[i].Text = string.Empty;
            //    }
            //    else if (Controls[i] is NumericUpDown)
            //    {
            //        (Controls[i] as NumericUpDown).Value = 0;
            //    }
            //    else if (Controls[i] is DateTimePicker)
            //    {
            //        (Controls[i] as DateTimePicker).Text = "";
            //        //(Controls[i] as DateTimePicker).Value = DateTime.Now;
            //    }
            //}

            //FOREACH (EXTRA)
            foreach (Control cnt in this.Controls)
            {
                if (cnt is TextBox)
                {
                    cnt.Text = "";
                }
                else if (cnt is NumericUpDown)
                {
                    (cnt as NumericUpDown).Value = 0;
                }
                else if (cnt is DateTimePicker)
                {
                    (cnt as DateTimePicker).Value = DateTime.Now;
                }
            }
        }

        private void btnTekOgrenci_Click(object sender, EventArgs e)
        {
            if (!(txtAd.Text.Length > 0 && txtSoyad.Text.Length > 0 && nudOkulNo.Value > 0))
                return;

            Öğrenci ogr = new Öğrenci();
            ogr.Ad = txtAd.Text;
            ogr.Soyad = txtSoyad.Text;
            ogr.OkulNo = (int)nudOkulNo.Value;
            ogr.DoğumTarihi = dtpDoğumTarihi.Value;
            ogr.Yaş = DateTime.Now.Year - ogr.DoğumTarihi.Year;

            //Adım 1 : Xml dosyasını oluşturup, 
            //o dosya ile bağlantı sağlayacak hammal nesne oluşturulur.
            FileStream dosyaAkışı = File.Create("öğrenciListesi.xml");

            //Adım 2 : Oluşan Xml dosyaya Xml datası basmamız gerek.
            //Bu Xml datasını üreticek nesneyi oluşturuyor. 
            //XmlSerializer, belli bir sınıfın nesnesini Xml koduna dönüştürür.
            XmlSerializer xmlSerileştirici = new XmlSerializer(typeof(Öğrenci));

            //Adım 3 : Xml'e dönüştürme işlemi Serialize() metodu üzerinden yapılır.
            xmlSerileştirici.Serialize(dosyaAkışı, ogr);

            //Adım 4 : Her akışda olduğu gibi bu dosya akışını da kapatıyoruz.
            dosyaAkışı.Close();

            MessageBox.Show("İlgili öğrenci serilestirildi.");
        }

        private void btnHepsi_Click(object sender, EventArgs e)
        {
            Öğrenciler öğrenciler = new Öğrenciler();

            foreach (ListViewItem item in listView1.Items)
            {
                Öğrenci tagdakiOgr = item.Tag as Öğrenci;
                öğrenciler.ÖğrenciListesi.Add(tagdakiOgr);
            }

            //A1: hamal oluşturduk (dosya akısı)
            FileStream hamal = File.Create("BütünÖğrenciler.xml");

            //A2: serileştirici nesne tanımlandı
            XmlSerializer xmlSerileştirici = new XmlSerializer(typeof(List<Öğrenci>));
            //XmlSerializer xmlSerileştirici = new XmlSerializer(typeof(Öğrenciler));

            //A3: serileştirme işlemi yapıldı
            xmlSerileştirici.Serialize(hamal, öğrenciler.ÖğrenciListesi);
            //xmlSerileştirici.Serialize(hamal, öğrenciler);

            //A4: Kapat (Hamalı gönder)
            hamal.Close();

            MessageBox.Show("Tüm öğrenciler Xml tipinde serileştirildi.");
        }
    }
} 