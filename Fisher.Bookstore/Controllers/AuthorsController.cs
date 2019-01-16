using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("AuthorsController's Index Action");
        }
        public IActionResult Featured()
        {
            return Content("AuthorsController's Featured Action");
        }
    }
}