using KairaCQRSMediator.Features.Mediator.Commands.PhotoGalleryCommands;
using KairaCQRSMediator.Features.Mediator.Queries.PhotoGalleryQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhotoGalleryController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _mediator.Send(new GetPhotoGalleriesQuery());
            return View(value);
        }

        public IActionResult CreatePhotoGallery()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePhotoGallery(CreatePhotoGalleryCommand createPhotoGalleryCommand)
        {
            await _mediator.Send(createPhotoGalleryCommand);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdatePhotoGallery(int id)
        {
            var value = await _mediator.Send(new GetPhotoGalleryByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePhotoGallery(UpdatePhotoGalleryCommand updatePhotoGalleryCommand)
        {
            await _mediator.Send(updatePhotoGalleryCommand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeletePhotoGallery(int id)
        {
            await _mediator.Send(new RemovePhotoGalleryCommand(id));
            return RedirectToAction("Index");
        }
    }
}
