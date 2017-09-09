using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public User()
        {
            SecretQuestion = new SecretQuestion();
            DateOfBirth = new DateTime();
        }
        public int Id { get; set; }
        public string TC { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public SecretQuestion SecretQuestion { get; set; }
        public int SecretID { get; set; }
        public string SecretAnswer { get; set; }
    }
}
