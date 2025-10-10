using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler(IRepository<Service> _repository)
    {
        public async Task Handle(CreateServiceCommand createServiceCommand)
        {
            var service = new Service
            {
                Icon = createServiceCommand.Icon,
                Title = createServiceCommand.Title,
                Description = createServiceCommand.Description
            };

            await _repository.CreateAsync(service);
        }
    }
}
