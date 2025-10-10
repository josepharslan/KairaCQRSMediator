using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Results.CategoryResults;
using KairaCQRSMediator.Features.Mediator.Results.ProductResults;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var categories = await _repository.GetAllAsync();

            return categories.Select(categories => new GetCategoryQueryResult
            {
                CategoryId = categories.CategoryId,
                CategoryName = categories.CategoryName,
                ImageUrl = categories.ImageUrl,
                Products = (IList<GetProductsQueryResult>)categories.Products
            }).ToList();

        }
    }
}
