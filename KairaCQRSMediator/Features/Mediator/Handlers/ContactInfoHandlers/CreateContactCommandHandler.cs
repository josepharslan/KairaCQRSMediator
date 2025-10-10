using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class CreateContactCommandHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<CreateContactCommand>
    {
        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(_mapper.Map<ContactInfo>(request));
        }
    }
}
