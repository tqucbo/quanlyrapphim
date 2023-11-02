using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;

namespace QuanLyRapPhim.Controllers
{
    public class FilmController : Controller
    {

        private readonly ILogger<FilmController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        public FilmController(ILogger<FilmController> logger, QuanLyRapPhimDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Route("/movienowshowing")]
        public IActionResult MovieNowShowing()
        {
            List<FilmModel> films = (from film in _context.films
                                     where film.filmStartDate <= DateTime.Now
                                     orderby film.filmStartDate descending, film.filmName
                                     select film).ToList();
            return View(films);
        }

        [Route("/moviecomingsoon")]
        public IActionResult MovieComingSoon()
        {
            List<FilmModel> films = (from film in _context.films
                                     where film.filmStartDate > DateTime.Now || !film.filmStartDate.HasValue
                                     orderby film.filmStartDate.HasValue descending, film.filmStartDate, film.filmName
                                     select film).ToList();
            return View(films);
        }
    }
}