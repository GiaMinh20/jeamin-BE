using Microsoft.AspNetCore.Mvc;

namespace jeamin.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
