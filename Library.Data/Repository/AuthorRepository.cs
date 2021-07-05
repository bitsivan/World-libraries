using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Repository
{
    public class AuthorRepository: GenericRepository<Author>
    {
        public AuthorRepository(LibraryDbContext context) : base(context)
        {

        }

        public IEnumerable<Author> All()
        {
            return base.All();
        }

        public override Author Add(Author entity)
        {
            var _author = base.Add(entity);
            base.SaveChages();
            return _author;
        }
    }
}
