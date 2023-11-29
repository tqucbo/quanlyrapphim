using System.Collections.Generic;

namespace QuanLyRapPhim.Models
{
    public class MultipleModelForChooseSeatView
    {
        public List<SeatModel> seatModels { set; get; }

        public List<SeatModel> seatModelsBought { set; get; }

        public FilmSecheduleModel filmSecheduleModel { set; get; }

        public CinemaModel cinemaModel { set; get; }
    }
}