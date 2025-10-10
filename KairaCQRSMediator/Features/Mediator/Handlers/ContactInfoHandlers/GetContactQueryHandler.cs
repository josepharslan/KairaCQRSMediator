using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries;
using KairaCQRSMediator.Features.Mediator.Results.ContactInfoResults;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class GetContactQueryHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<GetContactQuery, List<GetContactQueryResult>>
    {
        public async Task<List<GetContactQueryResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return _mapper.Map<List<GetContactQueryResult>>(value);
        }
    }
}
