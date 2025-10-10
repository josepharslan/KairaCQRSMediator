using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscriberHandlers
{
    public class CreateSubscriberCommandHandler(IRepository<Subscriber> _repository, IMapper _mapper) : IRequestHandler<CreateSubscriberCommand>
    {
        public async Task Handle(CreateSubscriberCommand request, CancellationToken cancellationToken)
        {
            request.IsSubscribed = true;
            request.SubscribedTime = DateTime.UtcNow;
            var subscriber = _mapper.Map<Subscriber>(request);
            await _repository.CreateAsync(subscriber);
        }
    }
}
