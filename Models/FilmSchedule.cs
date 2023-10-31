using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{

    [Table("FilmSchedule")]
    public class FilmSecheduleModel
    {

        [Key]
        public string filmSecheduleId { set; get; }                //  Mã lịch chiếu

        public DateTime filmShowDate { set; get; }                 //  Ngày chiếu và giờ chiếu

        public string filmId { set; get; }                         //  Mã phim

        [ForeignKey("filmId")]
        public virtual FilmModel film { set; get; }

        public string cinemaRoomId { set; get; }                   //  Mã phòng chiếu

        [ForeignKey("cinemaRoomId")]
        public virtual CinemaRoomModel CinemaRoom { set; get; }

        public int price { set; get; }                             //  Giá vé

    }
}