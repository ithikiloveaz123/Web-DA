using Microsoft.AspNetCore.Mvc;

namespace Web_DA.Controllers
{
    public class WiTiNiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
