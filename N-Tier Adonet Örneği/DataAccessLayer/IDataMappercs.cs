using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface IDataMappercs<TEntity, TKey>    //TEntity classlar   TKey degisken turu gibi şeyler icin
    {
        int Insert(TEntity item);
        int Update(TEntity item);
        int Delete(TEntity item);
        List<Category> GetAll();
        Category Get(int id);
        
    }
}
