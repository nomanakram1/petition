using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using petition.DataLayer;
using petition.Models.DbModel;
using petition.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using petition.Models;

namespace petition.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;
        public AccountController(AppDbContext context, UserManager<ApplicationIdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationIdentityUser> signInManager)
        {
            this.context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        //[Authorize]
        //[HttpGet]
        //public async Task<ActionResult> GetUserData()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        var user = await _userManager.FindByIdAsync(User.Identity.Name);
        //        return Ok(user);
        //    }
        //    return StatusCode(401);
        //}

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = new ApplicationIdentityUser
                    {
                        FirstName = model.firstName,
                        LastName = model.lastName,
                        UserName = model.userName,
                        Email = model.email,
                        PhoneNumber = model.phoneNumber,
                        City = model.city,
                        State = model.state,
                        Address = model.address,
                        ZipCode = model.zipCode
                    };
                    var result = await _userManager.CreateAsync(user, model.password);
                    var userRole = new IdentityRole("User");
                    var roleresult = await _roleManager.RoleExistsAsync(userRole.Name);
                    if (!roleresult)
                    {
                        await _roleManager.CreateAsync(userRole);
                    }
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, userRole.Name);
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("index","home");
                    }
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }catch (Exception ex)
                {
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                    var result = await _signInManager.PasswordSignInAsync(model.userName, model.password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("index", "home");
                    }
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login", "account");
        }

        [HttpPost]
        public async Task<ActionResult> ResetPassword(ResetPasswordVM model)
        {
            var user = await _userManager.FindByIdAsync(model.userId);
            if (user != null)
            {
                string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, resetToken, model.newPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction("userList", "home");
                }
            }
            return RedirectToAction("userList", "home");
        }
        [HttpPost]
        public async Task<ActionResult> UpdateEmail(UpdateEmailVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.currentEmail);
                if (user != null)
                {
                    user.Email = model.newEmail;
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("userList", "home");
                    }
                }
            }
            return RedirectToAction("userList", "home");
        }

    }
}
