using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class SecretQuestion
    {

       
        public int Id { get; set; }
        public string Question { get; set; }

        public override string ToString()
        {
            return Question;
        }
    }
}
