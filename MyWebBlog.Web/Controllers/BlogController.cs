using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebBlog.ViewModel;
using MyWebBlog.

namespace MyWebBlog.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult SendBlogItem(BlogViewModel blog)
        {
            
        }


        public IActionResult CreateBlog()
        {
            BlogViewModel blog = new BlogViewModel();
            blog.date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            blog.writer = "Yoonkun Lee";
            return View(blog);
        }

        public IActionResult GoToCreateBlog()
        {
            return RedirectToPage("CreactBlog");
        }
    }
}