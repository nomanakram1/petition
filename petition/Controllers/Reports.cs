using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Controllers
{
    public class Reports : Controller
    {
        public IActionResult NewBatchSubmission()
        {
            return View();
        }
        public IActionResult PetitionStatistics()
        {
            return View();
        }
        public IActionResult CountyAnalysis()
        {
            return View();
        }
        public IActionResult CoordinatorBatchReport()
        {
            return View();
        }
    }
}
