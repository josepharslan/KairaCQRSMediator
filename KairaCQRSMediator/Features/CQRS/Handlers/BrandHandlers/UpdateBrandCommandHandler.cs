using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler(IRepository<Brand> _repository)
    {
        public async Task Handle(UpdateBrandCommand updateBrandCommand)
        {
            await _repository.UpdateAsync(new Brand
            {
                BrandId = updateBrandCommand.BrandId,
                ImageUrl = updateBrandCommand.ImageUrl
            });
        }
    }
}
