using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_Elektronik
{
    abstract class Computer : Electronic
    {
        public int Processor { get; set; }
        public int Ram { get; set; }
        public int HDD { get; set; }

       

    }
}
