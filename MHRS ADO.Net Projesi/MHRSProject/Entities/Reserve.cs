using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Reserve
    {
        public Reserve()
        {
            Doctor = new Doctor();
            Clinic = new Clinic();
            Policlinic = new Policlinic();
            Hospital = new Hospital(); 
        }

        public int Id { get; set; }
        public int UserID { get; set; }
        public int hcpdID { get; set; } //?
        public Doctor Doctor { get; set; }
        public Clinic Clinic { get; set; } 
        public Policlinic Policlinic { get; set; }
        public Hospital Hospital { get; set; }
        public DateTime ReserveDate { get; set; }
        public DateTime ReserveTime { get; set; }
        public bool IsPassed { get; set; }
        public bool IsDrop { get; set; }
    


    }
}
