using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_Elektronik
{
    abstract class Television : Electronic
    {
        public DisplayConnection DisplayConnection { get; set; }
    }


}
