using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;

namespace QuanLyRapPhim.Controllers
{
    public class MembershipController : Controller
    {

        private readonly ILogger<MembershipController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        [BindProperty]
        public AppUserModel appUser { set; get; }

        public MembershipController(ILogger<MembershipController> logger, QuanLyRapPhimDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return Json(appUser);
        }
    }
}