// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using QuanLyRapPhim.Data;
// using QuanLyRapPhim.Models;
// using System.Linq;

// namespace QuanLyRapPhim.Controllers
// {
//     public class BuyingTicketSuccessfullyController : Controller {

//         private readonly ILogger<BuyingTicketSuccessfullyController> _logger;

//         private readonly QuanLyRapPhimDBContext _context;

//         public BuyingTicketSuccessfullyController(ILogger<BuyingTicketSuccessfullyController> logger, QuanLyRapPhimDBContext context)
//         {
//             _logger = logger;
//             _context = context;
//         }

//         public IActionResult Index(string invoiceId) {

//             List<InvoiceModel> invoices = (from ims in _context.invoices 
//                                             where ims.invoiceId == invoiceId 
//                                             select ims).ToList();

//             return View(invoices);
//         }
//     }
// }