using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.ViewModel
{
    public class BlogViewModel
    {
        public Guid Id { get; set; }
        public string writer { get; set; }
        public string body { get; set; }
        public string title { get; set; }        
    }
}
