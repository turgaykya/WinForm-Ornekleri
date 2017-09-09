using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryBLL:IBusiness<Category, Int32>
    {
        CategoryDAL _categoryDAL = new CategoryDAL();


        public bool Insert(Category item)
        {
            if (string.IsNullOrWhiteSpace(item.CategoryName))
            {
                return false;
            }

            int affectedRows = 0;
            affectedRows = _categoryDAL.Insert(item);

            return affectedRows > 0;
        }
        public bool Update(Category item)
        {
            if (string.IsNullOrWhiteSpace(item.CategoryName))
            {
                return false;
            }

            int affectedRows = 0;
            affectedRows = _categoryDAL.Update(item);

            return affectedRows > 0;
        }
        public bool Delete(Category item)
        {
            int affectedRows = _categoryDAL.Delete(item);
            return affectedRows > 0;
        }
        public Category Get(int id)
        {
            Category cat = _categoryDAL.Get(id);
            return cat;
        }
        public List<Category> GetAll()
        {
            List<Category> catList = _categoryDAL.GetAll();
            return catList;
        }
    }
}
