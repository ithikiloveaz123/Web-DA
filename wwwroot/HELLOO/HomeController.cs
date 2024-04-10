using Microsoft.AspNetCore.Mvc;

namespace Web_DA.wwwroot.HELLOO
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
