using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using petition.Models;
using petition.Models.DbModel;
using petition.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Controllers
{
    public class Reports : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        public Reports(AppDbContext context, UserManager<ApplicationIdentityUser> userManager, ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public ActionResult NewBatchSubmission()
        {
            var petitions = context.Petitions.FromSqlRaw("SELECT * FROM dbo.Petitions").ToList();
            return View(petitions);
        }
        public async Task<ActionResult> CoordinatorBatchReport()
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
        public async Task<ActionResult> CoordinatorVoterActivity()
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

        public ActionResult BatchesGetSubmittedbyPetByDateRange(string id, DateTime endDate, DateTime startDate)
        {
            try
            {
                int Petitionid = Convert.ToInt32(id);
                SqlParameter petitionid = new SqlParameter("@petitionid", Petitionid);
                SqlParameter startdate = new SqlParameter("@startdate", startDate);
                SqlParameter enddate = new SqlParameter("@enddate", endDate);
                var result = context.KPMBatchesGetSubmittedByPetByDateRange.FromSqlRaw("EXEC [dbo].KPMBatchesGetSubmittedByPetByDateRange @petitionid=" + Petitionid + ", @startdate='" + startDate + "', @enddate='" + endDate + "'").ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        public IActionResult PetitionStatistics()
        {
            return View();
        }
        public ActionResult PetitionFullStatsSubmitted()
        {
            try
            {
                var result = context.PetitionStatsSubmitted.FromSqlRaw("EXEC [dbo].KPMPetitionFullStatsSubmitted").ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        public ActionResult GetPetitionCountyStats(string id,DateTime date)
        {
            try
            {
                SqlParameter petid = new SqlParameter("@petid", id);
                SqlParameter startdate = new SqlParameter("@reportdate", date);
                var result = context.GetPetitionCountyStats.FromSqlRaw("EXEC [dbo].voterrecordcount2 @petid=" + id + ", @reportdate='" + date + "'").ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        public ActionResult CoordBatchListSubmitted(string id)
        {
            try
            {
                SqlParameter petid = new SqlParameter("@petid", id);
                var result = context.CoordBatchListSubmit.FromSqlRaw("EXEC [dbo].KPMCoordBatchListSubmitted @coordid='" + id+"'").ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        public IActionResult CountyAnalysis()
        {
            var petitions = context.Petitions.FromSqlRaw("SELECT * FROM dbo.Petitions").ToList();
            return View(petitions);
        }
        public IActionResult CirculatorCount()
        {
            return View();
        }
        public IActionResult InternalValidatorActivity()
        {
            return View();
        }
    }
}
