using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Truck : Vehicle
    {
        
        public int LoadCapacity { get; set; }



        public override string Start()
        {
            return "Gür gür gür gür gür";
        }

        public override string Stop()
        {
            return "Ippsssssss";
        }


        public override string Horn()
        {
            return "Zipbapbappauuunn";
        }

        public override string ToString()
        {
            return "Kamyon";
        }
    }
}
