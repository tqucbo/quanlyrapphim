using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;
using System.Linq;

namespace QuanLyRapPhim.Controllers
{
    public class MembershipController : Controller
    {

        private readonly ILogger<MembershipController> _logger;

        private readonly QuanLyRapPhimDBContext _context;

        private readonly SignInManager<AppUserModel> _signInManager;

        private readonly UserManager<AppUserModel> _userManager;

        public MembershipController(
            ILogger<MembershipController> logger,
            QuanLyRapPhimDBContext context,
            SignInManager<AppUserModel> signInManager,
            UserManager<AppUserModel> userManager
        )
        {
            _logger = logger;
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [Route("/Login", Name = "Login")]
        public async Task<IActionResult> Login([FromForm] SignInViewModel loginUser)
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            if (Request.Method == HttpMethod.Post.Method)
            {
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(
                        loginUser.userNameOrEmail,
                        loginUser.password,
                        true,
                        true
                    );

                    if (!result.Succeeded)
                    {
                        var user = await _userManager.FindByEmailAsync(loginUser.userNameOrEmail);
                        if (user != null)
                        {
                            result = await _signInManager.PasswordSignInAsync
                            (
                                user,
                                loginUser.password,
                                true,
                                true
                            );
                        }
                    }

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewData["Message"] = "Tài khoản không tồn tại hoặc Mật khẩu không đúng";
                    }
                }
            }
            else
            {
                ModelState.Clear();
            }

            return View(loginUser);
        }

        public async Task<IActionResult> Logout()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }

            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Route("/Register", Name = "Register")]
        public async Task<IActionResult> Register([FromForm] RegisterViewModel registerUser)
        {
            if (Request.Method == HttpMethod.Post.Method)
            {
                if (ModelState.IsValid)
                {
                    var result = await _userManager.CreateAsync(new AppUserModel()
                    {
                        UserName = registerUser.userName,
                        fullName = registerUser.fullName,
                        Email = registerUser.email,
                        peopleId = registerUser.peopleId
                    }, registerUser.password);

                    if (result.Succeeded)
                    {
                        return Redirect(Url.RouteUrl("RegisterSuccesfully"));
                    }
                    else
                    {
                        return Redirect(Url.RouteUrl("RegisterFailed"));
                    }
                }
            }
            else
            {
                ModelState.Clear();
            }

            return View(registerUser);
        }

        public async Task<IActionResult> Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);

                MemberInfoViewModel m = new MemberInfoViewModel()
                {
                    userName = user.UserName,
                    fullName = user.fullName,
                    email = user.Email,
                    peopleId = user.peopleId,
                };

                return View(m);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public async Task<IActionResult> UpdateInfo([FromForm] MemberInfoViewModel memberInfo)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);

                if (Request.Method == HttpMethod.Post.Method)
                {
                    if (ModelState.IsValid)
                    {
                        if (user.Email != memberInfo.email)
                        {
                            user.Email = memberInfo.email;
                        }

                        if (user.fullName != memberInfo.fullName)
                        {
                            user.fullName = memberInfo.fullName;
                        }

                        var result = await _userManager.UpdateAsync(user);

                        if (result.Succeeded)
                        {
                            return Redirect(Url.RouteUrl("UpdateSuccesfully"));
                        }
                        else
                        {
                            return Redirect(Url.RouteUrl("UpdateFailed"));
                        }
                    }
                }
                else
                {
                    ModelState.Clear();
                }
                return View(new MemberInfoViewModel()
                {
                    userName = user.UserName,
                    fullName = user.fullName,
                    email = user.Email,
                    peopleId = user.peopleId,
                });
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public async Task<IActionResult> UpdatePassword([FromForm] UpdatePasswordViewModel updatePassword)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);

                if (Request.Method == HttpMethod.Post.Method)
                {

                    if (ModelState.IsValid)
                    {
                        if (await _userManager.CheckPasswordAsync(user, updatePassword.oldPassword) == true)
                        {
                            var result = await _userManager.ChangePasswordAsync(user, updatePassword.oldPassword, updatePassword.newPassword);

                            if (result.Succeeded)
                            {
                                return Redirect(Url.RouteUrl("UpdateSuccesfully"));
                            }
                            else
                            {
                                return Redirect(Url.RouteUrl("UpdateFailed"));
                            }
                        }
                        else
                        {
                            ViewData["Message"] = "Mật khẩu cũ không đúng";
                            return View(updatePassword);
                        }
                    }
                }
                else
                {
                    ModelState.Clear();
                }
                return View(updatePassword);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public async Task<IActionResult> PaymentHistory()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);

                var userId = await _userManager.GetUserIdAsync(user);

                List<InvoiceModel> invoices = (from i in _context.invoices
                                               where i.ticket.accountId == userId
                                               orderby i.orderDate descending, i.orderTime descending
                                               select i).ToList();

                List<string> invoiceIds = invoices.Select(i => i.invoiceId).Distinct().ToList();

                List<InvoiceModel> invoices1 = new List<InvoiceModel>();

                invoiceIds.ForEach(i =>
                {
                    var invoice = (
                        from j in _context.invoices
                        where j.invoiceId == i
                        select j
                    ).FirstOrDefault();

                    invoices1.Add(invoice);
                });

                return View(invoices1);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult InvoiceDetail(string invoiceId)
        {
            InvoiceModel invoice = (
                from i in _context.invoices
                where i.invoiceId == invoiceId
                select i
            ).FirstOrDefault();

            List<string> listOfSeat = (
                from i in _context.invoices
                where i.invoiceId == invoiceId
                select $"{i.ticket.seat.seatRowChar}{i.ticket.seat.seatColumnNumber}"
            ).ToList();

            return View(new MultipleModelForInvoiceDetailView()
            {
                invoice = invoice,
                listOfSeat = listOfSeat,
            });
        }
    }
}
