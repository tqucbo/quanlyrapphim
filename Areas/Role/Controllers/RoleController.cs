using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyRapPhim.Models;

namespace QuanLyRapPhim.Controllers
{
    [Area("Role")]
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        public RoleManager<IdentityRole> _roleManager;

        public UserManager<AppUserModel> _userManager;

        public RoleController(
            RoleManager<IdentityRole> roleManager,
            UserManager<AppUserModel> userManager
            )
        {
            _roleManager = roleManager;
            _userManager = userManager;
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

                    if (await _roleManager.RoleExistsAsync(name) == true)
                    {
                        ModelState.AddModelError("", "Đã có quyền này");
                    }

                    var result = await _roleManager.CreateAsync(new IdentityRole(name));

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }
                return View(name);
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> DeleteConfirm(string roleId)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(roleId);

            if (role != null)
            {
                return View(role);
            }
            return View();
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
                ModelState.AddModelError("", "Không tìm thấy quyền nào");
            }
            return View("Index", _roleManager.Roles);
        }
    }
}