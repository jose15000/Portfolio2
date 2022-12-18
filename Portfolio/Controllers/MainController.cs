using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
