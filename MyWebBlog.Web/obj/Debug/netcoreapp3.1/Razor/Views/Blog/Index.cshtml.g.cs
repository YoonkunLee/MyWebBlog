#pragma checksum "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "150bbcb03c93a96b00074f7801e8d4755e8427cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\_ViewImports.cshtml"
using MyWebBlog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\_ViewImports.cshtml"
using MyWebBlog.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"150bbcb03c93a96b00074f7801e8d4755e8427cb", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b27b7d6d3dacdd6444f0758d58eb085efde097", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyWebBlog.ViewModel.BlogViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog List</h1>\r\n<a");
            BeginWriteAttribute("href", " href=\'", 113, "\'", 152, 1);
#nullable restore
#line 7 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 120, Url.Action("BlogCreate","Blog"), 120, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <input type=\"button\" value=\"Create\" />\r\n</a>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <td>Title</td>\r\n            <td>Author</td>\r\n            <td>Functions</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\Blog\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\Blog\Index.cshtml"
               Write(Html.ActionLink(item.title, "BlogDetail", "Blog", new {id = item.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\Blog\Index.cshtml"
               Write(item.writer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\Blog\Index.cshtml"
               Write(Html.ActionLink("Update", "BlogUpdate", "Blog", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 27 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\Blog\Index.cshtml"
               Write(Html.ActionLink("Delete", "BlogDelete", "Blog", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Yoonkun Lee\Desktop\YK_Folder\MyWebBlog\MyWebBlog.Web\Views\Blog\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyWebBlog.ViewModel.BlogViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
