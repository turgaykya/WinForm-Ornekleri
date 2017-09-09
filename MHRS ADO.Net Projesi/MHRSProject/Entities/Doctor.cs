using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Doctor
    {
        
        public Doctor()
        {
            Title = new Title();
        }

        public int ID { get; set; }
        public string TC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public Title Title { get; set; }

        public string FullName { get { return Title.Name + " " + FirstName + " " + LastName; } }
        public override string ToString()
        {
            return FullName;
        }


    }
}
