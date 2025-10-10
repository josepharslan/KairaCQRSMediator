using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Results.BrandResults;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler(IRepository<Brand> _repository)
    {
        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var brands = await _repository.GetAllAsync();

            return brands.Select(brands => new GetBrandQueryResult
            {
                BrandId = brands.BrandId,
                ImageUrl = brands.ImageUrl
            }).ToList();
        }
    }
}
