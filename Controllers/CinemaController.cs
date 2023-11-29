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

            string htmlCode = $@"
            Thông tin cụm rạp:
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
            Giá vé:
            <ul>";

            scs.ForEach(sc =>
            {
                if (sc.seatCategoryName.ToLower().Contains("couple".ToLower()))
                {
                    htmlCode += $@"
                    <li>
                        {sc.seatCategoryName}: {(sc.seatCategoryPrice + cm.cinemaServiceCharge) * 2} VND/vé
                    </li>";
                }
                else
                {
                    htmlCode += $@"
                    <li>
                        {sc.seatCategoryName}: {sc.seatCategoryPrice + cm.cinemaServiceCharge} VND/vé
                    </li>";
                }
            });

            htmlCode += $@"
                </ul>
            ";

            return Json(htmlCode);
        }
    }
}