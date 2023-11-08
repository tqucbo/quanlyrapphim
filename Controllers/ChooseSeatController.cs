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

            FilmSecheduleModel fs = (from fsm in _context.filmSechedules
                                    where fsm.filmSecheduleId == filmScheduleId
                                    select fsm).FirstOrDefault(); 

            CinemaModel c = (from cm in _context.cinemas
                                     join crm in _context.cinemaRooms on cm.cinemaId equals crm.cinemaId
                                     join fsm in _context.filmSechedules on crm.cinemaRoomId equals fsm.cinemaRoomId
                                     orderby cm.cinemaName
                                     where fsm.filmSecheduleId == filmScheduleId
                                     select cm).FirstOrDefault();

            MultipleViewModelForChooseSeatView m = new MultipleViewModelForChooseSeatView() ;
            m.seatModels = sms;
            m.filmSecheduleModel = fs;
            m.cinemaModel = c;

            return View(m);
        }

        [Route("/redirectToPayment/", Name = "redirectToPayment")]
        [HttpPost]
        public IActionResult RedirectToPayment(string[] listOfChooseSeat, string filmScheduleId, int price) {
            return Json (new { 
                url = Url.Action(
                    "Index", 
                    "Payment", 
                    new {
                            listOfChooseSeat = listOfChooseSeat, 
                            filmScheduleId = filmScheduleId,
                            price = price,
                        }
                    )
                }      
            );
        }
    }
}