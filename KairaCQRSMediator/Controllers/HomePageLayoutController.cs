using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Controllers
{
    public class HomePageLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
