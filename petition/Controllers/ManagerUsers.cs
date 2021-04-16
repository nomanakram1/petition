using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using petition.DataLayer;
using petition.DB;
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
        public async Task<ActionResult> AssignExternalValidators()
        {
            var users = await _userManager.GetUsersInRoleAsync("External Validator");

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
        public ActionResult ManageInternalValidators()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddKPMUser(string id, string fname,string lname)
        {
            var percent = await _userManager.FindByNameAsync(User.Identity.Name);
            var strdisplayname = lname + ", " + fname;
            var dnnUserID = id;
            var enteredby = percent.Id;
            var dateentered = DateTime.Now;
            var kpmusertype = "External Validator";
            int kpmuserid;
            var commandText = "INSERT INTO dbo.KpmUsers(kpmusertype, firstname, lastname, dateentered, enteredby, dnn_userid, displayname) VALUES ('" + kpmusertype + "','" + fname + "','" + lname + "','" + dateentered + "','" + enteredby + "','" + dnnUserID + "','" + strdisplayname + "' )";
                try
            {
                var result = context.Database.ExecuteSqlRaw(commandText);
                try
                {
                    commandText = "SELECT kpmuserid FROM KPM_Users where  dnn_userid = '" + dnnUserID + "'";
                    kpmuserid = context.Database.ExecuteSqlRaw(commandText);
                }catch(Exception e)
                {
                    return BadRequest(e);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            return Ok(kpmuserid);
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
        public ActionResult GetCoordinate(string type)
        {
            var commandText = "SELECT firstname, lastname, kpmuserID, coordassigned FROM KPMUsers where kpmusertype= '"+type+"' order by lastname";
            var result = context.GetCoordinate.FromSqlRaw(commandText).ToList();
            return Ok(result);
        }
        public async Task<ActionResult> Getcoordinators()
        {
            var users = await _userManager.GetUsersInRoleAsync("External Validator");

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

                return Ok(data);
            }
            return Ok();
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
        public async Task<ActionResult> addcirculator(KpmUser user)
        {
            var percent = await _userManager.FindByNameAsync(User.Identity.Name);
            user.DateEntered = DateTime.Now;
            var commandText = "INSERT INTO dbo.KpmUsers(kpmusertype, firstname, lastname, dateentered, enteredby, coordassigned, displayname, addr, city, state, zip, telephone, status) VALUES('" + user.KpmuserType + "', '" + user.FirstName + "', '" + user.LastName + "', '" + user.DateEntered + "', '" + percent.UserName + "', '" + user.CoordAssigned + "', '" + user.DisplayName + "', '" + user.Addr + "', '" + user.City + "', '" + user.State + "', '" + user.Zip + "', '" + user.Telephone + "', '" + user.Status + "')";
            try
            {
                var result = context.Database.ExecuteSqlRaw(commandText);
            }
            catch (Exception e)
            {
                return RedirectToAction("ManageCirculator", "ManagerUsers");
            }

            return RedirectToAction("ManageCirculator", "ManagerUsers");
        }
    }
}
