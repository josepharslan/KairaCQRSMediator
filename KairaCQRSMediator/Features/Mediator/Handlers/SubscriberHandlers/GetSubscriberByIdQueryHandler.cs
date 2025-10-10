using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.SubscriberQueries;
using KairaCQRSMediator.Features.Mediator.Results.SubscriberResults;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscriberHandlers
{
    public class GetSubscriberByIdQueryHandler(IRepository<Subscriber> _repository, IMapper _mapper) : IRequestHandler<GetSubscriberByIdQuery, GetSubscriberByIdQueryResult>
    {
        public async Task<GetSubscriberByIdQueryResult> Handle(GetSubscriberByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetSubscriberByIdQueryResult>(value);
        }
    }
}
