#pragma checksum "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fae04de7062fb74fdb0105930ed98c2d1e5128f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fae04de7062fb74fdb0105930ed98c2d1e5128f", @"/Views/Blog/BlogCreate.cshtml")]
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
Write(Html.LabelFor(m => m.thumbnail));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
Write(Html.TextBoxFor(m => m.thumbnail));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
Write(Html.LabelFor(m => m.body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
Write(Html.TextAreaFor(m => m.body, new { @style = "display:none", @id = "hidden" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"body\"></div>\r\n");
            WriteLiteral("    <button type=\"submit\" onclick=\"insert()\" id=\"saveData\">Save ssss</button>\r\n");
#nullable restore
#line 20 "C:\Users\Yoonkun Lee\Desktop\projects\MyWebBlog\MyWebBlog.Web\Views\Blog\BlogCreate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js""></script>
<script src=""https://code.jquery.com/jquery-1.11.0.min.js""></script>
<script src=""https://cdn.quilljs.com/1.3.6/quill.js""></script>
<link href=""https://cdn.quilljs.com/1.3.6/quill.snow.css"" rel=""stylesheet"">

<script>

    var toolbarOptions = [
        [{ header: [1, 2, 3, 4, 5, 6, false] }],
        ['bold', 'italic', 'underline'],
        [{ 'color': [] }, { 'background': [] }],
        ['blockquote', 'code-block'],
        [{ 'list': 'ordered' }, { 'list': 'bullet' }],
        [{ 'indent': '-1' }, { 'indent': '+1' }],
        [{ 'direction': 'rtl' }, { 'direction': 'cnt' }],
        ['link', 'image', 'video']
    ];

    var quill = new Quill('#body', {
        modules: {
            toolbar: toolbarOptions
        },
        theme: 'snow'
    });

    function insert() {
        window.delta = quill.getContents();
        var text = window.delta.ops;
        console.log(quill.container.f");
            WriteLiteral("irstChild.innerHTML);\r\n\r\n        $(\"#hidden\").val(quill.container.firstChild.innerHTML);\r\n\r\n    };\r\n</script>");
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
