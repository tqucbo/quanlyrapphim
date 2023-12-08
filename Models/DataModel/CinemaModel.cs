using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{
    [Table("Cinema")]
    public class CinemaModel
    {
        [Key]
        public string cinemaId { set; get; }

        [Display(Name = "Cụm rạp")]
        public string cinemaName { set; get; }

        public string cinemaAddress { set; get; }

        public int cinemaServiceCharge { set; get; }

        public string image { set; get; }
    }
}