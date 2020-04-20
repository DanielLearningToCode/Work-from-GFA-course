using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank_of_Simba.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace Bank_of_Simba.Controllers
{   //[Route("Home")]
    public class HomeController : Controller
    {
        public static List<BankAccount> accountList = null;
        public static void InitializeList()
        {
            accountList = new List<BankAccount>()
            {
                new BankAccount("Zazu", 500, "bird", false),
                new BankAccount("Scar", 10000, "lion", false),
                new BankAccount("Timon", 800, "meerkat", false),
                new BankAccount("Rafiky", 5000, "baboon", false),
                new BankAccount("Simba", 2000, "lion", true),
            };
        }
        public HomeController()
        {
            if (accountList ==null)
            {
                InitializeList();
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
            return View("index" );
        }

        public IActionResult Html()
        {
            string message = "This is an<em> HTML </ em > text. < b > Enjoy yourself! </ b > ";
            ViewBag.Message = message;
            return View("index");
        }
        public IActionResult ListAllAccounts()
        {
            return View(accountList);
        }
    }
}


///In your controller create the first endpoint called /show
/*Instantiate a new BankAccount("Simba", 2000, "lion")
Java: Add this BankAccount to the model
C#: Add this BankAccount to the View
Create a template where you show the fields of the BankAccount*/
/*public static List<BankAccount> InitializeList()
{
    List<BankAccount> accountList = new List<BankAccount>();
        public BankAccount simba = new BankAccount("Simba", 2000, "lion");
public BankAccount zazu = new BankAccount("Zazu", 500, "bird");
public BankAccount scar = new BankAccount("Scar", 10000, "lion");
public BankAccount timon = new BankAccount("Timon", 800, "meerkat");
public BankAccount rafiky = new BankAccount("Rafiky", 5000, "baboon");
            return 
        }*/