using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _20_WF_XML_Serialization
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKur_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDokuman = new XmlDocument();
            xmlDokuman.Load("Kurlar.xml");

            XmlElement rootEleman = xmlDokuman.DocumentElement;
            XmlNodeList liste = rootEleman.GetElementsByTagName("Currency");

            for (int i = 0; i < liste.Count; i++)
            {
                Döviz d = new Döviz();

                XmlElement currency = liste[i] as XmlElement;
                string isim = currency.GetElementsByTagName("Isim")[0].InnerText;
                string alisFiyatı = currency.GetElementsByTagName("ForexBuying")[0].InnerText;
                string satisFiyatı = currency.GetElementsByTagName("ForexSelling")[0].InnerText;
                string birim = currency.GetElementsByTagName("Unit")[0].InnerText;

                if (!string.IsNullOrEmpty(alisFiyatı))
                    d.AlışFiyatı = Convert.ToDecimal(alisFiyatı);

                if (!string.IsNullOrEmpty(satisFiyatı))
                    d.SatışFiyatı = Convert.ToDecimal(satisFiyatı);

                if (!string.IsNullOrEmpty(birim))
                    d.Birim = Convert.ToInt32(birim);

                d.DövizAdı = isim;

                lstKurBilgileri.Items.Add(d);
            }
        }
    }
}
