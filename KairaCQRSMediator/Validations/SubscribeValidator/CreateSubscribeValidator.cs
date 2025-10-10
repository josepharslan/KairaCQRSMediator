using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands;

namespace KairaCQRSMediator.Validations.SubscribeValidator
{
    public class CreateSubscribeValidator : AbstractValidator<CreateSubscriberCommand>
    {
        public CreateSubscribeValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail değeri boş geçilemez").EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");
        }
    }
}
