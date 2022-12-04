using Gri.Database;
using Gri.Models.ViewModelz;
using Microsoft.AspNetCore.Mvc;

namespace Gri.Controllers
{
    public class LoginController : Controller
    {
        private readonly GriContext DB;

        public LoginController(GriContext _DB)
        {
            DB = _DB;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Control(string userName, string passWord)
        {
            var model = new VMLogin();
            

            var findUser = DB.Users.Where(f => f.Username == userName).FirstOrDefault();

            if (findUser != null && findUser.Password == passWord)
            {
                model.Password = passWord;
                model.Username = userName;
				return View("~/Views/Home/welcomeMF.cshtml", model);
			}

			return View("~/Views/Home/wrongMF.cshtml", model);
        }
    }
}