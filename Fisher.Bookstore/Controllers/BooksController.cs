using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("BooksController's Index Action");
        }
        public IActionResult New()
        {
            return Content("BooksController's New Action");
        }
        public IActionResult BestSellers()
        {
            return Content("BooksController's Best Action");
        }

    }
}