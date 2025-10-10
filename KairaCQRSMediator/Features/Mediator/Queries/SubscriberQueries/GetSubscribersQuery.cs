using KairaCQRSMediator.Features.Mediator.Results.SubscriberResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.SubscriberQueries
{
    public class GetSubscribersQuery : IRequest<List<GetSubscribersQueryResult>>
    {
    }
}
