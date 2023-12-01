using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System.Linq;
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
            List<string> listFilmBannerImage = (from f in _context.films
                                                where f.filmBannerImage != null
                                                orderby f.filmStartDate descending
                                                select f.filmBannerImage)
                                      .Distinct()
                                      .Take(10)
                                      .ToList();

            List<FilmModel> top10NowShowing = (from film in _context.films
                                               where film.filmStartDate <= DateTime.Now
                                               orderby film.filmStartDate descending, film.filmName
                                               select film).Take(10).ToList();

            List<FilmModel> top10ComingSoon = (from film in _context.films
                                               where film.filmStartDate > DateTime.Now || !film.filmStartDate.HasValue
                                               orderby film.filmStartDate.HasValue descending, film.filmStartDate, film.filmName
                                               select film).Take(10).ToList();

            return View(new MultipleModelForHomeView()
            {
                listFilmBannerImage = listFilmBannerImage,
                top10ComingSoon = top10ComingSoon,
                top10NowShowing = top10NowShowing,
            });
        }

        [Route("/Top10MovieNowShowing", Name = "Top10MovieNowShowing")]
        public IActionResult Top10MovieNowShowing()
        {
            List<FilmModel> films = (from film in _context.films
                                     where film.filmStartDate <= DateTime.Now
                                     orderby film.filmStartDate descending, film.filmName
                                     select film).Take(10).ToList();
            return Json(films);
        }

        [Route("/Top10MovieComingSoon", Name = "Top10MovieComingSoon")]
        public IActionResult Top10MovieComingSoon()
        {
            List<FilmModel> films = (from film in _context.films
                                     where film.filmStartDate > DateTime.Now || !film.filmStartDate.HasValue
                                     orderby film.filmStartDate.HasValue descending, film.filmStartDate, film.filmName
                                     select film).Take(10).ToList();
            return Json(films);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
