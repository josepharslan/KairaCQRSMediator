using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.PhotoGalleryCommands;

namespace KairaCQRSMediator.Validations.PhotoGalleryValidators
{
    public class CreatePhotoGalleryValidator : AbstractValidator<CreatePhotoGalleryCommand>
    {
        public CreatePhotoGalleryValidator()
        {
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel boş geçilemez.");
        }
    }
}
