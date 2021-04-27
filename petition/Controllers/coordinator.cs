using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using petition.DataLayer;
using petition.Models;
using petition.Models.DbModel;
using petition.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Controllers
{

    public class Coordinator : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IPetetionDL petetion;
        public Coordinator(AppDbContext context, UserManager<ApplicationIdentityUser> userManager, RoleManager<IdentityRole> roleManager, IPetetionDL _petetion)
        {
            this.context = context;
            petetion = _petetion;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult BatchSheets()
        {
            return View();
        }
        public async Task<IActionResult> ManageBatches()
        {
            createBatchVM data = new createBatchVM();
            List<GetPetetion> p = petetion.GetPetition();
            var users = await _userManager.GetUsersInRoleAsync("User");
            List<UserListVM> userList = new List<UserListVM>();
            if (users.Any())
            {
                foreach (var user in users)
                {
                    userList.Add(new UserListVM
                    {
                        userId = user.Id,
                        userName = user.UserName,
                        firstName = user.FirstName,
                        lastName = user.LastName,
                        address = user.Address,
                        zipCode = user.ZipCode,
                        state = user.State,
                        city = user.City,
                        phoneNumber = user.PhoneNumber,
                        authorize = user.Authorize,
                        email = user.Email
                    });
                }
            }
            if (p != null)
            {
                data.petitons = p;
            }
            if (userList != null)
            {
                data.users = userList;
            }

            return View(data);
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult CirculatorActivity()
        {
            return View();
        }
        public IActionResult MyTotals()
        {
            return View();
        }
    }
}
