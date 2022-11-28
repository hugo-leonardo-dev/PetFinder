using Microsoft.AspNetCore.Mvc;

namespace PetFinder.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
