using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyRapPhim.Models
{
    public class FilmSecheduleAdminModel
    {
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [Display(Name = "Ngày chiếu")]
        public DateTime filmShowDate { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [Display(Name = "Ngày chiếu")]
        public TimeSpan filmShowTime { set; get; }

        public string filmId { set; get; }

        public string cinemaRoomId { set; get; }
    }
}