using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface IDataMapper <TEntity,TKey>
    {
        int Insert(TEntity item);
        int Update(TEntity item);
        List<TEntity> GetAll();
        TEntity Get(TKey id);
    }
}
