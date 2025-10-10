using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Results.ServiceResults;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle()
        {
            var services = await _repository.GetAllAsync();

            return services.Select(service => new GetServiceQueryResult
            {
                ServiceId = service.ServiceId,
                Icon = service.Icon,
                Title = service.Title,
                Description = service.Description
            }).ToList();
        }
    }
}
