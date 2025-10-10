using KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KairaCQRSMediator.ViewComponents
{
    public class HomePageService(GetServiceQueryHandler _getServiceQueryHandler) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _getServiceQueryHandler.Handle();
            return View(value);
        }
    }
}
