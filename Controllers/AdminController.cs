using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using System.Net.Http;
using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Crypto.Macs;
using Newtonsoft.Json;

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
        public async Task<IActionResult> AddNewFilm([FromForm] FilmAdminModel filmFromForm, [FromForm] IFormFile filmPosterImage, [FromForm] IFormFile filmBannerImage)
        {
            if (Request.Method == HttpMethod.Post.Method)
            {
                string exists_filmStartDate = Request.Form["exists_filmStartDate"].ToString();
                string exists_filmMainCategory = Request.Form["exists_filmMainCategory"].ToString();
                string exists_filmGenre = Request.Form["exists_filmGenre"].ToString();


                if (ModelState.IsValid)
                {
                    FilmModel film = new FilmModel()
                    {
                        filmId = Guid.NewGuid().ToString(),
                        filmName = filmFromForm.filmName.ToUpper(),
                        filmLength = filmFromForm.filmLength,
                        filmCountry = filmFromForm.filmCountry,
                        filmDescription = filmFromForm.filmDescription,
                        filmPosterImage = filmPosterImage != null ? filmPosterImage.FileName.ToString() : null,
                        filmDirector = filmFromForm.filmDirector,
                        filmMainActors = filmFromForm.filmMainActors,
                        filmBannerImage = filmBannerImage != null ? filmBannerImage.FileName.ToString() : null,
                        filmStartDate = exists_filmStartDate == "2" ? DateTime.Parse(Request.Form["filmStartDate"].ToString()) : null,
                        filmGenreId = exists_filmGenre == "2" ? Request.Form["filmGenre"].ToString() : null,
                        filmMainCategoryId = exists_filmMainCategory == "2" ? Request.Form["filmMainCategory"].ToString() : null,
                        languageSubtitle = filmFromForm.languageSubtitle
                    };

                    if (filmPosterImage != null)
                    {

                        var filmPosterImagePath = Path.Combine($"{Directory.GetCurrentDirectory()}", "wwwroot", "poster", filmPosterImage.FileName.ToString());

                        using (var filestream = new FileStream(filmPosterImagePath, FileMode.Create))
                        {
                            await filmPosterImage.CopyToAsync(filestream);
                        }

                    }

                    if (filmBannerImage != null)
                    {

                        var filmBannerImagePath = Path.Combine($"{Directory.GetCurrentDirectory()}", "wwwroot", "banner", filmBannerImage.FileName.ToString());

                        using (var filestream = new FileStream(filmBannerImagePath, FileMode.Create))
                        {
                            await filmPosterImage.CopyToAsync(filestream);
                        }

                    }

                    _context.Add(film);
                    var result = await _context.SaveChangesAsync();

                    return RedirectToAction("ListOfFilms");
                }
            }
            else
            {
                ModelState.Clear();
            }
            return View(filmFromForm);
        }

        public IActionResult FilmDetail(string filmId)
        {
            FilmModel f = (from film in _context.films
                           where film.filmId == filmId
                           select film).FirstOrDefault();

            return View(f);
        }

        public async Task<IActionResult> UpdateFilm(string filmId, [FromForm] FilmAdminModel filmFromForm, [FromForm] IFormFile filmPosterImage, [FromForm] IFormFile filmBannerImage)
        {
            if (Request.Method == HttpMethod.Get.Method)
            {
                FilmModel fm = (from f in _context.films
                                where f.filmId == filmId
                                select f).FirstOrDefault();

                FilmAdminModel fam = new FilmAdminModel()
                {
                    filmName = fm.filmName,
                    filmCountry = fm.filmCountry,
                    filmDescription = fm.filmDescription,
                    filmDirector = fm.filmDirector,
                    filmLength = fm.filmLength ?? -1,
                    filmMainActors = fm.filmMainActors,
                    filmStartDate = fm.filmStartDate,
                    languageSubtitle = fm.languageSubtitle,
                    filmGenreId = fm.filmGenreId,
                    filmMainCategoryId = fm.filmMainCategoryId,
                };

                ModelState.Clear();

                return View(fam);
            }
            if (Request.Method == HttpMethod.Post.Method)
            {
                Console.WriteLine(JsonConvert.SerializeObject(filmFromForm));

                var film = await _context.films.FindAsync(filmId);

                film.filmBannerImage =
                    filmBannerImage == null
                    ? film.filmBannerImage
                    : filmBannerImage.FileName.ToString();

                film.filmDescription =
                    string.IsNullOrEmpty(filmFromForm.filmDescription)
                    ? film.filmDescription
                    : filmFromForm.filmDescription;

                film.filmDirector =
                    string.IsNullOrEmpty(filmFromForm.filmDirector)
                    ? film.filmDirector
                    : filmFromForm.filmDirector;

                film.filmName =
                    string.IsNullOrEmpty(filmFromForm.filmName)
                    ? film.filmName
                    : filmFromForm.filmName;

                film.filmCountry =
                    string.IsNullOrEmpty(filmFromForm.filmCountry)
                    ? film.filmCountry
                    : filmFromForm.filmCountry;

                film.filmGenreId =
                    string.IsNullOrEmpty(filmFromForm.filmGenreId)
                    ? film.filmGenreId
                    : Request.Form["exists_filmGenre"].ToString() == "1"
                    ? film.filmGenreId
                    : Request.Form["filmGenre"].ToString() == film.filmGenreId
                    ? film.filmGenreId
                    : Request.Form["filmGenre"].ToString();

                film.filmLength =
                    filmFromForm.filmLength == 0 || filmFromForm.filmLength == -1
                    ? film.filmLength
                    : filmFromForm.filmLength;

                film.filmMainActors =
                    string.IsNullOrEmpty(filmFromForm.filmMainActors)
                    ? film.filmMainActors
                    : filmFromForm.filmMainActors;

                film.filmMainCategoryId =
                    string.IsNullOrEmpty(filmFromForm.filmMainCategoryId)
                    ? film.filmMainCategoryId
                    : Request.Form["exists_filmMainCategory"].ToString() == "1"
                    ? film.filmMainCategoryId
                    : Request.Form["filmMainCategory"].ToString() == film.filmMainCategoryId
                    ? film.filmMainCategoryId
                    : Request.Form["filmMainCategory"];

                film.filmName =
                    string.IsNullOrEmpty(filmFromForm.filmName)
                    ? film.filmName
                    : filmFromForm.filmName;

                film.filmPosterImage =
                    filmPosterImage == null
                    ? film.filmPosterImage
                    : filmPosterImage.FileName.ToString();

                film.filmStartDate =
                    string.IsNullOrEmpty(filmFromForm.filmStartDate.ToString())
                    ? null
                    : Request.Form["exists_filmStartDate"].ToString() == "1"
                    ? null
                    : Request.Form["exists_filmStartDate"].ToString() == film.filmStartDate.ToString()
                    ? film.filmStartDate
                    : DateTime.Parse(Request.Form["filmStartDate"].ToString());

                film.languageSubtitle =
                    string.IsNullOrEmpty(filmFromForm.languageSubtitle)
                    ? film.languageSubtitle
                    : filmFromForm.languageSubtitle;

                var result = await _context.SaveChangesAsync();

                return RedirectToAction("ListOfFilms");

            }
            return View(filmFromForm);
        }
    }
}