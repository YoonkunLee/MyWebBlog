using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.ViewModel
{
    public class BlogViewModel
    {
        public Guid Id { get; set; }
        public String date { get; set; }
        public String writer { get; set; }
        public String text { get; set; }        
    }
}
