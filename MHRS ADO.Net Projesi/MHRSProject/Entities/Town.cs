using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CityLicensePlate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
