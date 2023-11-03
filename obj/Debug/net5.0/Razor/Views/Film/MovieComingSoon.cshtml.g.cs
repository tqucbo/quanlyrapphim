#pragma checksum "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f0e0a651e5781961988214413c014b91ef9324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_MovieComingSoon), @"mvc.1.0.view", @"/Views/Film/MovieComingSoon.cshtml")]
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
#line 1 "D:\BIDC\QuanLyRapPhim\Views\_ViewImports.cshtml"
using QuanLyRapPhim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BIDC\QuanLyRapPhim\Views\_ViewImports.cshtml"
using QuanLyRapPhim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f0e0a651e5781961988214413c014b91ef9324", @"/Views/Film/MovieComingSoon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da28ab41536e6812e7c21bd057d002424ef93500", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Film_MovieComingSoon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<QuanLyRapPhim.Models.FilmModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("197px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("271px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BuyTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
  
    ViewData["Title"] = "Phim sắp chiếu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>");
#nullable restore
#line 8 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr />\r\n<ul class=\"list-unstyled\" style=\"    \r\n        display: grid;\r\n        grid-template-columns: repeat(auto-fill, 197px);\r\n        justify-content: space-between;\">\r\n");
#nullable restore
#line 14 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
 foreach (var item in Model)
{
        var filmGenre = string.IsNullOrEmpty(item.filmGenreId) ? "" : item.filmGenre.filmGenreName;
        var filmGenreStyle = string.IsNullOrEmpty(item.filmGenreId) ? "" : "width: 48px; height: 27px";
        var filmMainCategory = string.IsNullOrEmpty(item.filmMainCategoryId) ? "Chưa xác định" : item.filmMainCategory.filmMainCategoryName;
        var filmLength = item.filmLength == -1 ||  item.filmLength == 0 ? "Chưa xác định" : $"{item.filmLength} phút";
        var filmStartDate = item.filmStartDate.HasValue ? string.Format("{0:dd/MM/yyyy}", item.filmStartDate) : "Chưa xác định";
        var filmPosterImage = item.filmPosterImage ?? "noimageavailable.jpg";
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"position: relative; margin-bottom: 30px;\">\r\n                <span class=\"rounded\"");
            BeginWriteAttribute("style", " style=\"", 1126, "\"", 1231, 12);
            WriteAttributeValue("", 1134, "position:", 1134, 9, true);
            WriteAttributeValue(" ", 1143, "absolute;", 1144, 10, true);
            WriteAttributeValue(" ", 1153, "top:", 1154, 5, true);
            WriteAttributeValue(" ", 1158, "5px;", 1159, 5, true);
            WriteAttributeValue(" ", 1163, "left:", 1164, 6, true);
            WriteAttributeValue(" ", 1169, "5px;", 1170, 5, true);
#nullable restore
#line 24 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
WriteAttributeValue(" ", 1174, filmGenreStyle, 1175, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1190, ";", 1190, 1, true);
            WriteAttributeValue(" ", 1191, "color:", 1192, 7, true);
            WriteAttributeValue(" ", 1198, "white;", 1199, 7, true);
            WriteAttributeValue(" ", 1205, "background-color:", 1206, 18, true);
            WriteAttributeValue(" ", 1223, "orange;", 1224, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <center>\r\n                        <strong style=\"user-select: none;\">");
#nullable restore
#line 26 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
                                                      Write(filmGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    </center>\r\n                </span>\r\n                <div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47f0e0a651e5781961988214413c014b91ef93248767", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1454, "~/poster/", 1454, 9, true);
#nullable restore
#line 30 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
AddHtmlAttributeValue("", 1463, filmPosterImage, 1463, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
AddHtmlAttributeValue("", 1486, item.filmName.ToUpper(), 1486, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div style=\"height: 175px;\">\r\n                    <div>\r\n                        <span><strong>");
#nullable restore
#line 34 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
                                 Write(item.filmName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\r\n                    </div>\r\n                    <div>\r\n                        <span class=\"font-weight-bold\">Thể loại : </span>\r\n                        <span>");
#nullable restore
#line 38 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
                         Write(filmMainCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div>\r\n                        <span class=\"font-weight-bold\">Thời lượng : </span>\r\n                        <span>");
#nullable restore
#line 42 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
                         Write(filmLength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div>\r\n                        <span class=\"font-weight-bold\">Khởi chiếu : </span>\r\n                        <span>");
#nullable restore
#line 46 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
                         Write(filmStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div >\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f0e0a651e5781961988214413c014b91ef932412508", async() => {
                WriteLiteral("\r\n                        Mua vé");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filmId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
                             WriteLiteral(item.filmId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filmId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("    \r\n            </li>\r\n");
#nullable restore
#line 53 "D:\BIDC\QuanLyRapPhim\Views\Film\MovieComingSoon.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral(" </ul>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<QuanLyRapPhim.Models.FilmModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
