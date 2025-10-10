using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands;

namespace KairaCQRSMediator.Validations.SocialMediaValidators
{
    public class UpdateSocialMediaValidator : AbstractValidator<UpdateSocialMediaCommand>
    {
        public UpdateSocialMediaValidator()
        {
            RuleFor(x => x.Icon).NotEmpty().WithMessage("İkon boş geçilemez");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Sosyal medya linki boş geçilemez");
        }
    }
}
