using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler(IRepository<Brand> _repository)
    {
        public async Task Handle(CreateBrandCommand command)
        {
            var value = new Brand
            {
                ImageUrl = command.ImageUrl
            };
            await _repository.CreateAsync(value);
        }
    }
}
