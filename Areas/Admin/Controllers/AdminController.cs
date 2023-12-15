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
using System.Reflection;
using System.ComponentModel.DataAnnotations;


namespace QuanLyRapPhim.Controllers
{
    [Area("Admin")]
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
                            await filmBannerImage.CopyToAsync(filestream);
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

                var film = await _context.films.FindAsync(filmId);

                if (filmPosterImage != null)
                {
                    film.filmPosterImage = filmPosterImage.FileName.ToString();
                }

                if (filmBannerImage != null)
                {
                    film.filmBannerImage = filmBannerImage.FileName.ToString();
                }

                if (filmFromForm.filmDescription != null)
                {
                    film.filmDescription = filmFromForm.filmDescription;
                }

                if (filmFromForm.filmDirector != null)
                {
                    film.filmDirector = filmFromForm.filmDirector;
                }

                if (filmFromForm.filmName != null)
                {
                    film.filmName = filmFromForm.filmName;
                }

                if (filmFromForm.filmCountry != null)
                {
                    film.filmCountry = filmFromForm.filmCountry;
                }

                if (Request.Form["exists_filmGenre"].ToString() == "2")
                {
                    film.filmGenreId = Request.Form["filmGenre"].ToString();
                }
                else if (Request.Form["exists_filmGenre"].ToString() == "1")
                {
                    film.filmGenreId = null;
                }

                if (filmFromForm.filmLength != 0 || filmFromForm.filmLength != -1)
                {
                    film.filmLength = filmFromForm.filmLength;
                }

                if (filmFromForm.filmMainActors != null)
                {
                    film.filmMainActors = filmFromForm.filmMainActors;
                }

                if (Request.Form["exists_filmMainCategory"].ToString() == "2")
                {
                    film.filmMainCategoryId = Request.Form["filmMainCategory"].ToString();
                }
                else if (Request.Form["exists_filmMainCategory"].ToString() == "1")
                {
                    film.filmMainCategoryId = null;
                }

                if (Request.Form["exists_filmStartDate"].ToString() == "2")
                {
                    film.filmStartDate = DateTime.Parse(Request.Form["filmStartDate"].ToString());
                }
                else if (Request.Form["exists_filmMainCategory"].ToString() == "1")
                {
                    film.filmStartDate = null;
                }

                if (filmFromForm.languageSubtitle != null)
                {
                    film.languageSubtitle = filmFromForm.languageSubtitle;
                }

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
                        await filmBannerImage.CopyToAsync(filestream);
                    }

                }

                await _context.SaveChangesAsync();

                return RedirectToAction("ListOfFilms");

            }
            return View(filmFromForm);
        }

        public IActionResult ListOfFilmSchedules(string filmId)
        {
            List<FilmSecheduleModel> filmSechedules = (from fsm in _context.filmSechedules
                                                       where fsm.filmId == filmId
                                                       select fsm).ToList();

            FilmModel film = (from f in _context.films
                              where f.filmId == filmId
                              select f).FirstOrDefault();

            return View(new ListOfFilmSchedulesAdminModel()
            {
                filmSechedules = filmSechedules,
                film = film,
            });
        }

        [HttpPost]
        [Route("/ListOfFilmSchedulesPost", Name = "ListOfFilmSchedulesPost")]
        public IActionResult ListOfFilmSchedulesPost(string filmId, string cinemaId)
        {
            List<FilmSecheduleModel> filmSechedules = new List<FilmSecheduleModel>();
            if (string.IsNullOrEmpty(cinemaId))
            {
                filmSechedules = (from fsm in _context.filmSechedules
                                  where fsm.filmId == filmId
                                  orderby fsm.CinemaRoom.cinemaModel.cinemaName, fsm.filmShowDate descending, fsm.filmShowTime descending
                                  select fsm).ToList();
            }
            else
            {
                filmSechedules = (from fsm in _context.filmSechedules
                                  where fsm.filmId == filmId
                                  && fsm.CinemaRoom.cinemaId == cinemaId
                                  orderby fsm.CinemaRoom.cinemaModel.cinemaName, fsm.filmShowDate descending, fsm.filmShowTime descending
                                  select fsm).ToList();
            }

            string htmlTHead = @$"
                <tr>
                    <th style=""width: 25%"">
                        {(typeof(FilmSecheduleModel).GetProperty("filmShowDate").GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute).Name}
                    </th>
                    <th style=""width: 25%"">
                        {(typeof(FilmSecheduleModel).GetProperty("filmShowTime").GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute).Name}
                    </th>
                    <th style=""width: 25%"">
                        {(typeof(CinemaRoomModel).GetProperty("cinemaRoomName").GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute).Name}
                    </th>
                    <th style=""width: 25%"">
                        {(typeof(CinemaModel).GetProperty("cinemaName").GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute).Name}
                    </th>
                </tr>
            ";

            string htmlTBody = "";

            foreach (var i in filmSechedules)
            {
                htmlTBody += @$"
                    <tr>
                        <td>
                            {i.filmShowDate.ToShortDateString()}
                        </td>
                        <td>
                            {i.filmShowTime.ToString(@"hh\:mm")}
                        </td>
                        <td>
                            {i.CinemaRoom.cinemaRoomName}
                        </td>
                        <td>
                            {i.CinemaRoom.cinemaModel.cinemaName}
                        </td>
                    </tr>
                ";
            }
            return Json(new
            {
                htmlTHead = htmlTHead,
                htmlTBody = htmlTBody,
            });
        }

        public async Task<IActionResult> AddNewFilmSchedule(string filmId, [FromForm] FilmSecheduleAdminModel filmSecheduleFromForm)
        {
            if (Request.Method == HttpMethod.Post.Method)
            {

                if (ModelState.IsValid)
                {
                    FilmSecheduleModel filmSechedule = new FilmSecheduleModel()
                    {
                        filmSecheduleId = Guid.NewGuid().ToString(),
                        filmId = filmId,
                        filmShowDate = filmSecheduleFromForm.filmShowDate,
                        filmShowTime = filmSecheduleFromForm.filmShowTime,
                        cinemaRoomId = Request.Form["cinemaRoomInput"].ToString(),
                    };

                    _context.Add(filmSechedule);

                    var result = await _context.SaveChangesAsync();

                    if (result != 0)
                    {
                        return RedirectToAction("ListOfFilmSchedules", new { filmId = filmId });
                    }
                }
            }

            return View(new FilmSecheduleAdminModel()
            {
                filmId = filmId
            });

        }

        [Route("AddNewFilmScheduleAutoLoad", Name = "AddNewFilmScheduleAutoLoad")]
        public IActionResult AddNewFilmScheduleAutoLoad(string cinemaId)
        {
            if (string.IsNullOrEmpty(cinemaId))
            {
                List<CinemaModel> cinemas = (from c in _context.cinemas
                                             select c).ToList();
                return Json(cinemas);
            }
            else
            {
                List<CinemaRoomModel> cinemaRooms = (from cr in _context.cinemaRooms
                                                     where cr.cinemaId == cinemaId
                                                     select cr).ToList();
                return Json(cinemaRooms);
            }
        }
    }
}