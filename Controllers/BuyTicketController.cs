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

        public BuyTicketController(ILogger<BuyTicketController> logger, QuanLyRapPhimDBContext context)
        {
            _logger = logger; _context = context;
        }

        [Route("/buyticket/{filmId}")]
        public IActionResult Index(string filmId)
        {

            FilmModel f = (from film in _context.films
                           where film.filmId == filmId
                           select film).FirstOrDefault();

            return View(f);
        }

        [HttpPost]
        [Route("/getCinema", Name = "getCinema")]
        public IActionResult GetCinema([FromForm] string filmId)
        {
            List<CinemaModel> cms = (from cm in _context.cinemas
                                     join crm in _context.cinemaRooms on cm.cinemaId equals crm.cinemaId
                                     join fsm in _context.filmSechedules on crm.cinemaRoomId equals fsm.cinemaRoomId
                                     orderby cm.cinemaName
                                     where fsm.filmId == filmId
                                     select cm).Distinct().ToList();

            return Json(cms);
        }

        [HttpPost]
        [Route("/getFilmShowDate", Name = "getFilmShowDate")]
        public IActionResult GetFilmShowDate([FromForm] string cinemaId)
        {
            List<FilmSecheduleModel> fsms = (from fms in _context.filmSechedules
                                             join crm in _context.cinemaRooms
                                             on fms.cinemaRoomId equals crm.cinemaRoomId
                                             orderby fms.filmShowDate
                                             where crm.cinemaId == cinemaId
                                             select fms).ToList();

            List<string> allFilmShowDate = fsms.Select((fsm) => fsm.filmShowDate.ToShortDateString()).Distinct().ToList();

            return Json(allFilmShowDate);
        }

        [HttpPost]
        [Route("/getFilmShowTime", Name = "getFilmShowTime")]
        public IActionResult GetFilmShowTime([FromForm] string filmShowDate, [FromForm] string cinemaId)
        {
            List<FilmSecheduleModel> fsms = (from fms in _context.filmSechedules
                                             join crm in _context.cinemaRooms
                                              on fms.cinemaRoomId equals crm.cinemaRoomId
                                              orderby fms.filmShowTime
                                             where fms.filmShowDate == DateTime.Parse(filmShowDate)
                                             && crm.cinemaId == cinemaId
                                             select fms).ToList();

            List<string> allFilmShowTime = fsms.Select((fsm) => fsm.filmShowTime.ToString(@"hh\:mm")).Distinct().ToList();

            return Json(allFilmShowTime);
        }

        [HttpPost]
        [Route("/getFilmScheduleId", Name = "getFilmScheduleId")]
        public IActionResult GetFilmScheduleId(string cinemaId, string filmShowDate, string filmShowTime)
        {
            FilmSecheduleModel f = (from fms in _context.filmSechedules
                                    join crm in _context.cinemaRooms
                                     on fms.cinemaRoomId equals crm.cinemaRoomId
                                    where crm.cinemaId == cinemaId
                                    && fms.filmShowDate == DateTime.Parse(filmShowDate)
                                    && fms.filmShowTime == TimeSpan.Parse(filmShowTime)
                                    select fms).FirstOrDefault();

            return Json(f.filmSecheduleId);
        }
    }
}