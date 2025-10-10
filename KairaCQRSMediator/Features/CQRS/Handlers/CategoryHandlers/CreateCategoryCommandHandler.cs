using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.CategoryCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler(IRepository<Category> _repository)
    {
        public async Task Handle(CreateCategoryCommand createCategoryCommand)
        {
            var category = new Category
            {
                CategoryName = createCategoryCommand.CategoryName,
                ImageUrl = createCategoryCommand.ImageUrl
            };

            await _repository.CreateAsync(category);
        }
    }
}
