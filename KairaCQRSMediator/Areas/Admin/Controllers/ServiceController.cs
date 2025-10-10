using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;
using KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers;
using KairaCQRSMediator.Features.CQRS.Queries.CategoryQueries;
using KairaCQRSMediator.Features.CQRS.Queries.ServiceQueries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController(GetServiceQueryHandler _getServiceQueryHandler,
                                   CreateServiceCommandHandler _createServiceCommandHandler,
                                   GetServiceByIdQueryHandler _getServiceByIdQueryHandler,
                                   RemoveServiceCommandHandler _removeServiceCommandHandler,
                                   UpdateServiceCommandHandler _updateServiceCommandHandler) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _getServiceQueryHandler.Handle();
            return View(value);
        }
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommand createServiceCommand)
        {
            if (!ModelState.IsValid)
            {
                return View(createServiceCommand);
            }
            await _createServiceCommandHandler.Handle(createServiceCommand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteService(int id)
        {
            await _removeServiceCommandHandler.Handle(new RemoveServiceCommand(id));
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> UpdateService(int id)
        {
            var value = await _getServiceByIdQueryHandler.Handle(new GetServiceByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceCommand updateServiceCommand)
        {
            if (!ModelState.IsValid)
            {
                var value = await _getServiceByIdQueryHandler.Handle(new GetServiceByIdQuery(updateServiceCommand.ServiceId));
                return View(value);
            }
            await _updateServiceCommandHandler.Handle(updateServiceCommand);
            return RedirectToAction("Index");
        }
    }
}
