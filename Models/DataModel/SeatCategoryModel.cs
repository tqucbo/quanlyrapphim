using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{
    [Table("SeatCategory")]
    public class SeatCategoryModel
    {
        [Key]
        public string seatCategoryId { set; get; }

        public string seatCategoryName { set; get; }

        public int seatCategoryPrice { set; get; }
    }
}