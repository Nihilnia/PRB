using Gone.Database;
using Gone.Models;
using Gone.Models.ViewModelz;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gone.Controllers
{
    public class HomeController : Controller
    {
        private readonly GoneContext _DB;

        public HomeController(GoneContext DB)
        {
            _DB = DB;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginControl(string inputUsername, string inputPass)
        {
            if (!string.IsNullOrEmpty(inputUsername)){
                var getTheUser = _DB.Users.Where(f => f.Username == inputUsername).FirstOrDefault();

                if (getTheUser != null && getTheUser.Password == inputPass)
                {
                    var model = new VMHome()
                    {
                        Username = inputUsername,
                        Password = inputPass
                    };

                    //var model = new List<User>() {
                    //    new User()
                    //    {
                    //        Username = inputUsername,
                    //        Password = inputPass
                    //    }
                    //};
                    return View("~/Views/Home/SuccesfulMFLogin.cshtml", model);
                }
            }
            return View("~/Views/Home/FailedMFLogin.cshtml");
            

        }
    }
}