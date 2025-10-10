using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;
using KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers;
using KairaCQRSMediator.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController(CreateBrandCommandHandler _createBrandCommandHandler,
                                 GetBrandByIdQueryHandler _getBrandByIdQueryHandler,
                                 GetBrandQueryHandler _getBrandQueryHandler,
                                 UpdateBrandCommandHandler _updateBrandCommandHandler,
                                 RemoveBrandCommandHandler _removeBrandCommandHandler
                                 ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _getBrandQueryHandler.Handle();
            return View(value);
        }
        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand createBrandCommand)
        {
            await _createBrandCommandHandler.Handle(createBrandCommand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateBrand(int id)
        {
            var value = await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand updateBrandCommand)
        {
            await _updateBrandCommandHandler.Handle(updateBrandCommand);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteBrand(int id)
        {
            await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return RedirectToAction("Index");
        }
    }
}
