using KairaCQRSMediator.Features.Mediator.Results.SubscriberResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.SubscriberQueries
{
    public class GetSubscriberByIdQuery(int id) : IRequest<GetSubscriberByIdQueryResult>
    {
        public int Id { get; } = id;
    }
}
