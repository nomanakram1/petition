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
    }
}
