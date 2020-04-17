using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_web.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        public static List<ShopItem> InitializeList()
        {
            List<ShopItem> itemsList = new List<ShopItem>()
            {
                new ShopItem("Running shoes", "Nike running shoes for everyday use", 1500, 5 ),
                new ShopItem("Printer", "HP printer that will print pages", 3000, 0),
                new ShopItem("Coca cola", "0.5 l bottle", 25, 2),
                new ShopItem("Wokin", "Chicken with fried rice", 119, 100),
                new ShopItem("T-shirt", "Blue with a corgy on a bike", 300, 1),
            };
            return itemsList;
        }
        public static List<ShopItem> itemsList = null;
        public HomeController()
        {
            if (itemsList == null)
            {
                itemsList = InitializeList();
            }
        }

        [HttpGet("Webshop")]
        public IActionResult Webshop()
        {
            return View("Index", itemsList);
        }

        [HttpGet("Available")]
        public IActionResult Available()
        {
            List<ShopItem> customizedList = itemsList.Where(p => p.QuantityOfStock > 0).ToList();
            return View("Index", customizedList);
        }

        [HttpGet("Cheapest")]
        public IActionResult Cheapest()
        {
            List<ShopItem> customizedList = itemsList.OrderBy(p => p.Price).ToList();
            return View("Index", customizedList);
        }

        [HttpGet("Nike")]
        public IActionResult Nike()
        {
            List<ShopItem> customizedList = itemsList.Where(p => p.Name.ToLower().Contains("nike ") || p.Description.ToLower().Contains("nike ")).ToList();
            return View("Index", customizedList);
        }
        [HttpGet("Expensive")]
        public IActionResult Expensive()
        {
            ShopItem mostExpensive = itemsList.OrderByDescending(p => p.Price).First();
            List<ShopItem> customizedList = new List<ShopItem>() { mostExpensive };
            return View("Index", customizedList);
        }
        [HttpGet("Average")]
        public IActionResult Average()
        {
            string average = Convert.ToInt32(itemsList.Average(p => p.QuantityOfStock)).ToString() + " pieces";
            ViewBag.Average = average;
            return View("Index");
        }
    }
}