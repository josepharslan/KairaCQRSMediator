using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.PhotoGalleryQueries;
using KairaCQRSMediator.Features.Mediator.Results.PhotoGalleryResults;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.PhotoGalleryHandlers
{
    public class GetPhotoGalleryByIdQueryHandler(IRepository<PhotoGallery> _repository, IMapper _mapper) : IRequestHandler<GetPhotoGalleryByIdQuery, GetPhotoGalleryByIdQueryResult>
    {
        public async Task<GetPhotoGalleryByIdQueryResult> Handle(GetPhotoGalleryByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetPhotoGalleryByIdQueryResult>(value);
        }
    }
}
