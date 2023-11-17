#pragma checksum "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9e9dd2afc2a518fc3579ebc7a918b757a3bb579dcf56d19ee2e6a67cc2e4c1c5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9e9dd2afc2a518fc3579ebc7a918b757a3bb579dcf56d19ee2e6a67cc2e4c1c5", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c7fe250c90fb26b1817eba50f8362bc8faca3bbdf62c79d683caced0e5776daa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Payment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyRapPhim.Models.MultipleViewModelForPaymentView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("48px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("48px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: auto; max-width: 128px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    
    string getSeatFromSeatModel() {
        string htmlSeat = "";
        foreach(var i in Model.seatModels){
            if (Model.seatModels.IndexOf(i) == 0 && Model.seatModels.IndexOf(i) == Model.seatModels.Count - 1){
                htmlSeat += $"<span>{i.seatName}<span>";
            } else if (Model.seatModels.IndexOf(i) == 0) {
                htmlSeat += $"<span>{i.seatName}, ";
            } else if (Model.seatModels.IndexOf(i) == Model.seatModels.Count - 1) {
                htmlSeat += $"{i.seatName}</span>";
            } else {
                htmlSeat += $"{i.seatName}, ";
            }  
        }
        return htmlSeat;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row no-gutters justify-content-between\">\r\n    <h1 style=\"align-self: self-end;\">\r\n        ");
#nullable restore
#line 32 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </h1>
    <a id=""btnXacNhanMuaVe"" style=""height: min-content; width:100%; max-width: 200px; align-self: self-end;"">
        Thanh toán trong : <span id=""Countdown"">00:00</span>
    </a>
</div>
<hr />


<div class=""row"" style=""display: flex;"">
    <div class=""col-md-7"">
        <h4>Hình thức thanh toán</h4>
        <div class=""pt-2"">
");
#nullable restore
#line 45 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
             foreach (var item in Model.paymentMethodModels){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"display: table; height: 64px;\">\r\n                    <div style=\"display: table-cell; width: fit-content; padding-right: 10px;\">\r\n                        <input");
            BeginWriteAttribute("class", " class=\"", 2073, "\"", 2081, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\" name=\"paymentMethod\"");
            BeginWriteAttribute("value", " value=\"", 2116, "\"", 2147, 1);
