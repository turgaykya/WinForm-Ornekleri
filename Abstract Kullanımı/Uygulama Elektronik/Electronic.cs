using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_Elektronik
{
    abstract class Electronic
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool WithBattery { get; set; }
        public int Inch { get; set; }
        public bool SdCard { get; set; }
    }
}
