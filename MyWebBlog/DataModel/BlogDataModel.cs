using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.DataModel
{
    public class BlogDataModel
    {
        public Guid Id { get; set; }
        public String writer { get; set; }
        public DateTime date { get; set; }
        public String text { get; set; }
    }
}
