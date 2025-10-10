using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands
{
    public class CreateSubscriberCommand : IRequest
    {
        public string? Mail { get; set; }
        public DateTime SubscribedTime { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
