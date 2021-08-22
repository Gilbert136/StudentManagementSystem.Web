using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystemFrontEnd.Controllers
{
    public class SubjectController : Controller
    {
        [Route("/Dashboard/Subject")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Dashboard/Subject/{id}")]
        public IActionResult Subject(string id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
