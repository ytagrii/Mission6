using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult AddTask()
        {
            ViewBag.Categories = coolContext.categories.ToList();
            ViewBag.Quadrants = coolContext.quadrant.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddTask(TheTask TT)
        {
            coolContext.Add(TT);
            coolContext.SaveChanges();

            return View("Confirmation");
        }

        [HttpGet]
        public IActionResult AllTask()
        {
            var coolData = coolContext.task
                .Include( y => y.Category)
                .Include(y => y.Quadrant)
                .Where(x => x.Completed == false)
                .ToList();
            return View(coolData);
        }

        [HttpGet]
        public IActionResult EditTask(int id)
        {
            ViewBag.Categories = coolContext.categories.ToList();
            ViewBag.Quadrants = coolContext.quadrant.ToList();

            var taskie = coolContext.task.Single(y => y.TaskId == id);

            return View(taskie);
        }

        [HttpPost]
        public IActionResult EditTask(TheTask TT)
        {
            coolContext.Update(TT);
            coolContext.SaveChanges();

            return RedirectToAction("AllTask");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var taskie = coolContext.task.Single(y => y.TaskId == id);
            return View(taskie);
        }

        [HttpPost]
        public IActionResult Delete(TheTask TT)
        {
            coolContext.task.Remove(TT);
            coolContext.SaveChanges();

            return RedirectToAction("AllTask");
        }

        [HttpGet]
        public IActionResult Completed(int id)
        {
            coolContext.task.Single(y => y.TaskId == id).Completed = true;
            coolContext.SaveChanges();
            return RedirectToAction("AllTask");
        }
    }
}
