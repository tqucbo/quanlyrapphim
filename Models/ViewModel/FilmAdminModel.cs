using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace QuanLyRapPhim.Models
{
    public class FilmAdminModel
    {
        [Display(Name = "Tên phim")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string filmName { set; get; }

        [Display(Name = "Độ dài")]
        public int filmLength { set; get; }

        [Display(Name = "Thể loại")]
        public string filmMainCategoryId { set; get; }

        [Display(Name = "Mô tả")]
        public string filmDescription { set; get; }

        [Display(Name = "Ngày khởi chiếu")]
        public DateTime? filmStartDate { set; get; }

        [Display(Name = "Phân loại độ tuổi")]
        public string filmGenreId { set; get; }

        [Display(Name = "Đạo diễn")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string filmDirector { set; get; }

        [Display(Name = "Diễn viên")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string filmMainActors { set; get; }

        [Display(Name = "Xuất xứ")]
        public string filmCountry { set; get; }

        [Display(Name = "Ngôn ngữ phụ đề")]
        public string languageSubtitle { set; get; }
    }
}