using KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomePageCategory(GetCategoryQueryHandler getCategoryQueryHandler) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await getCategoryQueryHandler.Handle();
            return View(value);
        }
    }
}
