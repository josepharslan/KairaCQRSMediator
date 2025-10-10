using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;
using KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _mediator.Send(new GetContactQuery());
            return View(value);
        }
        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _mediator.Send(new RemoveContactCommand(id));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateContact(int id)
        {
            var value = await _mediator.Send(new GetContactByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
