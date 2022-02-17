using FlowerShopProject.Data;
using FlowerShopProject.Models;
using FlowerShopProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShopProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFlowerService flowerService;

        public HomeController(IFlowerService flowerService)
        {
            this.flowerService = flowerService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFlower()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SavePurchase(Flower flower)
        {
            this.flowerService.AddFlower(flower);
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
