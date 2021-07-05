using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public override Book Add(Book entity)
        {
            var _book= base.Add(entity);
            base.SaveChages();
            return _book;
        }

        public override Book Update(Book entity)
        {
            var _book = _context.Books.Single(p => p.Id == entity.Id);

            _book.Name = entity.Name;
            _book.Description = entity.Description;
            _book.UrlPath = entity.UrlPath;

            base.Update(_book);
            base.SaveChages();
            return _book;
        }

        public override Book Delete(Book entity)
        {
            var _book = _context.Books.Single(p => p.Id == entity.Id);

            base.Delete(entity);
            base.SaveChages();
            return _book;
        }
    }
}
