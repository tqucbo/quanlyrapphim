#pragma checksum "D:\BIDC\quanlyrapphim\Views\Message\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1bde6a77f221d522504ae3b999ae3907402953"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Index), @"mvc.1.0.view", @"/Views/Message/Index.cshtml")]
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
#line 1 "D:\BIDC\quanlyrapphim\Views\_ViewImports.cshtml"
using QuanLyRapPhim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BIDC\quanlyrapphim\Views\_ViewImports.cshtml"
using QuanLyRapPhim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1bde6a77f221d522504ae3b999ae3907402953", @"/Views/Message/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da28ab41536e6812e7c21bd057d002424ef93500", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyRapPhim.Models.MessageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BIDC\quanlyrapphim\Views\Message\Index.cshtml"
  
    ViewData["Title"] = Model.title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n    ");
#nullable restore
#line 7 "D:\BIDC\quanlyrapphim\Views\Message\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n<hr>\r\n\r\n<div>");
#nullable restore
#line 11 "D:\BIDC\quanlyrapphim\Views\Message\Index.cshtml"
Write(Model.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 169, "\"", 194, 1);
#nullable restore
#line 13 "D:\BIDC\quanlyrapphim\Views\Message\Index.cshtml"
WriteAttributeValue("", 176, Model.urlRedirect, 176, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Trở về trang chủ</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyRapPhim.Models.MessageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
