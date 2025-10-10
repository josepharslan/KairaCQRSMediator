using FluentValidation;
using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;

namespace KairaCQRSMediator.Validations.ServiceValidators
{
    public class UpdateServiceValidator : AbstractValidator<UpdateServiceCommand>
    {
        public UpdateServiceValidator()
        {
            RuleFor(x => x.Icon).NotEmpty().WithMessage("İkon değeri boş geçilemez.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık değeri boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama değeri boş geçilemez.").MaximumLength(50).WithMessage("Açıklama değeri en fazla 50 karakter olabilir.");
        }
    }
}
