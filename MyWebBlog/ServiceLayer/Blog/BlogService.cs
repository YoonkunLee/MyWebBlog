﻿using System;
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
