using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class UpdateContactCommandHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<UpdateContactCommand>
    {
        public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(_mapper.Map<ContactInfo>(request));
        }
    }
}
