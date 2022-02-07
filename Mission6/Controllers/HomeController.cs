using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext coolContext { get; set; }
        public HomeController(TaskContext theData)
        {
            coolContext = theData;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AllTask()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTask(TheTask ar)
        {
            coolContext.Add(ar);
            coolContext.SaveChanges();

            return View("ConfirmationPage");
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult EditTask()
        {
            return View();
        }
    }
}
