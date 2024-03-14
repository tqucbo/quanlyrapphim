using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        [Route("/movienowshowing", Name = "MovieNowShowing")]
        public async Task<IActionResult> MovieNowShowing()
        {
            // (fs.filmShowDate - DateTime.Now.Date).TotalDays <= 7


            List<FilmModel> films = (from fs in _context.filmSechedules
                                     where fs.film.filmStartDate <= DateTime.Now
                                     && fs.filmShowDate.AddDays(7) >= DateTime.Now
                                     orderby fs.film.filmStartDate descending, fs.film.filmName
                                     select fs.film).Distinct().ToList();

            return View(films);
        }

        [Route("/moviecomingsoon", Name = "MovieComingSoon")]
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