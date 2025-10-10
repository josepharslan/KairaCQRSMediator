using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomeLayoutHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
