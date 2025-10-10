using KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomePageContactUs(IMediator _mediator) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _mediator.Send(new GetContactQuery());
            return View(value);
        }
    }
}
