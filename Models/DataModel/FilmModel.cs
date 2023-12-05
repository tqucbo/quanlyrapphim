using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{

    [Table("Film")]
    public class FilmModel
    {

        [Key]
        [Display(Name = "Mã phim")]
        public string filmId { set; get; }                 //  Mã phim

        [Display(Name = "Tên phim")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string filmName { set; get; }               //  Tên phim

        [Display(Name = "Độ dài")]
        public int? filmLength { set; get; }             //  Thời lượng

        public string? filmMainCategoryId { set; get; }     //  Thể loại chính 

        [ForeignKey("filmMainCategoryId")]
        public virtual FilmMainCategoryModel? filmMainCategory { set; get; }

        [Display(Name = "Mô tả")]
        public string filmDescription { set; get; }        //  Mô tả

        [DataType(DataType.Date)]
        [Display(Name = "Ngày khởi chiếu")]
        public DateTime? filmStartDate { set; get; }       //  Ngày khởi chiếu

        public string filmGenreId { set; get; }            //  Phân loại độ tuổi

        [ForeignKey("filmGenreId")]
        public virtual FilmGenreModel filmGenre { set; get; }

        [Display(Name = "Đạo diễn")]
        public string filmDirector { set; get; }           //  Đạo diễn

        [Display(Name = "Diễn viên chính")]
        public string filmMainActors { set; get; }         //  Diễn viên chính

        [Display(Name = "Ảnh - Poster")]
        public string filmPosterImage { set; get; }        //  Ảnh Poster

        [Display(Name = "Xuất xứ")]
        public string filmCountry { set; get; }             // Quốc gia sản xuất

        [Display(Name = "Ngôn ngữ phụ đề")]
        public string languageSubtitle { set; get; }        //  Ngôn ngữ phụ đề

        [Display(Name = "Ảnh - Banner")]
        public string filmBannerImage { set; get; }
    }
}