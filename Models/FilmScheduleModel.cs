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

        [Column(TypeName = "DATE")]
        public DateTime filmShowDate { set; get; }                 //  Ngày chiếu

        [Column(TypeName = "TIME")]
        public TimeSpan filmShowTime { set; get; }                 //  Giờ chiếu

        public string filmId { set; get; }                         //  Mã phim

        [ForeignKey("filmId")]
        public virtual FilmModel film { set; get; }

        public string cinemaRoomId { set; get; }                   //  Mã phòng chiếu

        [ForeignKey("cinemaRoomId")]
        public virtual CinemaRoomModel CinemaRoom { set; get; }

    }
}