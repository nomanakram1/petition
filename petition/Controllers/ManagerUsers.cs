using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Controllers
{
    public class ManagerUsers : Controller
    {
        [HttpGet]
        public ActionResult AssignCoordinators()
        {
            return View();
        }
        public IActionResult AssignSubCoordinators()
        {
            return View();
        }
    }
}
