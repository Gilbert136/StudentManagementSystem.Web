using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystemFrontEnd.Controllers
{
    public class AdministratorController : Controller
    {
        [Route("/Dashboard/Administrator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
