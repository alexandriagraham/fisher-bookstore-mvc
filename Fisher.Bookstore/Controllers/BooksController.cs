using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    [Route("books")]
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View();
        }
        [Route("best-sellers")]
        public IActionResult BestSellers()
        {
            return View();
        }

    }
}