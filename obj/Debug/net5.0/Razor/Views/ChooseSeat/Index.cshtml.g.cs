#pragma checksum "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a22186f3f8bcfa949c9fd1df9a98a77cb9e6ada7e1661750e7a219aeb273397a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChooseSeat_Index), @"mvc.1.0.view", @"/Views/ChooseSeat/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a22186f3f8bcfa949c9fd1df9a98a77cb9e6ada7e1661750e7a219aeb273397a", @"/Views/ChooseSeat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c7fe250c90fb26b1817eba50f8362bc8faca3bbdf62c79d683caced0e5776daa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ChooseSeat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyRapPhim.Models.MultipleViewModelForChooseSeatView>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
  
    ViewData["Title"] = "Chọn ghế";

    var SeatRow = Model.seatModels.Select(sr => sr.seatRowChar).Distinct().ToList();

    var seatCategories = Model.seatModels.Select(sc => new
    {
        CategoryName = sc.seatCategory.seatCategoryName,
        CategoryPrice =
    sc.seatCategory.seatCategoryPrice
    }).Distinct().ToList();

    string GetSeatModelsBySeatRow(char rowChar)
    {
        string htmlRaw = "";
        var seats = (from s in Model.seatModels
                     where s.seatRowChar == rowChar
                     select s).ToList();
        seats.ForEach(
        s =>
        {
            string seatColor = s.seatCategory.seatCategoryName.Contains("Standard")
    ? "btn-primary"
    : s.seatCategory.seatCategoryName.Contains("VIP")
    ? "btn-danger"
    : s.seatCategory.seatCategoryName.Contains("Premium")
    ? "btn-info"
    : "btn-success";
            htmlRaw = htmlRaw + $@"<td><a class=""btn {seatColor}"" style=""width: 100%; max-width: 50px; color: white;""
id=""{s.seatRowChar}{s.seatColumnNumber}"" onClick=""chooseSeat('{s.seatRowChar}', {s.seatColumnNumber},
{s.seatCategory.seatCategoryPrice}, this.className)"">{s.seatRowChar}{s.seatColumnNumber}</a></td>";
        }
        );
        return htmlRaw;
    }


    string GetAllSeatCategory()
    {
        string htmlRaw = $@"";
        foreach (var i in seatCategories)
        {
            string seatColor = i.CategoryName.Contains("Standard")
            ? "bg-primary"
            : i.CategoryName.Contains("VIP")
            ? "bg-danger"
            : i.CategoryName.Contains("Premium")
            ? "bg-info"
            : "bg-success";
            htmlRaw = htmlRaw + $@"<div class=""d-flex mt-1""><div class=""{seatColor} rounded mr-2"" style=""width: 25px; height:
25px;""></div>"
            + $@"<div>{i.CategoryName} - {i.CategoryPrice}VND/ghế</div></div>";
        }
        htmlRaw = htmlRaw + $@"<div class=""d-flex mt-1""><div class=""bg-secondary rounded mr-2"" style=""width: 25px; height:
25px;""></div><div>Không thể chọn</div></div>";
        return htmlRaw;
    }

    string formatPrice(int price)
    {
        var ni = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name).NumberFormat;
        ni.NumberDecimalDigits = 0; //Keep the ".00" from appearing
        ni.NumberGroupSeparator = " "; //Set the group separator to a space
        ni.NumberGroupSizes = new int[] { 3 }; //Groups of 3 digits

        return price.ToString("N", ni);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row no-gutters justify-content-between\">\r\n    <h1 style=\"align-self: self-end;\">\r\n        ");
#nullable restore
#line 74 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </h1>
    <a class=""btn btn-primary text-white"" id=""btnThanhToan""
        style=""height: min-content; width:100%; max-width: 150px; align-self: self-end;"">
        <span id=""soTien"">0</span><span> VND</span>
    </a>
</div>

<hr />

<div class=""container bg-warning w-100 rounded"">
    <div>Cụm rạp : <strong>");
