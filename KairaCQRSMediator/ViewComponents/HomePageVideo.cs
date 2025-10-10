using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomePageVideo : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
