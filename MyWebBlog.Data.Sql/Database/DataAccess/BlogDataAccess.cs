using System;
using System.Collections.Generic;
using System.Text;
using MyWebBlog.DataModel;
using MyWebBlog.Data.Sql.Database.Setup;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace MyWebBlog.Data.Sql.Database.DataAccess
{
    public class BlogDataAccess
    {
        DatabaseConnection conn;
        public BlogDataAccess()
        {
            conn = new DatabaseConnection();
        }

        public void Create(BlogDataModel blog)
        {
            string sql = "INSERT INTO blog(id, writer, date, title, body) VALUES (@id, @writer, @date, @title, @body)";
            using (var db = conn.ConnectDb())
            {
                var result = db.Execute(sql, blog);
            }
        }

        public List<BlogDataModel> GetBlogList()
        {
            List<BlogDataModel> blogs = new List<BlogDataModel>();
            string sql = "SELECT * FROM blog";
            using(var db = conn.ConnectDb())
            {
                var result = db.Query<BlogDataModel>(sql);   
                foreach(var item in result)
                {
                    blogs.Add(item);
                }   
            }
            
            return blogs;
        }

        public BlogDataModel find(Guid id)
        {
            BlogDataModel blog;
            using(var db = conn.ConnectDb())
            {
                string sql = "SELECT * FROM blog WHERE id = @id";
                blog = db.QueryFirst<BlogDataModel>(sql, new { id = id });                
            }

            return blog;
        }

        public void Update(BlogDataModel blog)
        {
            var sql = @"UPDATE blog SET writer = @writer, date = @date, title = @title, body = @body WHERE id = @id";
            using (var db = conn.ConnectDb())
            {
               
                var result = db.Execute(sql, new
                {
                    blog.writer,
                    blog.date,
                    blog.title,
                    blog.body,
                    blog.Id
                });
            }
        }

        public void Delete(Guid id)
        {
            using(var db = conn.ConnectDb())
            {
                var sql = "DELETE FROM blog WHERE id = @id";
                var result = db.Query(sql, new { id = id });
            }
        }
    }
}   