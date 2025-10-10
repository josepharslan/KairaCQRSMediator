using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.PhotoGalleryCommands
{
    public class CreatePhotoGalleryCommand : IRequest
    {
        public string? ImageUrl { get; set; }
    }
}
