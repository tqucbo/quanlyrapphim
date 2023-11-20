using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{
    [Table("FilmGenre")]
    public class FilmGenreModel
    {

        [Key]
        public string filmGenreId { set; get; }                //  Mã phân loại độ tuổi

        public string filmGenreName { set; get; }              //  Tên phân loại độ tuổi

        public string filmGenreDescription { set; get; }       //  Mô tả phân loại độ tuổi

    }
}