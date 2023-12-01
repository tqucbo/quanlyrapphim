using System.Collections.Generic;

namespace QuanLyRapPhim.Models
{
    public class MultipleModelForHomeView
    {

        public List<string> listFilmBannerImage { set; get; }

        public List<FilmModel> top10ComingSoon { set; get; }

        public List<FilmModel> top10NowShowing { set; get; }

    }
}