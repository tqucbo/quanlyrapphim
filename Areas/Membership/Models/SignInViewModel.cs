using System.ComponentModel.DataAnnotations;

namespace QuanLyRapPhim.Models
{
    public class SignInViewModel
    {

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [Display(Name = "Số điện thoại hoặc Email")]
        public string userNameOrEmail { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [Display(Name = "Mật khẩu")]
        public string password { set; get; }
    }
}