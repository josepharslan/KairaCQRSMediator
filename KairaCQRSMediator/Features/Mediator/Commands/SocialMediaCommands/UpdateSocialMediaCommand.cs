using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands
{
    public class UpdateSocialMediaCommand : IRequest
    {
        public int SocialMediaId { get; set; }
        public string? Icon { get; set; }
        public string? Link { get; set; }
    }
}
