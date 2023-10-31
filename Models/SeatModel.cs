using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{
    [Table("Seat")]
    public class SeatModel
    {

        [Key]
        public string seatId { set; get; }              //  Mã ghế

        public string seatName { set; get; }            //  Tên ghế

        public int seatColumnNumber { set; get; }       //  Ghế thuộc cột nào

        public char seatRowChar { set; get; }           //  Ghế thuộc hàng nào

        public string cinemaRoomId { set; get; }           //  Ghế thuộc Phòng chiếu nào

        [ForeignKey("cinemaRoomId")]
        public virtual CinemaRoomModel cinemaRoom { set; get; }

    }
}