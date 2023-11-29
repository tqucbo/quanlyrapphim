using System.Collections.Generic;

namespace QuanLyRapPhim.Models
{
    public class MultipleModelForPaymentView
    {
        public List<SeatModel> seatModels { set; get; }

        public FilmSecheduleModel filmSecheduleModel { set; get; }

        public CinemaModel cinemaModel { set; get; }

        public List<PaymentMethodModel> paymentMethodModels { set; get; }

        public int price { set; get; }
    }
}