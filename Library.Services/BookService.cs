using Library.Data.Models;
using Library.Data.Repository;
using System;
using System.Collections.Generic;

namespace Library.Services
{
    public class BookService
    {

        private BookRepository _repository;

        public BookService(BookRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Book> All()
        {
            return _repository.All();
        }

        public Book AddBook(Book book)
        {
            return _repository.Add(book);
        }
    }
}
