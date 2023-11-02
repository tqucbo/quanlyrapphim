using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{
    [Table("CinemaRoom")]
    public class CinemaRoomModel
    {

        [Key]
        public string cinemaRoomId { set; get; }            //  Mã phòng chiếu

        public string cinemaRoomName { set; get; }          //  Tên phòng chiếu

        public string cinemaId { set; get; }                //  Phòng chiếu thuộc rạp nào

        [ForeignKey("cinemaId")]
        public virtual CinemaModel cinemaModel { set; get; }

    }
}