using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace QuanLyRapPhim.Controllers
{
    [Area("Role")]
    public class RoleController : Controller
    {
        public RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View(_roleManager.Roles);
        }

        public async Task<IActionResult> Create([Required] string name)
        {
            if (Request.Method == HttpMethod.Post.Method)
            {
                if (ModelState.IsValid)
                {
                    var result = await _roleManager.CreateAsync(new IdentityRole(name));
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                }
                return View(name);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string roleId)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(roleId);
            if (role != null)
            {
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                ModelState.AddModelError("", "No role found");
            }
            return View("Index", _roleManager.Roles);
        }
    }
}