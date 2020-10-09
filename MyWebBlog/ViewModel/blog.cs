using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebBlog.Model
{
    class blog
    {
        Guid Id { get; set; }
        Date date { get; set; }
        String text { get; set; }
    }
}
