using System;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QuanLyRapPhim.Models;

namespace QuanLyRapPhim.Controllers
{
    public class MessageController : Controller
    {

        private readonly ILogger<MessageController> _logger;

        public MessageController(ILogger<MessageController> logger)
        {
            _logger = logger;
        }

        [Route("/RegisterSuccesfully/", Name = "RegisterSuccesfully")]
        [Route("/RegisterFailed/", Name = "RegisterFailed")]
        public IActionResult Index(string message)
        {
            if (Request.GetDisplayUrl().Contains("RegisterSuccesfully"))
            {
                return View(
                new MessageViewModel()
                {
                    title = "Đăng ký thành công",
                    content = "Tài khoản của bạn đã đăng ký thành công, vui lòng thực hiện đăng nhập.",
                    urlRedirect = Url.Action("Index", "Home"),
                }
            );
            }
            else if (Request.GetDisplayUrl().Contains("RegisterFailed"))
            {
                return View(
                new MessageViewModel()
                {
                    title = "Đăng ký không thành công",
                    content = "Đã xảy ra lỗi, vui lòng thử lại.",
                    urlRedirect = Url.Action("Index", "Home"),
                }
                );
            }
            else
            {
                return View(
                new MessageViewModel()
                {
                    title = "Đã xảy ra lỗi",
                    content = "Đã xảy ra lỗi, vui lòng thử lại. Điều hướng về trang chủ trong 5 giây.",
                    urlRedirect = Url.Action("Index", "Home"),
                }
                );
            }

        }


    }
}