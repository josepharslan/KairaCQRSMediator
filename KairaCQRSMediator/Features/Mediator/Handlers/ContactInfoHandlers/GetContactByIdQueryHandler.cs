using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries;
using KairaCQRSMediator.Features.Mediator.Results.ContactInfoResults;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class GetContactByIdQueryHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<GetContactByIdQuery, GetContactByIdQueryResult>
    {
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetContactByIdQueryResult>(value);
        }
    }
}
