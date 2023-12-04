using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;

namespace QuanLyRapPhim.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        private readonly SignInManager<AppUserModel> _signInManager;

        private readonly UserManager<AppUserModel> _userManager;

        public AdminController(
            ILogger<AdminController> logger,
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
            return View();
        }

        public IActionResult ListOfFilms()
        {

            List<FilmModel> films = (from f in _context.films
                                     orderby f.filmStartDate descending, f.filmName ascending
                                     select f
                                     ).ToList();
            return View(films);
        }

        [Route("AddNewFilmAutoLoad", Name = "AddNewFilmAutoLoad")]
        public IActionResult AddNewFilmAutoLoad()
        {

            List<FilmGenreModel> filmGenres = (from fg in _context.filmGenres
                                               orderby fg.filmGenreName ascending
                                               select fg
                                     ).ToList();

            List<FilmMainCategoryModel> filmMainCategories = (from fmc in _context.filmMainCategories
                                                              orderby fmc.filmMainCategoryName ascending
                                                              select fmc
                                     ).ToList();

            return Json(new { filmGenres = filmGenres, filmMainCategories = filmMainCategories });
        }
        public async Task<IActionResult> AddNewFilm()
        {
            return View();
        }
    }
}