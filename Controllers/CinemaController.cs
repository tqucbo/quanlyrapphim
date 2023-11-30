using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System.Linq;


namespace QuanLyRapPhim.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ILogger<CinemaController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        public CinemaController(ILogger<CinemaController> logger, QuanLyRapPhimDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<CinemaModel> cms = (from cm in _context.cinemas
                                     orderby cm.cinemaName
                                     select cm).Distinct().ToList();

            return View(cms);
        }

        [HttpPost]
        [Route("/getCinemaInfo", Name = "GetCinemaInfo")]
        public IActionResult GetCinemaInfo(string cinemaId)
        {
            CinemaModel cm = (from c in _context.cinemas
                              where c.cinemaId == cinemaId
                              select c).FirstOrDefault();

            int totalCinemaRoom = (from cr in _context.cinemaRooms
                                   where cr.cinemaId == cm.cinemaId
                                   select cr).ToList().Count;

            List<SeatCategoryModel> scs = (from sc in _context.seatCategoryModels
                                           orderby sc.seatCategoryPrice
                                           select sc).ToList();

            string htmlInfo = $@"
            <div>
                <div class=""row no-gutters"">
                    <div class=""col col-6"">
                        <h5>{"Thông tin cụm rạp".ToUpper()}</h5>
                        <ul>
                            <li>
                                Tên cụm rạp: {cm.cinemaName}
                            </li>
                            <li>
                                Địa chỉ: {cm.cinemaAddress}
                            </li>
                            <li>
                                Tổng số lượng phòng chiếu: {totalCinemaRoom}
                            </li>
                        </ul>
                    </div>
                    <div class=""col col-6"">
                        <h5>{"Giá vé".ToUpper()}</h5>
                        <ul>";

            scs.ForEach(sc =>
            {
                if (sc.seatCategoryName.ToLower().Contains("couple".ToLower()))
                {
                    htmlInfo += $@"
                    <li>
                        {sc.seatCategoryName}: {(sc.seatCategoryPrice + cm.cinemaServiceCharge) * 2} VND/vé
                    </li>";
                }
                else
                {
                    htmlInfo += $@"
                    <li>
                        {sc.seatCategoryName}: {sc.seatCategoryPrice + cm.cinemaServiceCharge} VND/vé
                    </li>";
                }
            });

            htmlInfo += $@"
                            </ul>
                        </div>
                    </div>
                    <div>
                        <h5>{"Lưu ý".ToUpper()}</h5>
                        <ul>
                            <li>
                                Giá vé hiển thị trên Website và Ứng dụng là Giá vé cho Người lớn.
                            </li>
                            <li>
                                Với các đối tượng khách hàng sau, vui lòng mua vé trực tiếp tại rạp và xuất trình giấy tờ tương úng để được hưởng ưu đãi <strong>giảm 50000 VND/hoá đơn</strong>:
                                <ul>
                                    <li>
                                        <strong>Người dưới 23 tuổi</strong>: Xuất trình thẻ Căn cước công dân.
                                    </li>
                                    <li>
                                        <strong>Sinh viên trên 23 tuổi đang học tại các trường đại học, cao đẳng</strong>: Xuất trình thẻ Căn cước công dân và Thẻ sinh viên hoặc Giấy tờ chứng minh khác.
                                    </li>
                                    <li>
                                        <strong>Người cao tuổi</strong> (55 tuổi với Nữ và 60 tuổi với Nam): Xuất trình thẻ Căn cước công dân.
                                    </li>
                                    <li>
                                        <strong>Giáo viên, Giảng viên</strong>: Xuất trình thẻ Căn cước công dân và Thẻ viên chức hoặc Giấy tờ chứng minh khác.
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            ";

            string htmlImage = $@"<img src=""cinema/{cm.image}"" width=""100%"">";

            return Json(new
            {
                htmlInfo = htmlInfo,
                htmlImage = htmlImage,
            });
        }
    }
}