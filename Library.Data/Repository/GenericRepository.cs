using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public abstract class GenericRepository <T>: IRepository<T> where T : class
    {
        protected LibraryDbContext _context;
        public GenericRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public virtual T Add(T entity)
        {
            return _context.Add(entity)
                    .Entity;

        }

        public virtual IEnumerable<T> All()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T Delete(T entity)
        {
            return _context.Remove(entity)
                .Entity;
        }

        public virtual void SaveChages()
        {
            _context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return _context.Update(entity)
                .Entity;
        }

    }
}
