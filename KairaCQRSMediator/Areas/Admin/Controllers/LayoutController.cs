using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
