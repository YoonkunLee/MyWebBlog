#pragma checksum "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1058edf1ebbe1576c8a812d4aebca2e9156f402"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogCreate), @"mvc.1.0.view", @"/Views/Blog/BlogCreate.cshtml")]
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
#line 1 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\_ViewImports.cshtml"
using MyWebBlog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\_ViewImports.cshtml"
using MyWebBlog.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1058edf1ebbe1576c8a812d4aebca2e9156f402", @"/Views/Blog/BlogCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b27b7d6d3dacdd6444f0758d58eb085efde097", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebBlog.ViewModel.BlogViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
  
    ViewData["Title"] = "CreateBlog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create Blog</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
 using (Html.BeginForm("SendBlogItem", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
Write(Html.LabelFor(m => m.writer, new { @value = @Model.writer }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
Write(Html.TextBoxFor(m => m.writer));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
Write(Html.LabelFor(m => m.title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
Write(Html.TextBoxFor(m => m.title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
Write(Html.LabelFor(m => m.body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
Write(Html.TextAreaFor(m => m.body, new { @class = "textboxsize" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 16 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebBlog.ViewModel.BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
