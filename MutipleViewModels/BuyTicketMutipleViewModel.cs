using System.Collections.Generic;

namespace QuanLyRapPhim.Models
{
    public class BuyTicketMutipleViewModel
    {
        public FilmModel filmModel { set; get; }

        public List<CinemaModel> cinemaModels { set; get; }

        public List<FilmSecheduleModel> filmSecheduleModels { set; get; }
    }
}