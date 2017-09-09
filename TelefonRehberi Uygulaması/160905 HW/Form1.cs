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

namespace _160905_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int _id = 0;
        Kayitlar kayitlar = new Kayitlar();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _id = _id + 1;
            Kayit kayit = new Kayit();
            kayit.Ad = txtAdıK.Text;
            kayit.Soyad = txtSoyadıK.Text;
            kayit.Telefon = mtxtTelK.Text;
            kayit.Id = _id;

            lstKayitliTel.Items.Add(kayit.Id + "- " + kayit.Ad + " " + kayit.Soyad);


            lstKayitliTel.Tag = kayit;
            MessageBox.Show("Yeni Kayıt eklenmiştir.");

            kayitlar.KayitListesi.Add(kayit);

            FileStream hamal = File.Create("KayitliTelefonlar.xml");
            XmlSerializer xmlSerileştirici = new XmlSerializer(typeof(List<Kayit>));
            xmlSerileştirici.Serialize(hamal, kayitlar.KayitListesi);
            hamal.Close();
            MessageBox.Show("Tüm kayıtlar Xml tipinde serileştirildi.");
            txtAdıK.Text = "";
            txtSoyadıK.Text = "";
            mtxtTelK.Text = "";
         

        }
    }
}
