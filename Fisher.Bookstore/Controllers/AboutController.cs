using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("About Controller's Index Action");
        }

        public IActionResult History()
        {
            return Content("About Controller's History Action");
        }

        public IActionResult Location()
        {
            return Content("About Controller's Location Action");
        }
    }
}