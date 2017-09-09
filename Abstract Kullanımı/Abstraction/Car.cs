using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Car : Vehicle
    {
        public override string Start()
        {
            return "Vızır vızır";
        }
        public override string Stop()
        {
            return "Şıp";
        }
        public override string ToString()
        {
            return "Araba";
        }
    }
}
