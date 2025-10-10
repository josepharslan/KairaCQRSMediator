using FluentValidation;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;

namespace KairaCQRSMediator.Validations.BrandValidator
{
    public class CreateBrandValidator : AbstractValidator<CreateBrandCommand>
    {
        public CreateBrandValidator()
        {
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel linki boş geçilemez");
        }
    }
}
