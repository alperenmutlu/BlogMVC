using Microsoft.AspNetCore.Mvc;

namespace BlogMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
