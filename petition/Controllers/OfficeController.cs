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
        public async Task<IActionResult> EditPurgeCount()
        {
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
                createBatchVM data = new createBatchVM();
                if (userList != null)
                {
                    data.users = userList;
                }

                return View(data);
            }
            return View();
        }
        public IActionResult OperationalInfo()
        {
            return View();
        }
        public IActionResult OneLineEditPurgeCount()
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
        public IActionResult GetCircBatchDetails(int enterid)
        {
            try
            {
                var commandText = "select circinitsigs, entryid, circrawcount, pcInitials, pcpobox, pcdiffcounty, pcIncomAddr, pcAddrIllegOrCopy, pcSigPrintedOrPrintIlleg, pcNameTwiceNoSig, pcHWSignForOther, pcWomanSignMrsHusbandFname, pcForgery, pcIncomDeclCirc, pcRubStampUsed, pcPencilUsed, pcDupSig, pcWhiteOut, pcOther from batchdetails as b where entryid = '"+enterid+"'";
                var result = context.GetCircBatchDetails.FromSqlRaw(commandText).ToList();
                return Ok(result);
            }catch(Exception e)
            {
                return BadRequest(e);
            }
        }
        public IActionResult UpdateBatchEntry(int raw,int A, int B, int C, int D, int E, int F, int G, int H, int J, int K, int L, int M, int P, int R, int S, int T, int enterid)
        {
            try
            {
                var commandText = "UPDATE dbo.BatchDetails SET circrawcount = '"+raw+"', pcinitials = '"+A+"', pcpobox = '"+B+"', pcdiffcounty = '"+C+"', pcincomaddr= '"+D+"', pcAddrIllegOrCopy= '"+E+"', pcSigPrintedOrPrintIlleg= '"+F+"', pcNameTwiceNoSig= '"+G+"', pcHWSignForOther = '"+H+"', pcWomanSignMrsHusbandFname= '"+J+"', pcForgery= '"+K+"', pcIncomDeclCirc= '"+L+"', pcRubStampUsed= '"+M+"', pcPencilUsed= '"+P+"', pcDupSig= '"+R+"', pcWhiteOut= '"+S+"', pcOther= '"+T+"' where (entryID = '"+enterid+"')";
                var result = context.Database.ExecuteSqlRaw(commandText);
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
