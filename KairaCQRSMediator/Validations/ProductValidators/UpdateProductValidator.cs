using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.ProductCommands;

namespace KairaCQRSMediator.Validations.ProductValidators
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez.")
                           .MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır.")
                           .MaximumLength(50).WithMessage("Ürün adı en fazla 50 karakter olmalıdır.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez.")
                                 .InclusiveBetween(10, 10000).WithMessage("Ürün fiyatı 10 ile 10000 arasında olmalıdır.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Ürün görseli boş geçilemez.");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Ürün kategorisi boş geçilemez.");
        }
    }
}
