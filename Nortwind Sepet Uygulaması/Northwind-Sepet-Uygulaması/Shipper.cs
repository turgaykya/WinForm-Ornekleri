using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Sepet_Uygulaması
{
    class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }

        public override string ToString()
        {
            return CompanyName;
        }
    }
}
