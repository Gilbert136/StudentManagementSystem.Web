using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystemFrontEnd.Controllers
{
    public class StudentController : Controller
    {
        [Route("/Dashboard/Student")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Dashboard/Student/{id}")]
        public IActionResult Student(string id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
