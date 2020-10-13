using System;
using System.Collections.Generic;
using System.Text;
using MyWebBlog.DataModel;
using MyWebBlog.ViewModel;

namespace MyWebBlog.ServiceLayer.Blog
{
    public class BlogService
    {       
        public BlogDataModel CreateNewBlog(BlogViewModel blog)
        {
            BlogDataModel newBlog = CreateBlogDataModel(blog);
            newBlog.Id = Guid.NewGuid();
            return newBlog;
        }

        public BlogDataModel CreateBlogDataModel(BlogViewModel blog)
        {
            BlogDataModel newBlog = new BlogDataModel();            
            newBlog.writer = blog.writer;
            newBlog.title = blog.title;
            newBlog.body = blog.body;
            newBlog.date = DateTime.Now;

            return newBlog;
        }

        public BlogViewModel convertDataToViewModel(BlogDataModel data)
        {
            BlogViewModel blogViewModel = new BlogViewModel();
            blogViewModel.Id = data.Id;
            blogViewModel.writer = data.writer;
            blogViewModel.title = data.title;
            blogViewModel.body = data.body;

            return blogViewModel;
        }

        public List<BlogViewModel> convertDataToViewModelList(List<BlogDataModel> dataBlogList)
        {
            List<BlogViewModel> blogViewModelList = new List<BlogViewModel>();
            foreach (var item in dataBlogList)
            {        
                blogViewModelList.Add(convertDataToViewModel(item));
            }

            return blogViewModelList;
        }


    }
}   
