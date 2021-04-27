using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition.Controllers
{
    public class VoterSearch : Controller
    {
        public IActionResult Votersearch()
        {
            return View();
        }
    }
}
