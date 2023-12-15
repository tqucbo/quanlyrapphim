using System.ComponentModel.DataAnnotations;

namespace QuanLyRapPhim.Models
{
    public class MemberInfoViewModel
    {
        [Display(Name = "Số điện thoại")]
        public string userName { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [MaxLength(100)]
        [Display(Name = "Tên đầy đủ")]
        public string fullName { set; get; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Hòm thư Email")]
        public string email { set; get; }

        [Display(Name = "Căn cước công dân")]
        public string peopleId { set; get; }
    }
}