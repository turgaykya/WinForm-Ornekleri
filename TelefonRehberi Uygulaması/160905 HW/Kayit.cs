using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _160905_HW
{
    public class Kayit
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
    }

    public class Kayitlar
    {
        public Kayitlar()
        {
            KayitListesi = new List<Kayit>();
        }
        public List<Kayit> KayitListesi { get; set; }
    }
}
