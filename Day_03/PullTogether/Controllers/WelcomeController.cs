using Microsoft.AspNetCore.Mvc;

namespace PullTogether.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginRegister()
        {
            return View();
        }


        

    }
}
