using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_Elektronik
{
    abstract class Phone : Electronic
    {
        public int Processor { get; set; }
        public int Ram { get; set; }
        public int HDD { get; set; }
        public int Camera { get; set; }
        public ConnectionType ConnectionType { get; set; }
    }
}
