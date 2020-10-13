using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebBlog.ViewModel;
using MyWebBlog.DataModel;
using MyWebBlog.ServiceLayer.Blog;
using MyWebBlog.Data.Sql.Database.DataAccess;

namespace MyWebBlog.Web.Controllers
{
    public class BlogController : Controller
    {
        BlogService blogservice;
        BlogDataAccess _blog;

        public BlogController()
        {
            blogservice = new BlogService();
            _blog = new BlogDataAccess();
        }

        public IActionResult Index()
        {
            var blogList = _blog.GetBlogList();
            var resultViewModel = blogservice.convertDataToViewModelList(blogList);

            return View(resultViewModel);
        }
        
        public IActionResult SendBlogItem(BlogViewModel blog)
        {
            BlogDataModel newBlog = blogservice.CreateNewBlog(blog);
            _blog.Create(newBlog);
            
            return View("Index");            
        }


        public IActionResult BlogCreate()
        {
            BlogViewModel blog = new BlogViewModel();
            blog.writer = "Yoonkun Lee";
            return View(blog);
        }

        public IActionResult GoToCreateBlog()
        {
            return View("CreateBlog");
        }

        public IActionResult BlogDetail(Guid id)
        {
            BlogDataModel foundBlog = _blog.find(id);
            var blog = blogservice.convertDataToViewModel(foundBlog);

            return View(blog);
        }
        
        public IActionResult BlogUpdate(Guid id)
        {
            BlogDataModel foundBlog = _blog.find(id);
            var blog = blogservice.convertDataToViewModel(foundBlog);

            return View(blog);
        }
        [HttpPost]
        [Route("Blog/BlogUpdate/{id?}")]
        public IActionResult BlogUpdate(BlogViewModel blog)
        {

            var updateBlog = blogservice.CreateBlogDataModel(blog);
            updateBlog.Id = blog.Id;
            _blog.Update(updateBlog);

            return View("Index");
        }

        public IActionResult BlogDelete(Guid id)
        {
            _blog.Delete(id);
                
            return View("Index");
        }
    }
}