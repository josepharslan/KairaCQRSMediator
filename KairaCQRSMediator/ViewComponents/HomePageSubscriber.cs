using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomePageSubscriber : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
