using FluentValidation;
using KairaCQRSMediator.Features.Mediator.Commands.PhotoGalleryCommands;

namespace KairaCQRSMediator.Validations.PhotoGalleryValidators
{
    public class UpdatePhotoGalleryValidator : AbstractValidator<UpdatePhotoGalleryCommand>
    {
        public UpdatePhotoGalleryValidator()
        {
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel boş geçilemez.");
        }
    }
}
