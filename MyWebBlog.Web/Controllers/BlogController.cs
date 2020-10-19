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
            
            return RedirectToAction("Index", "Blog");            
        }

        public IActionResult BlogCreate()
        {
            BlogViewModel blog = new BlogViewModel();
            blog.writer = "Yoonkun Lee";
            return View(blog);
        }

        public IActionResult BlogDetail(Guid id)
        {
            BlogDataModel foundBlog = _blog.find(id);
            var list = _blog.GetBlogList();
            BlogDataModel previous = new BlogDataModel();
            BlogDataModel next = new BlogDataModel();
            
            for (var i=0; i<list.Count; i++)
            {
                if(foundBlog.date == list[i].date)
                {
                    if((i - 1) >= 0 )
                    {
                        previous = list[i - 1];
                    }                   
                    if((i+1) != list.Count)
                    {
                        next = list[i + 1];
                    }                   
                }
            }

            var blog = blogservice.ConvertDataToDetailModel(foundBlog, previous, next);

            return View(blog);
        }
        
        public IActionResult BlogUpdate(Guid id)
        {
            BlogDataModel foundBlog = _blog.find(id);
            var blog = blogservice.ConvertDataToDetailModel(foundBlog);

            return View(blog);
        }
        [HttpPost]
        [Route("Blog/BlogUpdate/{id?}")]
        public IActionResult BlogUpdate(BlogViewModel blog)
        {

            var updateBlog = blogservice.CreateBlogDataModel(blog);
            updateBlog.Id = blog.Id;
            _blog.Update(updateBlog);

            return RedirectToAction("Index", "Blog");
        }

        public IActionResult BlogDelete(Guid id)
        {
            _blog.Delete(id);

            return RedirectToAction("Index", "Blog");
        }
    }
}