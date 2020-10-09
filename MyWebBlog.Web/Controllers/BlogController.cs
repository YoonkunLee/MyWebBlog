using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebBlog.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateBlog()
        {
            return View();
        }

        public IActionResult GoToCreateBlog()
        {
            return RedirectToPage("CreactBolg");
        }
    }
}