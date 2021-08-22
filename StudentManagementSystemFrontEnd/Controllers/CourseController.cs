using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystemFrontEnd.Controllers
{
    public class CourseController : Controller
    {
        [Route("/Dashboard/Course")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Dashboard/Course/{id}")]
        public IActionResult Course(string id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
