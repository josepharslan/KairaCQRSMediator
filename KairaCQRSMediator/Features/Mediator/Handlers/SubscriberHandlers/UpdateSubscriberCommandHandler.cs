using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscriberHandlers
{
    public class UpdateSubscriberCommandHandler(IRepository<Subscriber> _repository, IMapper _mapper) : IRequestHandler<UpdateSubscriberCommand>
    {
        public async Task Handle(UpdateSubscriberCommand request, CancellationToken cancellationToken)
        {
            var subscriber = _mapper.Map<Subscriber>(request);
            await _repository.UpdateAsync(subscriber);
        }
    }
}
