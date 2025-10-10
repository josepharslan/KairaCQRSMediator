using KairaCQRSMediator.Features.Mediator.Results.ContactInfoResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries
{
    public class GetContactByIdQuery(int id) : IRequest<GetContactByIdQueryResult>
    {
        public int Id { get; } = id;
    }
}
