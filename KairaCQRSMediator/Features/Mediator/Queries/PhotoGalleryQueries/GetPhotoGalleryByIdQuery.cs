using KairaCQRSMediator.Features.Mediator.Results.PhotoGalleryResults;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Queries.PhotoGalleryQueries
{
    public class GetPhotoGalleryByIdQuery(int id) : IRequest<GetPhotoGalleryByIdQueryResult>
    {
        public int Id { get; } = id;
    }
}
