using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Controllers
{
    public class Coordinator : Controller
    {
        public IActionResult BatchSheets()
        {
            return View();
        }
        public IActionResult ManageBatches()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult CirculatorActivity()
        {
            return View();
        }
        public IActionResult MyTotals()
        {
            return View();
        }
    }
}
