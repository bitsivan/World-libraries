using Library.Data.Models;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly BookService _service;
        public BookController(BookService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Book> All()
        {
            return _service.All();
        }

        [HttpPost]
        public Book Add([FromBody]Book book)
        {
            return _service.AddBook(book);
        }

    }
}
