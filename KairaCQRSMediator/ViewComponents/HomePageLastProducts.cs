using KairaCQRSMediator.Features.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomePageLastProducts(IMediator _mediator) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _mediator.Send(new GetProductsQuery());
            return View(value.TakeLast(5));
        }
    }
}
