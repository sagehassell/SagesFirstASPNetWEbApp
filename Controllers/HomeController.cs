using Microsoft.AspNetCore.Mvc;
using SagesFirstASPNetWEbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SagesFirstASPNetWEbApp.Controllers
{
    public class HomeController : Controller //inherits from the controller class
    {
        public IActionResult Index() //the index method
        {

            return View();
        }

        [HttpGet("CalcGrade")]
        public IActionResult CalcGrade()
        {
            return View();
        }

        [HttpPost("CalcGrade")]
        public IActionResult CalcGrade(CalcGradeModel model)
        {
            return View();
        }
    }
}
