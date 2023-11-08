using System.Collections.Generic;

namespace QuanLyRapPhim.Models
{
    public class MultipleViewModelForChooseSeatView {
        public List<SeatModel> seatModels {set;get;}

        public FilmSecheduleModel filmSecheduleModel {set;get;}

        public CinemaModel cinemaModel {set;get;}
    }
}