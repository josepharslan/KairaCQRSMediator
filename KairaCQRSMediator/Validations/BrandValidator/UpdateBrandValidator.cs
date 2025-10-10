using FluentValidation;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;

namespace KairaCQRSMediator.Validations.BrandValidator
{
    public class UpdateBrandValidator : AbstractValidator<UpdateBrandCommand>
    {
        public UpdateBrandValidator()
        {
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel linki boş geçilemez");
        }

    }
}
