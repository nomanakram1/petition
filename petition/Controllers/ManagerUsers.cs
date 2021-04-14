using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
    public class ManagerUsers : Controller
    {
        private readonly IBatchDL batch;
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IPetetionDL petetion;
        public ManagerUsers(AppDbContext context, UserManager<ApplicationIdentityUser> userManager, ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager, IPetetionDL _petetion)
        {
            this.context = context;
            _logger = logger;
            petetion = _petetion;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<ActionResult> ManageCirculator()
        {
            return View();
        }
        public async Task<ActionResult> AssignExternalValidators()
        {
            return View();
        }
        public async Task<ActionResult> ManageInternalValidators()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> AssignCoordinators()
        {
            var users = await _userManager.GetUsersInRoleAsync("KPM Coordinator");

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
                createBatchVM data = new createBatchVM();
                if (userList != null)
                {
                    data.users = userList;
                }

                return View(data);
            }
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> GetCoordinate(string type)
        {
            var commandText = "SELECT firstname, lastname, kpmuserID, coordassigned FROM KPMUsers where kpmusertype= '"+type+"' order by lastname";
            var result = context.GetCoordinate.FromSqlRaw(commandText).ToList();
            return Ok(result);
        }
        public async Task<IActionResult> AssignSubCoordinators()
        {
            var users = await _userManager.GetUsersInRoleAsync("KPM_SubCoordinator");

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
                createBatchVM data = new createBatchVM();
                if (userList != null)
                {
                    data.users = userList;
                }

                return View(data);
            }
            return View();
        }
    }
}