#nullable restore
#line 48 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
WriteAttributeValue("", 2124, item.paymentMethodName, 2124, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div style=\"display: table-cell; width: fit-content; padding-right: 10px;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e9dd2afc2a518fc3579ebc7a918b757a3bb579dcf56d19ee2e6a67cc2e4c1c57854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2319, "~/paymentMethod/", 2319, 16, true);
#nullable restore
#line 51 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
AddHtmlAttributeValue("", 2335, item.paymentMethodImage, 2335, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
AddHtmlAttributeValue("", 2366, item.paymentMethodName.ToUpper(), 2366, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 53 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                      
                        var verticalAlign = string.IsNullOrEmpty(item.paymentMethodNote) ? "center" : "top";
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("style", " style=\"", 2639, "\"", 2698, 4);
            WriteAttributeValue("", 2647, "display:", 2647, 8, true);
            WriteAttributeValue(" ", 2655, "table-cell;", 2656, 12, true);
            WriteAttributeValue(" ", 2667, "vertical-align:", 2668, 16, true);
#nullable restore
#line 56 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
WriteAttributeValue(" ", 2683, verticalAlign, 2684, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div>");
#nullable restore
#line 57 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                        Write(item.paymentMethodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div style=\"font-size: small;\">");
#nullable restore
#line 58 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                                  Write(item.paymentMethodNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 61 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\" col-md-5\">\r\n        <div class=\"row no-gutters flex\">\r\n            <div class=\"col-auto\" style=\"position: relative;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e9dd2afc2a518fc3579ebc7a918b757a3bb579dcf56d19ee2e6a67cc2e4c1c511982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3105, "~/poster/", 3105, 9, true);
#nullable restore
#line 67 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
AddHtmlAttributeValue("", 3114, filmPosterImage, 3114, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 67 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
AddHtmlAttributeValue("", 3137, Model.filmSecheduleModel.film.filmName.ToUpper(), 3137, 49, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <span class=\"rounded\"");
            BeginWriteAttribute("style", "\r\n                    style=\"", 3267, "\"", 3393, 12);
            WriteAttributeValue("", 3296, "position:", 3296, 9, true);
            WriteAttributeValue(" ", 3305, "absolute;", 3306, 10, true);
            WriteAttributeValue(" ", 3315, "top:", 3316, 5, true);
            WriteAttributeValue(" ", 3320, "5px;", 3321, 5, true);
            WriteAttributeValue(" ", 3325, "left:", 3326, 6, true);
            WriteAttributeValue(" ", 3331, "5px;", 3332, 5, true);
#nullable restore
#line 69 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
WriteAttributeValue(" ", 3336, filmGenreStyle, 3337, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3352, ";", 3352, 1, true);
            WriteAttributeValue(" ", 3353, "color:", 3354, 7, true);
            WriteAttributeValue(" ", 3360, "white;", 3361, 7, true);
            WriteAttributeValue(" ", 3367, "background-color:", 3368, 18, true);
            WriteAttributeValue(" ", 3385, "orange;", 3386, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <center>\r\n                        <strong style=\"user-select: none;\">");
#nullable restore
#line 71 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                                      Write(filmGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    </center>\r\n                </span>\r\n            </div>\r\n            <div class=\"col no-gutters w-100 pl-2 pr-2\"");
            BeginWriteAttribute("style", " style=\"", 3638, "\"", 3646, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h4>");
#nullable restore
#line 76 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
               Write(Model.filmSecheduleModel.film.filmName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <br>\r\n                <p style=\"font-size: smaller;\">\r\n                    Cụm rạp : <strong>");
#nullable restore
#line 79 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                 Write(Model.cinemaModel.cinemaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </p>\r\n                <p style=\"font-size: smaller;\">\r\n                    Phòng chiếu : <strong>");
#nullable restore
#line 82 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                     Write(Model.filmSecheduleModel.CinemaRoom.cinemaRoomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </p>\r\n                <p style=\"font-size: smaller;\">\r\n                    Suất chiếu: <strong>");
#nullable restore
#line 85 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                   Write(Model.filmSecheduleModel.filmShowTime.ToString(@"hh\:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 85 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                                                                              Write(Model.filmSecheduleModel.filmShowDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <br>    \r\n        <div>\r\n            <p>\r\n                Các ghế đã chọn : <strong>");
#nullable restore
#line 92 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                     Write(Html.Raw(getSeatFromSeatModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </p>\r\n            <p>\r\n                Tổng số tiền phải thanh toán : <strong><span>");
#nullable restore
#line 95 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                                        Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span<span> VND</span></strong>
            </p>
        </div>
        <div>
            <span>
                Nhập mã khuyến mãi : 
            </span>
            <span>
                <input class=""rounded"" type=""text"">
                <input class=""btn-primary rounded"" type=""button"" value=""Kiểm tra"">
            </span>
        </div>
    </div>    
</div>

        


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        var flag = true;

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
                    $(""#btnXacNhanMuaVe"").text(""Đã huỷ thanh toán"");
                    $(""#btnXacNhanMuaVe"").removeClass().addClass(""btn btn-secondary text-white"")
                    flag = false;
                }
            }

            element = document.getElement");
                WriteLiteral(@"ById( elementName );
            endTime = (+new Date) + 1000 * (60*minutes + seconds) + 500;
            updateTimer();
        }
        countdown(""Countdown"", 0, 30 );

        $(document).ready(function(event) {
            if (!$(""input[name='paymentMethod']:checked"").val()){
                $(""#btnXacNhanMuaVe"").removeClass().addClass(""btn btn-secondary text-white"")
            } else {
                $(""#btnXacNhanMuaVe"").removeClass().addClass(""btn btn-primary text-white"")
            }   
        });

        $(""input[name='paymentMethod']"").click(function(event) {
            $(""#btnXacNhanMuaVe"").removeClass().addClass(""btn btn-primary text-white"")
        });

        $(""#btnXacNhanMuaVe"").click(function(event) {
            if ($(""input[name='paymentMethod']:checked"").val() && flag == true){
                $.ajax({
                    type: ""POST"",
                    url: """);
#nullable restore
#line 165 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                     Write(Url.RouteUrl("CreateTicket"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                    data: \r\n                    {\r\n                        \"listIdOfChooseSeat\": JSON.parse(\'");
#nullable restore
#line 168 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                                     Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.seatModels.Select(x => x.seatId).ToList())));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'),\r\n                        \"accountId\": \"99d60d01-64ad-4024-b9bd-8407f6db1514\",\r\n                        \"paymentMethodName\": $(\"input[name=\'paymentMethod\']:checked\").val(),\r\n                        \"price\": JSON.parse(\'");
#nullable restore
#line 171 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                        Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.price)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'),\r\n                        \"filmSecheduleId\": JSON.parse(\'");
#nullable restore
#line 172 "D:\BIDC\QuanLyRapPhim\Views\Payment\Index.cshtml"
                                                  Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.filmSecheduleModel.filmSecheduleId)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'),
                    },
                    traditional: true,
                    success: function(response){
                        window.location.href = response.url
                    },
                });
            }
        });
    </script>
");
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
