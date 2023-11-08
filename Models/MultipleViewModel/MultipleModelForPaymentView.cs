using System.Collections.Generic;

namespace QuanLyRapPhim.Models
{
    public class MultipleViewModelForPaymentView {
        public string seats {set;get;}

        public FilmSecheduleModel filmSecheduleModel {set;get;}

        public CinemaModel cinemaModel {set;get;}
        
        public int price {set;get;}
    }
}