using System.ComponentModel.DataAnnotations;

namespace QuanLyRapPhim.Models
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [MaxLength(10)]
        [Display(Name = "Số điện thoại")]
        [RegularExpression("^0[0-9]*$", ErrorMessage = "{0} không đúng định dạng")]
        public string userName { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [MaxLength(100)]
        [Display(Name = "Tên đầy đủ")]
        public string fullName { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Hòm thư Email")]
        public string email { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [Display(Name = "Căn cước công dân")]
        public string peopleId { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        [MinLength(8, ErrorMessage = "{0} cần {1} ký tự.")]
        public string password { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.Password)]
        [Compare(nameof(password), ErrorMessage = "Mật khẩu không trùng khớp")]
        [Display(Name = "Nhập lại mật khẩu")]
        public string confirmPassword { set; get; }
    }
}