using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.Repository
{
    public class BookRepository:GenericRepository<Book>
    {
        public BookRepository(LibraryDbContext context):base(context)
        {

        }

        public IEnumerable<Book> All()
        {
            return base.All();
        }

        public Book AddBook(Book entity)
        {
            var _book= base.Add(entity);
            base.SaveChages();
            return _book;
        }
    }
}
