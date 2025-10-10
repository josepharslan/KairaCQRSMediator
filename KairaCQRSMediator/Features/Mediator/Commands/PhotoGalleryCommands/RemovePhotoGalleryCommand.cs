using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.PhotoGalleryCommands
{
    public class RemovePhotoGalleryCommand(int id) : IRequest
    {
        public int Id { get; set; } = id;
    }
}
