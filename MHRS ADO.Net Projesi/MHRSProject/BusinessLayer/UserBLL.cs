using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public class UserBLL : IBusiness<User,Int32>
    {
        UserDAL _userDAL = new UserDAL();
        public int Insert(User item)
        {
            int userInsertAffected = _userDAL.Insert(item);
            return userInsertAffected;
        
        }
        public bool Update(User item)
        {
            int temp = _userDAL.Update(item);

            if (temp == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
  
        }
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }
        public User Get(int id)
        {
            User user = _userDAL.Get(id);
            return user;
        }

        public int LoginControl(string TC, string Password)
        {
            int loginControl = _userDAL.LoginControl(TC, Password);
            return loginControl;
        }

        public User SendPassword(string TC)
        {
            User user = _userDAL.SendPassword(TC);
            return user;
        }
    }
}
