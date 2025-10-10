using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler(IRepository<Service> _repository)
    {
        public async Task Handle(UpdateServiceCommand _updateServiceCommand)
        {
            await _repository.UpdateAsync(new Service
            {
                ServiceId = _updateServiceCommand.ServiceId,
                Icon = _updateServiceCommand.Icon,
                Title = _updateServiceCommand.Title,
                Description = _updateServiceCommand.Description
            });
        }
    }
}
