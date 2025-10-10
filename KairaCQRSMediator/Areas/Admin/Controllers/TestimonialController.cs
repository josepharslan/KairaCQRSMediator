using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;
using KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers;
using KairaCQRSMediator.Features.CQRS.Queries.TestimonialQueries;
using KairaCQRSMediator.Features.CQRS.Results.TestimonialResults;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController(GetTestimonialQueryHandler _getTestimonialQueryHandler,
                                       CreateTestimonialCommandHandler _createTestimonialCommandHandler,
                                       UpdateTestimonialCommandHandler _updateTestimonialCommandHandler,
                                       GetTestimonialByIdQueryHandler _getTestimonialByIdQueryHandler,
                                       RemoveTestimonialCommandHandler _removeTestimonialCommandHandler) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _getTestimonialQueryHandler.Handle();
            return View(value);
        }
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand createTestimonialCommand)
        {
            if (!ModelState.IsValid)
            {
                return View(createTestimonialCommand);
            }
            await _createTestimonialCommandHandler.Handle(createTestimonialCommand);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var value = await _getTestimonialByIdQueryHandler.Handle(new GetTestimonialByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand updateTestimonialCommand)
        {
            if (!ModelState.IsValid)
            {
                var value = await _getTestimonialByIdQueryHandler.Handle(new GetTestimonialByIdQuery(updateTestimonialCommand.TestimonialId));
                return View(value);
            }
            await _updateTestimonialCommandHandler.Handle(updateTestimonialCommand);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _removeTestimonialCommandHandler.Handle(new RemoveTestimonialCommand(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
