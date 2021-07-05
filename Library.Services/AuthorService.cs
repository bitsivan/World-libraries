using Library.Data.Models;
using Library.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Services
{
    public class AuthorService
    {
        private IRepository<Author> _repository;

        public AuthorService(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Author> All()
        {
            return _repository.All();
        }

        public Author AddBook(Author author)
        {
            return _repository.Add(author);
        }
    }
}
