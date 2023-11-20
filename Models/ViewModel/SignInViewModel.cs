using System.ComponentModel.DataAnnotations;

namespace QuanLyRapPhim.Models
{
    public class SignInViewModel
    {

        [Required]
        public string userNameOrPhoneNumberOrEmail { set; get; }

        [Required]
        public string password { set; get; }

        [Required]
        public bool rememberMe { set; get; }
    }
}