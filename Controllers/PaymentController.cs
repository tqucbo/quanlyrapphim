using Castle.Core.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QRCoder;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyRapPhim.Controllers
{
    public class PaymentController : Controller
    {

        private readonly ILogger<PaymentController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        public PaymentController(ILogger<PaymentController> logger, QuanLyRapPhimDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string[] listOfChooseSeat, string filmScheduleId, int price)
        {

            MultipleViewModelForPaymentView m = new MultipleViewModelForPaymentView();

            List<SeatModel> ss = new List<SeatModel>();

            for (var i = 0; i < listOfChooseSeat.Length; i++)
            {
                var seatFromSeatModel = (from sm in _context.seats
                                         where sm.seatName == listOfChooseSeat[i]
                                         select sm).FirstOrDefault();
                ss.Add(seatFromSeatModel);
            }

            m.seatModels = ss;

            List<PaymentMethodModel> pms = (from pmm in _context.paymentMethods
                                            select pmm).ToList();

            var fs = (from fsm in _context.filmSechedules
                      where fsm.filmSecheduleId == filmScheduleId
                      select fsm).FirstOrDefault();

            m.filmSecheduleModel = fs;

            var c = (from cm in _context.cinemas
                     join crm in _context.cinemaRooms on cm.cinemaId equals crm.cinemaId
                     join fsm in _context.filmSechedules on crm.cinemaRoomId equals fsm.cinemaRoomId
                     orderby cm.cinemaName
                     where fsm.filmSecheduleId == filmScheduleId
                     select cm).FirstOrDefault();

            m.cinemaModel = c;

            m.paymentMethodModels = pms;

            m.price = price;

            return View(m);
        }

        [HttpPost]
        [Route("/createticket/", Name = "CreateTicket")]
        public async Task<IActionResult> CreateTicket(List<string> listIdOfChooseSeat, string paymentMethodName, string accountId, int price, string filmSecheduleId)
        {

            List<TicketModel> tickets = new List<TicketModel>();

            listIdOfChooseSeat.ForEach(
                i =>
                {
                    TicketModel t = new TicketModel();
                    t.accountId = accountId;
                    t.seatId = i;
                    t.filmSecheduleId = filmSecheduleId;
                    tickets.Add(t);
                    _context.Add(t);
                }
            );

            await _context.SaveChangesAsync();

            return RedirectToAction("CreateInvoice", "Payment", new
            {
                jsonTickets = JsonConvert.SerializeObject(tickets),
                paymentMethodName = paymentMethodName,
                price = price,
            });
        }

        public async Task<IActionResult> CreateInvoice(string jsonTickets, string paymentMethodName, int price)
        {
            List<TicketModel> tickets = JsonConvert.DeserializeObject<List<TicketModel>>(jsonTickets);

            string g = Guid.NewGuid().ToString();

            tickets.ForEach(
                t =>
                {
                    InvoiceModel i = new InvoiceModel();
                    i.invoiceId = g;
                    i.ticketId = t.ticketId;
                    i.paymentMethodId = (from pm in _context.paymentMethods
                                         where pm.paymentMethodName == paymentMethodName
                                         select pm).Select(pm => pm.paymentMethodId).FirstOrDefault();
                    i.price = price;

                    // QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    // QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
                    // QRCode qrCode = new QRCode(qrCodeData);
                    // Bitmap qrCodeImage = qrCode.GetGraphic(20);

                    _context.Add(i);
                }
            );

            await _context.SaveChangesAsync();

            return Json(new
            {
                url = Url.Action("PaymentSuccessfully", "Payment", new { invoiceId = g, })
            });
        }

        [Route("/paymentSuccessfully/", Name = "PaymentSuccessfully")]
        public IActionResult PaymentSuccessfully(string invoiceId)
        {

            List<InvoiceModel> invoices = (from ims in _context.invoices
                                           where ims.invoiceId == invoiceId
                                           select ims).ToList();

            return View(invoices);
            
        }
    }
}