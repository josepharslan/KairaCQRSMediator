using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Queries.SocialMediaQueries;
using KairaCQRSMediator.Features.Mediator.Results.SocialMediaResults;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaQueryHandler(IRepository<SocialMedia> _repository, IMapper _mapper) : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return _mapper.Map<List<GetSocialMediaQueryResult>>(value);
        }
    }
}
