using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyRapPhim.Controllers
{
    public class BuyTicketController : Controller
    {

        private readonly ILogger<BuyTicketController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        private readonly SignInManager<AppUserModel> _signInManager;

        private readonly UserManager<AppUserModel> _userManager;

        public BuyTicketController(
            ILogger<BuyTicketController> logger,
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

        [Route("/buyticket/{filmId}")]
        public IActionResult Index(string filmId)
        {
            if (_signInManager.IsSignedIn(User))
            {
                FilmModel f = (from film in _context.films
                               where film.filmId == filmId
                               select film).FirstOrDefault();

                return View(f);
            }
            else
            {
                return RedirectToAction("Login", "Membership");
            }
        }

        [HttpPost]
        [Route("/getCinema", Name = "getCinema")]
        public IActionResult GetCinema([FromForm] string filmId)
        {
            List<CinemaModel> cms = (from fsm in _context.filmSechedules
                                     where fsm.filmId == filmId
                                     && fsm.filmShowDate >= DateTime.Now.Date
                                     select fsm.CinemaRoom.cinemaModel).Distinct().ToList();

            return Json(cms);
        }

        [HttpPost]
        [Route("/getFilmShowDate", Name = "getFilmShowDate")]
        public IActionResult GetFilmShowDate([FromForm] string cinemaId, [FromForm] string filmId)
        {
            List<string> allFilmShowDate = (from fsm in _context.filmSechedules
                                            where fsm.filmId == filmId
                                            && fsm.CinemaRoom.cinemaModel.cinemaId == cinemaId
                                            && fsm.filmShowDate >= DateTime.Now.Date
                                            select fsm.filmShowDate.ToShortDateString()).Distinct().ToList();

            return Json(allFilmShowDate);
        }

        [HttpPost]
        [Route("/getFilmShowTime", Name = "getFilmShowTime")]
        public IActionResult GetFilmShowTime([FromForm] string filmShowDate, [FromForm] string cinemaId, [FromForm] string filmId)
        {
            List<string> allFilmShowTime = (from fsm in _context.filmSechedules
                                            where fsm.filmId == filmId
                                            && fsm.CinemaRoom.cinemaModel.cinemaId == cinemaId
                                            && fsm.filmShowDate == DateTime.Parse(filmShowDate)
                                            && fsm.filmShowTime >= DateTime.Now.TimeOfDay
                                            orderby fsm.filmShowTime
                                            select fsm.filmShowTime.ToString(@"hh\:mm")).Distinct().ToList();

            return Json(allFilmShowTime);
        }

        [HttpPost]
        [Route("/getFilmScheduleId", Name = "getFilmScheduleId")]
        public IActionResult GetFilmScheduleId(string cinemaId, string filmShowDate, string filmShowTime, string filmId)
        {
            string filmSecheduleId = (from fsm in _context.filmSechedules
                                      where fsm.filmId == filmId
                                      && fsm.filmShowDate == DateTime.Parse(filmShowDate)
                                      && fsm.filmShowTime == TimeSpan.Parse(filmShowTime)
                                      && fsm.CinemaRoom.cinemaModel.cinemaId == cinemaId
                                      select fsm.filmSecheduleId).FirstOrDefault();

            return Json(filmSecheduleId);
        }
    }
}