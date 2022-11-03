using Microsoft.AspNetCore.Mvc;
using PetFinder.Models;
using System.Diagnostics;

namespace PetFinder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UserModel user = new UserModel();
            user.Nome = "Hugo Leonardo";
            user.Email = "teste@gmail.com";
            return View(user);
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