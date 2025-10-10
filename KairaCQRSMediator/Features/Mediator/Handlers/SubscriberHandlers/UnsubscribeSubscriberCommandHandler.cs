using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscriberHandlers
{
    public class UnsubscribeSubscriberCommandHandler : IRequestHandler<UnsubscribeSubscriberCommand>
    {
        private readonly IRepository<Subscriber> _repo;
        public UnsubscribeSubscriberCommandHandler(IRepository<Subscriber> repo)
        {
            _repo = repo;
        }

        public async Task Handle(UnsubscribeSubscriberCommand request, CancellationToken cancellationToken)
        {
            var s = await _repo.GetByIdAsync(request.Id);
            if (s is null) throw new KeyNotFoundException("Abone bulunamadı.");

            s.IsSubscribed = false;
            await _repo.UpdateAsync(s);
        }
    }
}
