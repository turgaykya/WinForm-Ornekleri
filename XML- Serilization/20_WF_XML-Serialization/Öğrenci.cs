using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _20_WF_XML_Serialization
{
    public class Öğrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OkulNo { get; set; }
        public DateTime DoğumTarihi { get; set; }

        [XmlIgnore]
        public int Yaş { get; set; }
    }

    public class Öğrenciler
    {
        public Öğrenciler()
        {
            ÖğrenciListesi = new List<Öğrenci>();
        }
        public List<Öğrenci> ÖğrenciListesi { get; set; }
    }
}
