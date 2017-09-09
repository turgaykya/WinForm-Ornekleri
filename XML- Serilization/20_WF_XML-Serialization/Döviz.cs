using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_WF_XML_Serialization
{
    public class Döviz
    {
        public string DövizAdı { get; set; }
        public decimal AlışFiyatı { get; set; }
        public decimal SatışFiyatı { get; set; }
        public int Birim { get; set; }

        public override string ToString()
        {
            return DövizAdı;
        }
    }
}
