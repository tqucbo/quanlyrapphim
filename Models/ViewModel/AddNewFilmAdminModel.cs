using System.Collections.Generic;

namespace QuanLyRapPhim.Models
{
    public class AddNewFilmAdminModel
    {

        public FilmModel film { set; get; }

        public List<FilmGenreModel> filmGenres { set; get; }

        public List<FilmMainCategoryModel> filmMainCategories { set; get; }

    }
}