using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Repository
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        IEnumerable<T> All();
        T Delete(T entity);
        void SaveChages();
    }
}
