using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Queries.BrandQueries;
using KairaCQRSMediator.Features.CQRS.Results.BrandResults;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler(IRepository<Brand> _repository)
    {
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery getBrandByIdQuery)
        {
            var value = await _repository.GetByIdAsync(getBrandByIdQuery.Id);
            return new GetBrandByIdQueryResult
            {
                BrandId = value.BrandId,
                ImageUrl = value.ImageUrl
            };
        }
    }
}
