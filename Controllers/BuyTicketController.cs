using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace QuanLyRapPhim.Controllers
{
    public class BuyTicketController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public BuyTicketController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string filmId)
        {
            return View();
        }
    }
}