using AutoMapper;
using KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands;
using KairaCQRSMediator.Features.Mediator.Queries.SubscriberQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscriberController(IMediator _mediator, IMapper _mapper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _mediator.Send(new GetSubscribersQuery());
            return View(value);
        }

        public async Task<IActionResult> Unsubscribe(int id, CancellationToken ct)
        {
            await _mediator.Send(new UnsubscribeSubscriberCommand(id), ct);
            TempData["Success"] = "Abonelik iptal edildi.";
            return RedirectToAction(nameof(Index));
        }

    }
}
