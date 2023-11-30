using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{

    [Table("Film")]
    public class FilmModel
    {

        [Key]
        public string filmId { set; get; }                 //  Mã phim

        public string filmName { set; get; }               //  Tên phim

        public int? filmLength { set; get; }             //  Thời lượng

        public string? filmMainCategoryId { set; get; }     //  Thể loại chính 

        [ForeignKey("filmMainCategoryId")]
        public virtual FilmMainCategoryModel? filmMainCategory { set; get; }

        public string filmDescription { set; get; }        //  Mô tả

        [DataType(DataType.Date)]
        public DateTime? filmStartDate { set; get; }       //  Ngày khởi chiếu

        public string filmGenreId { set; get; }            //  Phân loại độ tuổi

        [ForeignKey("filmGenreId")]
        public virtual FilmGenreModel filmGenre { set; get; }

        public string filmDirector { set; get; }           //  Đạo diễn

        public string filmMainActors { set; get; }         //  Diễn viên chính

        public string filmPosterImage { set; get; }        //  Ảnh Poster

        public string filmCountry { set; get; }             // Quốc gia sản xuất

        public string languageSubtitle { set; get; }        //  Ngôn ngữ phụ đề

        public string filmBannerImage { set; get; }
    }
}