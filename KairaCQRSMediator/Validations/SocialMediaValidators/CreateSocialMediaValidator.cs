using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands;

namespace KairaCQRSMediator.Validations.SocialMediaValidators
{
    public class CreateSocialMediaValidator : AbstractValidator<CreateSocialMediaCommand>
    {
        public CreateSocialMediaValidator()
        {
            RuleFor(x => x.Icon).NotEmpty().WithMessage("İkon boş geçilemez");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Sosyal medya linki boş geçilemez");
        }
    }
}
