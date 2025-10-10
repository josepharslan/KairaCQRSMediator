using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class RemoveContactCommandHandler(IRepository<ContactInfo> _repository) : IRequestHandler<RemoveContactCommand>
    {
        public async Task Handle(RemoveContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
