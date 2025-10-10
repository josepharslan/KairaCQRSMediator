using KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomePageTestimonial(GetTestimonialQueryHandler _getTestimonialQueryHandler) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _getTestimonialQueryHandler.Handle();
            return View(value);
        }
    }
}
