using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Queries.ServiceQueries;
using KairaCQRSMediator.Features.CQRS.Results.ServiceResults;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler(IRepository<Service> _repository)
    {
        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery getServiceById)
        {
            var value = await _repository.GetByIdAsync(getServiceById.Id);

            return new GetServiceByIdQueryResult
            {
                ServiceId = getServiceById.Id,
                Icon = value.Icon,
                Title = value.Title,
                Description = value.Description
            };
        }
    }
}
