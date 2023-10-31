using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{

    [Table("FilmMainCategory")]
    public class FilmMainCategoryModel
    {

        [Key]
        public string filmMainCategoryId { set; get; }          //  Mã thể loại chính

        [Column(TypeName = "NVARCHAR")]
        [StringLength(450)]
        public string filmMainCategoryName { set; get; }        //  Tên thể loại chính

    }
}