using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyRapPhim.Models
{
    [Table("Invoice")]
    public class InvoiceModel
    {
        public string invoiceId { set; get; }

        public string ticketId { set; get; }

        [ForeignKey("ticketId")]
        public virtual TicketModel ticket { set; get; }

        public string paymentMethodId { set; get; }

        [ForeignKey("paymentMethodId")]
        public virtual PaymentMethodModel PaymentMethod { set; get; }

        public int price { set; get; }

        public string image { set; get; }
    }
}