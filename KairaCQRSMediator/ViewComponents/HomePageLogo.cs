using KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomePageLogo(GetBrandQueryHandler _getBrandQueryHandler) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _getBrandQueryHandler.Handle();
            return View(value);
        }
    }
}
