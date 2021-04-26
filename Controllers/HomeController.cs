using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurveyModel.Models;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(Survey newUser)
        {

            if (ModelState.IsValid)
            {
                return View("Result", newUser);
            }
            else
            {
                return View("Index");
            }
        }
    }
}