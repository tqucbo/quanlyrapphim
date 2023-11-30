using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System.Linq;
using Castle.Core.Internal;
using System;

namespace QuanLyRapPhim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        private readonly SignInManager<AppUserModel> _signInManager;

        private readonly UserManager<AppUserModel> _userManager;

        public HomeController(
            ILogger<HomeController> logger,
            QuanLyRapPhimDBContext context,
            SignInManager<AppUserModel> signInManager,
            UserManager<AppUserModel> userManager
        )
        {
            _logger = logger;
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            List<string> listImage = (from f in _context.films
                                      where f.filmBannerImage != null
                                      orderby f.filmStartDate descending
                                      select f.filmBannerImage)
                                      .Distinct()
                                      .Take(10)
                                      .ToList();

            return View(listImage);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
