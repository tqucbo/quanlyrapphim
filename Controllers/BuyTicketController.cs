using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
            List<CinemaModel> cms = (from cm in _context.cinemas
                                     join crm in _context.cinemaRooms on cm.cinemaId equals crm.cinemaId
                                     join fsm in _context.filmSechedules on crm.cinemaRoomId equals fsm.cinemaRoomId
                                     where fsm.filmId == filmId
                                     select cm).Distinct().ToList();

            FilmModel f = (from film in _context.films
                           where film.filmId == filmId
                           select film).FirstOrDefault();

            BuyTicketMutipleViewModel multipleModel = new BuyTicketMutipleViewModel();

            multipleModel.filmModel = f;
            multipleModel.cinemaModels = cms;

            return View(multipleModel);
        }
    }
}