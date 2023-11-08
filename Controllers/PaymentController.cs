using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System.Linq;

namespace QuanLyRapPhim.Controllers
{
    public class PaymentController : Controller {

        private readonly ILogger<PaymentController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        public PaymentController(ILogger<PaymentController> logger, QuanLyRapPhimDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string[]listOfChooseSeat, string filmScheduleId, int price) {

            MultipleViewModelForPaymentView m = new MultipleViewModelForPaymentView();

            for (var i = 0; i < listOfChooseSeat.Length; i++) {
                if (i == listOfChooseSeat.Length - 1) 
                    m.seats += listOfChooseSeat[i];  
                else 
                    m.seats += listOfChooseSeat[i] + ", ";  
            }


            var fs = (from fsm in _context.filmSechedules
                                    where fsm.filmSecheduleId == filmScheduleId
                                    select fsm).FirstOrDefault();  

            m.filmSecheduleModel = fs;

            var c = (from cm in _context.cinemas
                                     join crm in _context.cinemaRooms on cm.cinemaId equals crm.cinemaId
                                     join fsm in _context.filmSechedules on crm.cinemaRoomId equals fsm.cinemaRoomId
                                     orderby cm.cinemaName
                                     where fsm.filmSecheduleId == filmScheduleId
                                     select cm).FirstOrDefault();

            m.cinemaModel = c;

            m.price = price;

            return View(m);
        }
    }
}