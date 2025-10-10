using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;

namespace KairaCQRSMediator.Validations.ContactInfoValidators
{
    public class CreateContactValidator : AbstractValidator<CreateContactCommand>
    {
        public CreateContactValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numarası boş geçilemez.");
        }
    }
}
