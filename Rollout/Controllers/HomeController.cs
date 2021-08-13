using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rollout.Data.EntityModels;
using Rollout.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rollout.Data;

namespace Rollout.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       private readonly RolloutDbContext _context;
        //public HomeController(RolloutDbContext context)
        //{
         //   _context = context;
        //}
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult TEST()
        {

            return View();
        }
        public IActionResult ProjectManager()
        {
            return View("~/Views/Projectmanager/ProjectManager.cshtml");
        }
        public IActionResult Project()
        {
            
            return View("~/Views/Projectmanager/Project.cshtml");
        }
        public IActionResult AddWorkstation()
        {


            return View("~/Views/Projectmanager/AddWorkstation.cshtml");
        }
   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> create([Bind("WorkStationId,Serialnumber,EmissionsReport,Ticketnumber")] WorkStations workStations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workStations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workStations);
        }


    }
}
