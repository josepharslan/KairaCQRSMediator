using KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers;
using KairaCQRSMediator.Features.Mediator.Queries.PhotoGalleryQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomePagePhotoGallery(IMediator _mediator) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _mediator.Send(new GetPhotoGalleriesQuery());
            return View(value);
        }
    }
}
