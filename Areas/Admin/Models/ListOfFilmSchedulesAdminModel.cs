using System.Collections.Generic;

namespace QuanLyRapPhim.Models
{
    public class ListOfFilmSchedulesAdminModel
    {

        public FilmModel film { set; get; }

        public List<FilmSecheduleModel> filmSechedules { set; get; }
    }
}