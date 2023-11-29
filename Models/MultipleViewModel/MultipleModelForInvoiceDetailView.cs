using System.Collections.Generic;

namespace QuanLyRapPhim.Models
{
    public class MultipleModelForInvoiceDetailView
    {
        public InvoiceModel invoice { set; get; }

        public List<string> listOfSeat { set; get; }
    }
}