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
            newBlog.Thumbnail = blog.thumbnail;

            for(var i =0; i<blog.body.Length; i++)
            {
                newBlog.body = newBlog.body + blog.body[i];
            }
            
            newBlog.date = DateTime.Now;

            return newBlog;
        }

        public BlogDetailModel ConvertDataToDetailModel(BlogDataModel data)
        {
            BlogDetailModel blogDetailModel = new BlogDetailModel();
            blogDetailModel.Id = data.Id;
            blogDetailModel.writer = data.writer;
            blogDetailModel.title = data.title;
            blogDetailModel.body = data.body;
            blogDetailModel.date = data.date.ToString("dd/MM/yyyy");
            
            return blogDetailModel;
        }

        public BlogDetailModel ConvertDataToDetailModel(BlogDataModel data, BlogDataModel previous, BlogDataModel next)
        {
            BlogDetailModel blogDetailModel = new BlogDetailModel();
            blogDetailModel.Id = data.Id;
            blogDetailModel.writer = data.writer;
            blogDetailModel.title = data.title;
            blogDetailModel.body = data.body;
            blogDetailModel.date = data.date.ToString("dd/MM/yyyy");
            blogDetailModel.previous = new BlogDetailRecommend();
            blogDetailModel.next = new BlogDetailRecommend();
            blogDetailModel.previous.Id = previous.Id;
            blogDetailModel.previous.Title = previous.title;
            blogDetailModel.previous.Thumbnail = previous.Thumbnail;
            blogDetailModel.next.Id = next.Id;
            blogDetailModel.next.Title = next.title;
            blogDetailModel.next.Thumbnail = next.Thumbnail;
            return blogDetailModel;
        }

        public BlogListViewModel convertDataToListViewModel(BlogDataModel data)
        {
            BlogListViewModel blogListViewModel = new BlogListViewModel();
            blogListViewModel.Id = data.Id;
            blogListViewModel.Author = data.writer;
            blogListViewModel.Title = data.title;           

            DateTime localDate = DateTime.Now;
            if (data.date.Date == localDate.Date)
            {
                blogListViewModel.Date = data.date.ToString("hh:mm tt");
            }
            else
            {
                blogListViewModel.Date = data.date.ToString("dd/MM/yyyy");
            }

            return blogListViewModel;
        }

        public List<BlogListViewModel> convertDataToViewModelList(List<BlogDataModel> dataBlogList)
        {
            List<BlogListViewModel> blogViewModelList = new List<BlogListViewModel>();
            for(var i = 0; i < dataBlogList.Count; i++)
            {
                var result = convertDataToListViewModel(dataBlogList[i]);
                result.Number = i + 1;
                blogViewModelList.Add(result);
            }

            return blogViewModelList;
        }


    }
}   
