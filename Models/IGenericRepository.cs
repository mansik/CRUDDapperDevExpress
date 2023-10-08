using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapperDevExpress.Models
{
    interface IGenericRepository<T>
    {
        T GetById(int ID);
        IEnumerable<T> GetAll();
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(int ID);
    }
}
