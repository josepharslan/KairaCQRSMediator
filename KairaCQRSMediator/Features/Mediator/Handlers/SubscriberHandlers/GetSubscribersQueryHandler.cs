using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Results.ServiceResults;
using KairaCQRSMediator.Features.Mediator.Queries.SubscriberQueries;
using KairaCQRSMediator.Features.Mediator.Results.SubscriberResults;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SubscriberHandlers
{
    public class GetSubscribersQueryHandler(IRepository<Subscriber> _repository, IMapper _mapper) : IRequestHandler<GetSubscribersQuery, List<GetSubscribersQueryResult>>
    {
        public async Task<List<GetSubscribersQueryResult>> Handle(GetSubscribersQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return _mapper.Map<List<GetSubscribersQueryResult>>(value);
        }
    }
}
