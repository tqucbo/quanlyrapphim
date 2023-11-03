using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System.Linq;

namespace QuanLyRapPhim.Controllers
{
    public class ChooseSeatController : Controller
    {

        private readonly ILogger<ChooseSeatController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        public ChooseSeatController(ILogger<ChooseSeatController> logger, QuanLyRapPhimDBContext context)
        {
            _logger = logger; _context = context;
        }

        [Route("/chooseseat/{filmScheduleId}")]
        public IActionResult Index(string filmScheduleId)
        {
            List<SeatModel> sms = (from sm in _context.seats
                                    join crm in _context.cinemaRooms
                                    on sm.cinemaRoomId equals crm.cinemaRoomId
                                    join cm in _context.cinemas
                                    on crm.cinemaId equals cm.cinemaId
                                    join fsm in _context.filmSechedules
                                    on crm.cinemaRoomId equals fsm.cinemaRoomId
                                    where fsm.filmSecheduleId == filmScheduleId
                                    orderby sm.seatRowChar, sm.seatColumnNumber
                                    select sm).ToList();
            return View(sms);
        }

        [HttpPost]
        [Route("/getFilmScheduleDetail", Name = "getFilmScheduleDetail")]
        public IActionResult GetFilmScheduleDetail(string filmScheduleId){
            FilmSecheduleModel f = (from fsm in _context.filmSechedules
                                    where fsm.filmSecheduleId == filmScheduleId
                                    select fsm).FirstOrDefault();
            return Json(f);
        }
    }
}