using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using petition.Models;
using petition.Models.DbModel;
using petition.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Controllers
{
    public class OfficeController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public OfficeController(AppDbContext context, UserManager<ApplicationIdentityUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> AddCirculatorToBatch()
        {
            createBatchVM data = new createBatchVM();
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
            }
            if (userList != null)
            {
                data.users = userList;
            }
            return View(data);
        }
        public IActionResult EditPurgeCount()
        {
            return View();
        }
        public IActionResult OperationalInfo()
        {
            return View();
        }
        public IActionResult EditPurgeCount1Line()
        {
            return View();
        }
        ////////
        public IActionResult AddBatchCircDetails(int batchid,string kpmuserid, string circfullname, int circCount, int CircNewReg)
        {
            var commandTest = "INSERT INTO dbo.BatchDetails ( batchid, circid, circfullname, circinitsigs, circrawcount, pcinitials, pcpobox, pcdiffcounty, pcincomaddr, pcAddrIllegOrCopy, pcSigPrintedOrPrintIlleg, pcNameTwiceNoSig, pcHWSignForOther, pcWomanSignMrsHusbandFname, pcForgery, pcIncomDeclCirc, pcRubStampUsed, pcPencilUsed, pcDupSig, pcWhiteOut, pcOther,CircNewReg) VALUES ('"+ batchid + "','"+kpmuserid+"','"+circfullname+"','"+circCount+"',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'"+CircNewReg+"')";
            try
            {
                context.Database.ExecuteSqlRaw(commandTest);
                return Ok();
            }catch (Exception e)
            {
                return BadRequest(e);
            }
        }
}
}
