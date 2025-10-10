using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.PhotoGalleryCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.PhotoGalleryHandlers
{
    public class CreatePhotoGalleryCommandHandler(IRepository<PhotoGallery> _repository, IMapper _mapper) : IRequestHandler<CreatePhotoGalleryCommand>
    {
        public async Task Handle(CreatePhotoGalleryCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(_mapper.Map<PhotoGallery>(request));
        }
    }
}
