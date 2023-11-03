using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;

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
            return View();
        }
    }
}