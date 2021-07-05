using Library.Data.Models;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldLibrary.Controllers
{
    public class AuthorController : Controller
    {
        private readonly AuthorService _service;
        public AuthorController(AuthorService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Author> All()
        {
            return _service.All();
        }

        [HttpPost]
        public Author Add([FromBody] Author author)
        {
            return _service.AddBook(author);
        }
    }
}
