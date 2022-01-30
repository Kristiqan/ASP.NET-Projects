using DataSkeleton.Models;
using DataSkeleton.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataSkeleton.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataService dataService;

        public HomeController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        public IActionResult Index()
        {
            return View(this.dataService.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
