using KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Controllers
{
    public class HomePageController(IMediator _mediator) : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
        public async Task<IActionResult> Subscribe(CreateSubscriberCommand createSubscriberCommand)
        {
            if (!ModelState.IsValid)
            {
                return View("HomePage", createSubscriberCommand);
            }
            await _mediator.Send(createSubscriberCommand);
            return RedirectToAction(nameof(HomePage));
        }
    }
}
