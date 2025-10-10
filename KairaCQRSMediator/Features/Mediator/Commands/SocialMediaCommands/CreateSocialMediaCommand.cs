using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands
{
    public class CreateSocialMediaCommand : IRequest
    {
        public string? Icon { get; set; }
        public string? Link { get; set; }
    }
}
