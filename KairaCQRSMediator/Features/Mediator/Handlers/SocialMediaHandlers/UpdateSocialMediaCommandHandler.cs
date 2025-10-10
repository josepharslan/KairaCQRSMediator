using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class UpdateSocialMediaCommandHandler(IRepository<SocialMedia> _repository, IMapper _mapper) : IRequestHandler<UpdateSocialMediaCommand>
    {
        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(_mapper.Map<SocialMedia>(request));
        }
    }
}
