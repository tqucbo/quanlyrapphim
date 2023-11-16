using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{
    [Table("Ticket")]
    public class TicketModel
    {

        [Key]
        public string ticketId { set; get; }                // Mã vé

        public string accountId { set; get; }               // Mã tài khoản

        [ForeignKey("accountId")]
        public virtual AccountModel account { set; get; }

        public string seatId { set; get; }                  // Mã ghế

        [ForeignKey("seatId")]
        public virtual SeatModel seat { set; get; }

        public string filmSecheduleId { set; get; }         // Mã lịch chiếu

        [ForeignKey("filmSecheduleId")]
        public virtual FilmSecheduleModel filmSechedule { set; get; }

    }
}