using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.ViewComponents
{
    public class AdminLayoutScript : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
