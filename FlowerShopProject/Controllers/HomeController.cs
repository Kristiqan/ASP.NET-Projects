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
            return View(this.flowerService.GetFlower());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult WeDeliverTo()
        {
            return View();
        }

        public IActionResult Reviews()
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
            return RedirectToAction("Index");
        }

        public IActionResult GetFlower(int id)
        {
            var flower = this.flowerService.GetById(id);
            return View(flower);
        }

        public IActionResult EditPurchase(Flower flowertoEdit)
        {
            this.flowerService.EditPurchase(flowertoEdit);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePurchase(int id)
        {
            this.flowerService.DeletePurchase(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
