using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{
    [Table("Account")]
    public class AccountModel
    {
        [Key]
        public string accountId { set; get; }                  // Mã tài khoản

        public string accountName { set; get; }                // Tên tài khoản

        public string accountAddress { set; get; }             // Địa chỉ tài khoản

        [DataType(DataType.EmailAddress)]
        public virtual string accountEmail { set; get; }               // Email tài khoản

        public string accountPeopleId { set; get; }            // Số CCCD, CMND

        public string accountPhoneNumber { set; get; }         // Điện thoại tài khoản

        public int accountMembershipPoint { set; get; }        // Điểm số thành viên

        public bool accountAdmin { set; get; }                 // Quyền Quản trị viên (True, False)

        [DataType(DataType.Password)]
        public virtual string accountPasswordHashed { set; get; }

    }
}