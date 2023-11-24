using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyRapPhim.Data;
using QuanLyRapPhim.Models;

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
    }
}