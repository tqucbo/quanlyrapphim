using System.ComponentModel.DataAnnotations;

namespace QuanLyRapPhim.Models
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Không được bỏ trống")]
        [MaxLength(50)]
        [Display(Name = "Tên đăng nhập")]
        public string userName { set; get; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [MaxLength(100)]
        [Display(Name = "Tên đầy đủ")]
        public string fullName { set; get; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Hòm thư Email")]
        public string email { set; get; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Điện thoại")]
        public string phoneNumber { set; get; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [Display(Name = "Căn cước công dân")]
        public string peopleId { set; get; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string password { set; get; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.Password)]
        [Compare(nameof(password), ErrorMessage = "Mật khẩu không trùng khớp")]
        [Display(Name = "Nhập lại mật khẩu")]
        public string confirmPassword { set; get; }
    }
}