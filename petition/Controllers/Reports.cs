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
        public IActionResult CountyAnalysis()
        {
            return View();
        }
        public IActionResult CoordinatorBatchReport()
        {
            return View();
        }
        public IActionResult CoordinatorVoterActivity()
        {
            return View();
        }
    }
}
