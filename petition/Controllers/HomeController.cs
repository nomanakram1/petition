using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using petition.DataLayer;
using petition.Models;
using petition.Models.DbModel;
using petition.Models.ViewModels;
using System;
using petition.DB;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserRolesDL _userRoles;

        public HomeController(AppDbContext context, UserManager<ApplicationIdentityUser> userManager, ILogger<HomeController> logger, IUserRolesDL userRolesDL ,RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            _userRoles = userRolesDL;
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> ChangeCredentials(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            UserListVM userdata = new UserListVM();
            userdata.email = user.Email;
            userdata.userName = user.UserName;
            userdata.userId = userId;
            return View(userdata);
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("admin", "home");
            }
            return View();
        }
        public IActionResult Petitions()
        {
            var petitions = context.Petitions.FromSqlRaw("SELECT * FROM dbo.Petitions").ToList();
            return View(petitions);
        }
        public IActionResult admin()
        {
            return View();
        }
        [HttpGet("updateBatchesStatus")]
        public IActionResult updateBatchesStatus()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            var users = await _userManager.GetUsersInRoleAsync("User");
            List<UserListVM> userList = new List<UserListVM>();
            if (users.Any())
            {
                foreach(var user in users)
                {
                    userList.Add(new UserListVM{
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
            return View(userList);
        }
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> AddRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            UserListVM userdata = new UserListVM();
            userdata.userId = user.Id;
            userdata.userName = user.UserName;
            var roles = _roleManager.Roles;
            List<RolesVM> rolesVM = new List<RolesVM>();
            if (roles.Any())
            {
                foreach(var role in roles)
                {
                    rolesVM.Add(new RolesVM
                    {
                        roleName = role.Name,
                        roleId = role.Id,
                    });
                }
            }
            var userroles = await _userRoles.GetUserRoleList(id);
            List<UserRolesVM> userRolesVM = new List<UserRolesVM>();
            if(userroles != null)
            {
                foreach(var userRole in userroles)
                {
                    userRolesVM.Add(new UserRolesVM
                    {
                        Id = userRole.id,
                        roleId = userRole.roleId,
                        roleName = userRole.roleName,
                        userId = userRole.userId,
                        effectiveDate = userRole.effectiveDate,
                        expiryDate = userRole.expiryDate
                    });
                }
            }
            
            RolesUserRolesVM combiner = new RolesUserRolesVM
            {
                UserData = userdata,
                Roles = rolesVM,
                UserRoles = userRolesVM,
            };
            return View(combiner);
        }

        [HttpGet]
        public IActionResult DeleteUser(string userId)
        {
            var user = _userManager.FindByIdAsync(userId).Result;
            _userManager.DeleteAsync(user);
            _userRoles.DeleteRolesByUserId(userId);
            return RedirectToAction("userList", "home");
        }

        [HttpPost]
        public async Task<IActionResult> updateUser(UserListVM model)
        {
            var user = await _userManager.FindByIdAsync(model.userId);
            if(user != null)
            {
                try
                {
                    user.Address = model.address;
                    user.City = model.city;
                    user.State = model.state;
                    user.ZipCode = model.zipCode;
                    user.PhoneNumber = model.phoneNumber;
                    user.FirstName = model.firstName;
                    user.LastName = model.lastName;
                    var result = await _userManager.UpdateAsync(user);
                }catch(Exception)
                {
                    return RedirectToAction("userList", "home");
                }

            }
            return RedirectToAction("userList", "home");
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(UserRolesVM model)
        {
            var user =await _userManager.FindByIdAsync(model.userId);
            var roledata = model.roleId.Split(",");
            var IsInRole = await _userManager.IsInRoleAsync(user, roledata[1]);
            if(!IsInRole)
            {
                model.roleId = roledata[0];
                model.roleName = roledata[1];
                UserRole userRole = new UserRole();
                userRole.effectiveDate = model.effectiveDate;
                userRole.expiryDate = model.expiryDate;
                userRole.roleId = model.roleId;
                userRole.roleName = model.roleName;
                userRole.userId = model.userId;
                await _userManager.AddToRoleAsync(user, model.roleName);
                var result = _userRoles.InsertUserRole(userRole);
                if (result != null)
                {
                    return RedirectToAction("addroles", "home", new { id = model.userId });
                    //return Redirect("/home/addroles/" + model.userId);
                }
            }
            return RedirectToAction("addroles", "home", new { id = model.userId });
            //return Redirect("/home/addroles/" + model.userId);

        }
        [HttpPost]
        public IActionResult AddPetition(Petition model)
        {
            var commandText = "Insert INTO dbo.petitions(Petitionname, PetitionDescription, dateentered, enteredby, citypetition) VALUES('" + model.Petitionname + "', '" + model.Petitiondescription + "', '" + model.DateEntered + "', '" + model.EnteredBy + "', '" + model.CityPetition + "')";
            //var name = new SqlParameter("@CategoryName", "Test");
            var result = context.Database.ExecuteSqlRaw(commandText);
            //var result = context.Petitions.FromSqlRaw("Insert INTO dbo.petitions(Petitionname, PetitionDescription, dateentered, enteredby, citypetition) VALUES('" + model.Petitionname + "', '" + model.Petitiondescription + "', '" + model.DateEntered + "', '" + model.EnteredBy + "', '" + model.CityPetition + "')");
            return RedirectToAction("petitions", "home");
        }
        [HttpGet]
        public IActionResult DeletePetition(int Id)
        {
            var commandText = "DELETE FROM dbo.petitions WHERE (petitionid = '" + Id + "')";
            var result = context.Database.ExecuteSqlRaw(commandText);
            return RedirectToAction("petitions", "home");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteRole(string roleId, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            
            if(user != null)
            {
                var role = await _roleManager.FindByIdAsync(roleId);
                if (role != null)
                {
                    var res = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
            }
            var result = _userRoles.DeleteRole(roleId,userId);
            if (result != null)
            {
                return RedirectToAction("addroles", "home", new { id = userId });
            }
            return Ok();

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