#nullable restore
#line 85 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
                      Write(Model.cinemaModel.cinemaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> | Phòng chiếu :\r\n        <strong>");
#nullable restore
#line 86 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
           Write(Model.filmSecheduleModel.CinemaRoom.cinemaRoomName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n    <div>Suất chiếu: <strong>");
#nullable restore
#line 88 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
                        Write(Model.filmSecheduleModel.filmShowTime.ToString(@"hh\:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 89 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
       Write(Model.filmSecheduleModel.filmShowDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> | Số ghế còn lại : <strong\r\n            id=\"remainSeats\"></strong></div>\r\n</div>\r\n\r\n<center>\r\n    <p class=\"text-secondary\" style=\"margin-top: 25px; margin-bottom: 50px;\">\r\n        --- MÀN HÌNH ---\r\n    </p>\r\n    <table>\r\n");
#nullable restore
#line 98 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
         foreach (var i in SeatRow)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                ");
#nullable restore
#line 101 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
           Write(Html.Raw(GetSeatModelsBySeatRow(i)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 103 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</center>\r\n\r\n<center>\r\n    <div class=\"row no-gutters justify-content-around mt-3 w-75\">\r\n        ");
#nullable restore
#line 109 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
   Write(Html.Raw(GetAllSeatCategory()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</center>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var listOfChooseSeat = [];\r\n\r\n        var listOfBoughtSeat = JSON.parse(\'");
#nullable restore
#line 117 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
                                      Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.seatModelsBought.Select(s => s.seatName).ToList())));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n\r\n        var numberOfSeat = parseInt(JSON.parse(\'");
#nullable restore
#line 119 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
                                           Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.seatModels.ToList().Count)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'));\r\n\r\n        var numberOfBoughtSeat = parseInt(JSON.parse(\'");
#nullable restore
#line 121 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
                                                 Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.seatModelsBought.ToList().Count)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'));

        var numberOfRemainSeat = numberOfSeat - numberOfBoughtSeat;

        $(document).ready(function (event) {
            $.each(listOfBoughtSeat, function (index, value) {
                $(""#"".concat(value)).removeClass();
                $(""#"".concat(value)).addClass(""btn btn-secondary"");
                $(""#"".concat(value)).prop(""onclick"", null);
            });

            $(""#remainSeats"").text("""".concat(numberOfRemainSeat).concat(""/"").concat(numberOfSeat));
        });

        $(""#btnThanhToan"").click(function (event) {
            if (listOfChooseSeat.length != 0) {
                $.ajax({
                    type: ""POST"",
                    url: """);
#nullable restore
#line 139 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
                     Write(Url.RouteUrl("redirectToPayment"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                    data: {\r\n                        \"listOfChooseSeat\": listOfChooseSeat,\r\n                        \"filmScheduleId\": \"");
#nullable restore
#line 142 "D:\BIDC\QuanLyRapPhim\Views\ChooseSeat\Index.cshtml"
                                      Write(Model.filmSecheduleModel.filmSecheduleId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                        ""price"": parseInt($(""#soTien"").text())
                    },
                    dataType: ""json"",
                    success: function (response) {
                        window.location.href = response.url;
                    },
                    error: function (response) {
                        console.log(response);
                    }
                });
            }
        });

        function chooseSeat(row, column, price, className) {

            var standardSeatAndNotChoose = ""btn btn-primary"";
            var vipSeatAndNotChoose = ""btn btn-danger"";
            var premiumSeatAndNotChoose = ""btn btn-info"";
            var coupleSeatAndNotChoose = ""btn btn-success"";

            var chooseSeat = ""btn btn-warning"";

            $(""#"".concat(row).concat(column)).removeClass();
            listOfChooseSeat.push(row.concat(column));
            $(""#soTien"").text(parseInt($(""#soTien"").text()) + price);

            if (className.includes(");
                WriteLiteral(@"standardSeatAndNotChoose)) {
                $(""#"".concat(row).concat(column)).addClass(chooseSeat.concat("" standard""));
            } else if (className.includes(vipSeatAndNotChoose)) {
                $(""#"".concat(row).concat(column)).addClass(chooseSeat.concat("" vip""));
            } else if (className.includes(premiumSeatAndNotChoose)) {
                $(""#"".concat(row).concat(column)).addClass(chooseSeat.concat("" premium""));
            } else if (className.includes(coupleSeatAndNotChoose)) {
                $(""#"".concat(row).concat(column)).addClass(chooseSeat.concat("" couple""));
                if (column % 2 == 0) {
                    $(""#"".concat(row).concat(column - 1)).removeClass();
                    $(""#"".concat(row).concat(column - 1)).addClass(chooseSeat.concat("" couple""));
                    listOfChooseSeat.push(row.concat(column - 1));
                } else {
                    $(""#"".concat(row).concat(column + 1)).removeClass();
                    $(""#"".concat(row).con");
                WriteLiteral(@"cat(column + 1)).addClass(chooseSeat.concat("" couple""));
                    listOfChooseSeat.push(row.concat(column + 1));
                }
                $(""#soTien"").text(parseInt($(""#soTien"").text()) + price);
            } else if (className.includes(chooseSeat)) {
                listOfChooseSeat = listOfChooseSeat.filter(s => s !== row.concat(column));
                $(""#soTien"").text(parseInt($(""#soTien"").text()) - price * 2);
                if (className.includes(""standard"")) {
                    $(""#"".concat(row).concat(column)).addClass(standardSeatAndNotChoose);
                } else if (className.includes(""vip"")) {
                    $(""#"".concat(row).concat(column)).addClass(vipSeatAndNotChoose);
                } else if (className.includes(""premium"")) {
                    $(""#"".concat(row).concat(column)).addClass(premiumSeatAndNotChoose);
                } else if (className.includes(""couple"")) {
                    $(""#"".concat(row).concat(column)).addClass(coupleSeatAn");
                WriteLiteral(@"dNotChoose);
                    if (column % 2 == 0) {
                        $(""#"".concat(row).concat(column - 1)).removeClass();
                        $(""#"".concat(row).concat(column - 1)).addClass(coupleSeatAndNotChoose);
                        listOfChooseSeat = listOfChooseSeat.filter(s => s !== row.concat(column - 1));
                    } else {
                        $(""#"".concat(row).concat(column + 1)).removeClass();
                        $(""#"".concat(row).concat(column + 1)).addClass(coupleSeatAndNotChoose);
                        listOfChooseSeat = listOfChooseSeat.filter(s => s !== row.concat(column + 1));

                    }
                    $(""#soTien"").text(parseInt($(""#soTien"").text()) - price);
                }
            }
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyRapPhim.Models.MultipleViewModelForChooseSeatView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
