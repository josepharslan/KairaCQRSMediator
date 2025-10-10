using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.PhotoGalleryCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.PhotoGalleryHandlers
{
    public class UpdatePhotoGalleryCommandHandler(IRepository<PhotoGallery> _repository, IMapper _mapper) : IRequestHandler<UpdatePhotoGalleryCommand>
    {
        public async Task Handle(UpdatePhotoGalleryCommand request, CancellationToken cancellationToken)
        {
            var photoGallery = _mapper.Map<PhotoGallery>(request);
            await _repository.UpdateAsync(photoGallery);
        }
    }
}
