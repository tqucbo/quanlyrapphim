using System.ComponentModel.DataAnnotations;

namespace QuanLyRapPhim.Models
{
    public class UpdatePasswordViewModel
    {
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu cũ")]
        [MinLength(8, ErrorMessage = "{0} cần {1} ký tự.")]
        public string oldPassword { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới")]
        [MinLength(8, ErrorMessage = "{0} cần {1} ký tự.")]
        public string newPassword { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.Password)]
        [Compare(nameof(newPassword), ErrorMessage = "Mật khẩu không trùng khớp")]
        [Display(Name = "Nhập lại mật khẩu mới")]
        public string confirmNewPassword { set; get; }
    }
}