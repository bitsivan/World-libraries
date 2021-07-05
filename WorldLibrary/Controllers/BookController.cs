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
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test");
        }
    }
}
