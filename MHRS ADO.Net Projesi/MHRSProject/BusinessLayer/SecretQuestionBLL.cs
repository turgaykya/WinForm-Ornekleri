using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class SecretQuestionBLL : IBusiness<SecretQuestion, Int32>
    {
        SecretQuestionDAL _secretQuestion;

        public SecretQuestionBLL()
        {
            _secretQuestion = new SecretQuestionDAL();
        }

        public int Insert(SecretQuestion item)
        {
            throw new NotImplementedException();
        }
        public bool Update(SecretQuestion item)
        {
            throw new NotImplementedException();
        }

        public List<SecretQuestion> GetAll()
        {
            List<SecretQuestion> secretQuestionList = _secretQuestion.GetAll();
            return secretQuestionList; // ilk yere gidecek
        }


        public SecretQuestion Get(int id)
        {
            SecretQuestion secretQuestion = _secretQuestion.Get(id);
            return secretQuestion;
        }
    }
}
