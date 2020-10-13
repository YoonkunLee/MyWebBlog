using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.DataModel
{
    public class BlogDataModel
    {
        public Guid Id { get; set; }
        public string writer { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
