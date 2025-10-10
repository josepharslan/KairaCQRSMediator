using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.PhotoGalleryQueries;
using KairaCQRSMediator.Features.Mediator.Results.PhotoGalleryResults;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.PhotoGalleryHandlers
{
    public class GetPhotoGalleriesQueryHandler(IRepository<PhotoGallery> _repository, IMapper _mapper) : IRequestHandler<GetPhotoGalleriesQuery, List<GetPhotoGalleriesQueryResult>>
    {
        public async Task<List<GetPhotoGalleriesQueryResult>> Handle(GetPhotoGalleriesQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return _mapper.Map<List<GetPhotoGalleriesQueryResult>>(value);
        }
    }
}
