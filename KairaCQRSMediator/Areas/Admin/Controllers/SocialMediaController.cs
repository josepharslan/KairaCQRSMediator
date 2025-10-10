using KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands;
using KairaCQRSMediator.Features.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _mediator.Send(new GetSocialMediaQuery());
            return View(value);
        }
        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand createSocialMediaCommand)
        {
            if (!ModelState.IsValid)
            {
                return View(createSocialMediaCommand);
            }
            await _mediator.Send(createSocialMediaCommand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateSocialMedia(int id)
        {
            var value = await _mediator.Send(new GetSocialMediaByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand updateSocialMediaCommand)
        {
            if (!ModelState.IsValid)
            {
                return View(updateSocialMediaCommand);
            }
            await _mediator.Send(updateSocialMediaCommand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            await _mediator.Send(new RemoveSocialMediaCommand(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
