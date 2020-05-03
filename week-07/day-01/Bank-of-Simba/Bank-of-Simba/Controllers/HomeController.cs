using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bank_of_Simba.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
namespace Bank_of_Simba.Controllers
{   [Route("Home")]
    public class HomeController : Controller
    {
        public static List<BankAccount> accountList = null;
        public static void InitializeList()
        {
            accountList = new List<BankAccount>()
            {
                new BankAccount("Zazu", 500, "bird", false, Characters.Good_guy),
                new BankAccount("Scar", 10000, "lion", false, Characters.Bad_guy),
                new BankAccount("Timon", 800, "meerkat", false, Characters.Good_guy),
                new BankAccount("Rafiky", 5000, "baboon", false, Characters.Good_guy),
                new BankAccount("Simba", 2000, "lion", true, Characters.Good_guy),
            };
        }
        public HomeController()
        {
            if (accountList == null)
            {
                InitializeList();
            }
        }
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("show")]
        public IActionResult Show()
        {
            return View("index");
        }
        [HttpGet("html")]
        public IActionResult Html()
        {
            string message = "This is an<em> HTML </ em > text. < b > Enjoy yourself! </ b > ";
            ViewBag.Message = message;
            return View("index");
        }
        [HttpGet("all")]
        public IActionResult ListAllAccounts()
        {
            return View(accountList);
        }

        [HttpPost("ModifyAccounts")]
        public IActionResult ModifyAccounts(int[] id)
        {
            foreach (var accountId in id)
            {
                if (accountList[accountId -1].King)
                {
                    accountList[accountId -1].Balance += 100;
                }
                else
                {
                    accountList[accountId - 1].Balance += 10;
                }
            }
            return RedirectToAction("ListAllAccounts");

        }
        [HttpPost("CreateAccount")]
        public IActionResult CreateAccount(string name, decimal balance, string animalType, string isKing, string isBadGuy)
        {
            if (name != null && animalType != null && isKing != null && isBadGuy != null)
            {
                bool king = isKing == "y" ? true : false;
                Characters character = isBadGuy == "y" ? Characters.Bad_guy : Characters.Good_guy;
                BankAccount newAccount = new BankAccount() { Name = name, Balance = balance, AnimalType = animalType, King = king, Character = character };
                accountList.Add(newAccount);
            }
            return RedirectToAction("ListAllAccounts");
        }
        [HttpPost("check")]
        public IActionResult Test(int[] id)
        {
            return RedirectToAction("Index");
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
