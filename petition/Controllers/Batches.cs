using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
    public class BatchesController : Controller
    {
        private readonly IBatchDL batch;
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IPetetionDL petetion;
        public BatchesController(AppDbContext context, IBatchDL _batch, UserManager<ApplicationIdentityUser> userManager, ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager, IPetetionDL _petetion)
        {
            this.context = context;
            _logger = logger;
            petetion = _petetion;
            batch = _batch;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> updateBatchesStatus()
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
        public async Task<IActionResult> createBatches()
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

        [HttpPost]
        public async Task<ActionResult> addBatches(createbach batch)
        {
            var percent = await _userManager.FindByNameAsync(User.Identity.Name);
            var commandText = "declare @batchcount int select @batchcount = count(batchid) from dbo.batches where petitionid = " + batch.petitionId + " INSERT INTO dbo.Batches(KPMUserID, KPMUserName, DateAssgBatch, PetitionID, enteredby, sigamount, initialcount, submittedcount,RawComplete,ProcessingComplete,ValidationComplete,ChargeBackCount) VALUES('" + batch.kpmuserId + "', '" + batch.kpmuserName + "', '" + batch.dateAssgBatch + "', '" + batch.petitionId + "', '" + percent.UserName + "', '" + batch.sigValue + "', 0 , 0,0,0,0,"+0+")";
            try
            {
                var result = context.Database.ExecuteSqlRaw(commandText);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
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
                return RedirectToAction("addDeleteCirculer", "Batches");
            }

            return RedirectToAction("addDeleteCirculer", "Batches");
        }

        [HttpPost]
        public ActionResult changeStatus(string status, int id)
        {
            var commandText = "UPDATE dbo.KpmUsers SET status = '" + status + "' where (KPMUserID = '" + id + "')";
            try
            {
               var result = context.Database.ExecuteSqlRaw(commandText);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpPost]
        public ActionResult UpdateCircInfo(string addr, string city, string state, string zip, string telephone, int id)
        {
            var commandText = "UPDATE dbo.KpmUsers SET addr = '" + addr + "', city = '" + city + "', state = '" + state + "', zip = '" + zip + "', telephone = '" + telephone + "' where (KPMUserID = '" + id + "')";
            try
            {
                var result = context.Database.ExecuteSqlRaw(commandText);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
            return Ok();
        }
        public ActionResult getcirculator(string id)
        {
            var commandText = "SELECT DISTINCT firstname, lastname,  kpmuserID, coordassigned, displayname, addr, city, state, zip, telephone, status FROM kpmUsers where kpmusertype= 'KPM Circulator' and coordassigned= '" + id + "' and status= 'active' order by lastname";
            var result = context.GetCirculator.FromSqlRaw(commandText).ToList();
            return Ok(result);
        }
        public ActionResult displayBatch(int id)
        {
            try
            {
                var commandText = "select distinct firstname, lastname, kpmuserid, batchid, circinitsigs, entryid, circrawcount,pcInitials, pcpobox, pcdiffcounty, pcIncomAddr, pcAddrIllegOrCopy, pcSigPrintedOrPrintIlleg, pcNameTwiceNoSig, pcHWSignForOther, pcWomanSignMrsHusbandFname, pcForgery, pcIncomDeclCirc, pcRubStampUsed, pcPencilUsed, pcDupSig, pcWhiteOut, pcOther, CircNewReg, BatchStatus, (circrawcount) - (pcInitials + pcpobox+ pcdiffcounty+ pcIncomAddr+ pcAddrIllegOrCopy+pcSigPrintedOrPrintIlleg + pcNameTwiceNoSig + pcHWSignForOther + pcWomanSignMrsHusbandFname + pcForgery + pcIncomDeclCirc + pcRubStampUsed + pcPencilUsed + pcDupSig + pcWhiteOut + pcOther) As TotalSigs, (pcInitials + pcpobox+ pcdiffcounty+ pcIncomAddr+pcAddrIllegOrCopy+pcSigPrintedOrPrintIlleg + pcNameTwiceNoSig + pcHWSignForOther + pcWomanSignMrsHusbandFname + pcForgery +pcIncomDeclCirc + pcRubStampUsed + pcPencilUsed + pcDupSig + pcWhiteOut + pcOther) As BadTotal, CircNewReg + circinitsigs As SubmittedCount from(BatchDetails As b inner join KpmUsers As u On b.circid = u.kpmuserid ) where b.batchid ='" + id + "' order by entryid";
                var result = context.DisplayBatchList.FromSqlRaw(commandText).ToList();
                return Ok(result);
            }catch(Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
        public ActionResult DisplayBathListForPrint(int id)
        {
            try
            {
                SqlParameter BatchID = new SqlParameter("@BatchID", id);
                var result = context.DisplayBathListForPrint.FromSqlRaw("EXEC BatchDetailWithCalculations @BatchID", BatchID).ToList();
                return Ok(result);
            }catch(Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
        public ActionResult getbatchlist(string id)
        {
            //var commandText = "SELECT dbo.Batches.BatchID, dbo.Batches.KPMUserID, dbo.Batches.dateAssgBatch, dbo.AspNetUsers.LastName, dbo.Petitions.petitionname, dbo.batches.sigvalue,dbo.batches.sigamount, dbo.Batches.dateReceivedBatch, dbo.batches.SubmittedCount, dbo.batches.RawCount, dbo.batches.PurgedCount, dbo.batches.petitionid, dbo.batches.datesubmitted FROM dbo.Batches INNER JOIN dbo.AspNetUsers ON dbo.Batches.KPMUserID = dbo.AspNetUsers.Id INNER JOIN dbo.Petitions ON dbo.Batches.PetitionID = dbo.Petitions.PetitionID where dbo.batches.kpmuserid = '"+id+"' and datesubmitted is not null";
            var commandText = "SELECT dbo.Batches.BatchID, dbo.Batches.KPMUserID, dbo.Batches.dateAssgBatch, dbo.AspNetUsers.LastName, dbo.Petitions.petitionname, dbo.batches.sigvalue,dbo.batches.sigamount, dbo.Batches.dateReceivedBatch, dbo.batches.SubmittedCount, dbo.batches.RawCount, dbo.batches.PurgedCount, dbo.batches.petitionid, dbo.batches.datesubmitted FROM dbo.Batches INNER JOIN dbo.AspNetUsers ON dbo.Batches.KPMUserID = dbo.AspNetUsers.Id INNER JOIN dbo.Petitions ON dbo.Batches.PetitionID = dbo.Petitions.PetitionID where dbo.batches.kpmuserid = '"+id+"'";
            var result = context.GetBatchList.FromSqlRaw(commandText).ToList();
            return Ok(result);
        }

        /// get batches using petitionId and cordinatorId
        public ActionResult getBatches(string KPMUserId, int PetitionId)
        {
            var result = batch.Getbatch(KPMUserId, PetitionId);
            return Ok(result);
        }

        public ActionResult DeleteBatche(int Id)
        {
            var result = batch.DeleteBatche(Id);
            return RedirectToAction("updateBatchesStatus","Batches");
        }
        public async Task<IActionResult> addDeleteCirculer()
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
        public async Task<IActionResult> editPurgeCount()
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
        public async Task<IActionResult> viewPrintBatches()
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
        public IActionResult missingDataReceive()
        {
            return View();
        }
    }
}
