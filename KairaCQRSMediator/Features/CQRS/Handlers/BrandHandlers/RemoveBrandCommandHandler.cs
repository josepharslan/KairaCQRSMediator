using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler(IRepository<Brand> _repository)
    {
        public async Task Handle(RemoveBrandCommand removeBrandCommand)
        {
            await _repository.DeleteAsync(removeBrandCommand.Id);
        }
    }
}
