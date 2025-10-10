using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.PhotoGalleryCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.PhotoGalleryHandlers
{
    public class RemovePhotoGalleryCommandHandler(IRepository<PhotoGallery> _repository, IMapper _mapper) : IRequestHandler<RemovePhotoGalleryCommand>
    {
        public async Task Handle(RemovePhotoGalleryCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
