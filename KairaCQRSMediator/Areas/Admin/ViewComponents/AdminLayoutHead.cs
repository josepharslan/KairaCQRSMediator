using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.ViewComponents
{
    public class AdminLayoutHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
