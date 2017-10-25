using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebServices.Models;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WebServices.Controllers
{
    public class HomeController : Controller
    {
        //UserTableContext dbUser = new UserTableContext();
        //TableOfStatementsContext dbStatement = new TableOfStatementsContext();

        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static int AcountNumber { get; set; }
        public static string Email { get; set; }
        public static DateTime DOB { get; set; }
        public static string GroupName { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //отображение страницы
        public IActionResult Register()
        {
            return View();
        }

        //метод для создания новоого юзера.то есть должно быть добавелние в бд
        [HttpPost]
        public IActionResult NewUser(string lastName, string firstName, DateTime dob, string password, string accountNumber,string group,string email)
        {
            if (lastName != null)
                return View( "LastName=" + lastName);
            else return View("null");
        }

        [HttpPost]
        public IActionResult NewUser0(string lastName, string firstName, DateTime dob, string password, string accountNumber, string group, string email)
        {

            return View(LastName);
        }
    }
}
