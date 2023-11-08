#pragma checksum "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96e9f790bbb8286b9c725994543fe55f325162bb8bde25ab1d26f52ce7e9da04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"96e9f790bbb8286b9c725994543fe55f325162bb8bde25ab1d26f52ce7e9da04", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c7fe250c90fb26b1817eba50f8362bc8faca3bbdf62c79d683caced0e5776daa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Payment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyRapPhim.Models.MultipleViewModelForPaymentView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: auto; max-width: 197px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Thanh toán";

    var filmPosterImage = System.IO.File.Exists($"{System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "wwwroot")}/poster/{Model.filmSecheduleModel.film.filmPosterImage}") ? Model.filmSecheduleModel.film.filmPosterImage : "noimageavailable.jpg";
    var filmGenre = string.IsNullOrEmpty(Model.filmSecheduleModel.film.filmGenreId) ? "" :
            Model.filmSecheduleModel.film.filmGenre.filmGenreName;
            var filmGenreStyle = string.IsNullOrEmpty(Model.filmSecheduleModel.film.filmGenreId) ? "" : "width: 48px; height: 27px";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row no-gutters justify-content-between\">\r\n    <h1 style=\"align-self: self-end;\">\r\n        ");
#nullable restore
#line 15 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </h1>
    <a class=""btn btn-primary text-white"" id=""btnXacNhanMuaVe"" style=""height: min-content; width:100%; max-width: 200px; align-self: self-end;"">
        Thanh toán trong : <span id=""Countdown"">00:00</span>
    </a>
</div>
<hr />

<div class=""container"">
<div class=""row"" style=""display: flex;"">
    <div class="" col-md-6 bg-info"">
        <p >Mã khuyến mãi</p>
    </div>
    <div class="" col-md-6"">
        <div class=""row no-gutters flex"">
            <div class=""col-auto"" style=""position: relative;"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "96e9f790bbb8286b9c725994543fe55f325162bb8bde25ab1d26f52ce7e9da045250", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1352, "~/poster/", 1352, 9, true);
#nullable restore
#line 31 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
AddHtmlAttributeValue("", 1361, filmPosterImage, 1361, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
AddHtmlAttributeValue("", 1384, Model.filmSecheduleModel.film.filmName.ToUpper(), 1384, 49, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <span class=\"rounded\"");
            BeginWriteAttribute("style", "\r\n                    style=\"", 1514, "\"", 1640, 12);
            WriteAttributeValue("", 1543, "position:", 1543, 9, true);
            WriteAttributeValue(" ", 1552, "absolute;", 1553, 10, true);
            WriteAttributeValue(" ", 1562, "top:", 1563, 5, true);
            WriteAttributeValue(" ", 1567, "5px;", 1568, 5, true);
            WriteAttributeValue(" ", 1572, "left:", 1573, 6, true);
            WriteAttributeValue(" ", 1578, "5px;", 1579, 5, true);
#nullable restore
#line 33 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
WriteAttributeValue(" ", 1583, filmGenreStyle, 1584, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1599, ";", 1599, 1, true);
            WriteAttributeValue(" ", 1600, "color:", 1601, 7, true);
            WriteAttributeValue(" ", 1607, "white;", 1608, 7, true);
            WriteAttributeValue(" ", 1614, "background-color:", 1615, 18, true);
            WriteAttributeValue(" ", 1632, "orange;", 1633, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <center>\r\n                        <strong style=\"user-select: none;\">");
#nullable restore
#line 35 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                                      Write(filmGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    </center>\r\n                </span>\r\n            </div>\r\n            <div class=\"col no-gutters w-100 pl-2 pr-2\"");
            BeginWriteAttribute("style", " style=\"", 1885, "\"", 1893, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h4>");
#nullable restore
#line 40 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
               Write(Model.filmSecheduleModel.film.filmName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <br>\r\n                <p>\r\n                    Cụm rạp : <strong>");
#nullable restore
#line 43 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                 Write(Model.cinemaModel.cinemaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </p>\r\n                <p>\r\n                    Phòng chiếu : <strong>");
#nullable restore
#line 46 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                     Write(Model.filmSecheduleModel.CinemaRoom.cinemaRoomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </p>\r\n                <p>\r\n                    Suất chiếu: <strong>");
#nullable restore
#line 49 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                   Write(Model.filmSecheduleModel.filmShowTime.ToString(@"hh\:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 49 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                                                                              Write(Model.filmSecheduleModel.filmShowDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div>\r\n            <p>\r\n                Các ghế đã chọn : <strong>");
#nullable restore
#line 55 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                     Write(Model.seats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </p>\r\n            <p>\r\n                Tổng số tiền phải thanh toán : <strong><span>");
#nullable restore
#line 58 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                                        Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span<span>000 VND</span></strong>\r\n            </p>\r\n        </div>\r\n    </div>    \r\n</div>\r\n</div>\r\n        \r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function countdown( elementName, minutes, seconds )
        {
            var element, endTime, mins, msLeft, time;

            function twoDigits( n )
            {
                return (n <= 9 ? ""0"" + n : n);
            }

            function updateTimer()
            {
                msLeft = endTime - (+new Date);
                if ( msLeft >= 0 ) {
                    time = new Date(msLeft);
         
                    mins = time.getUTCMinutes();
                    element.innerHTML = twoDigits(mins) + ':' + twoDigits( time.getUTCSeconds() );
                    setTimeout( updateTimer, time.getUTCMilliseconds() + 500 );
                } else {
                    $(""#btnXacNhanMuaVe"").text(""Đã huỷ thanh toán"")
                }
            }

            element = document.getElementById( elementName );
            endTime = (+new Date) + 1000 * (60*minutes + seconds) + 500;
            updateTimer();
        }
        countdown(""Countdown""");
                WriteLiteral(", 5, 0 );\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyRapPhim.Models.MultipleViewModelForPaymentView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
