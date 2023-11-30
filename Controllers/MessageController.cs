using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
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
        [Route("/UpdateSuccesfully/", Name = "UpdateSuccesfully")]
        [Route("/UpdateFailed/", Name = "UpdateFailed")]
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
            else if (Request.GetDisplayUrl().Contains("UpdateSuccesfully"))
            {
                return View(
                new MessageViewModel()
                {
                    title = "Cập nhật thông tin thành công",
                    content = "Tài khoản của bạn đã cập nhật thành công.",
                    urlRedirect = Url.Action("Index", "Home"),
                }
                );
            }
            else if (Request.GetDisplayUrl().Contains("UpdateFailed"))
            {
                return View(
                new MessageViewModel()
                {
                    title = "Cập nhật thông tin không thành công",
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
                    content = "Đã xảy ra lỗi, vui lòng thử lại.",
                    urlRedirect = Url.Action("Index", "Home"),
                }
                );
            }

        }


    }
}