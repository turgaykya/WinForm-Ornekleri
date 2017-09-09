using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class TitleBLL : IBusiness<Title,Int32>
    {
        TitleDAL _titleDAL = new TitleDAL(); 

        public int Insert(Title item)
        {
            throw new NotImplementedException();
        }
        public bool Update(Title item)
        {
            throw new NotImplementedException();
        }

        public List<Title> GetAll()
        {
            List<Title> titleList = _titleDAL.GetAll();
            return titleList;
        }

        public Title Get(int id)
        {
            Title title = _titleDAL.Get(id);
            return title;
        }
    }
}
