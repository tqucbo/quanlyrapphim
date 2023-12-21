using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{
    [Table("PaymentMethod")]
    public class PaymentMethodModel
    {

        [Key]
        public string paymentMethodId { set; get; }

        public string paymentMethodName { set; get; }

        public string paymentMethodNote { set; get; }

        public string paymentMethodImage { set; get; }
    }
}