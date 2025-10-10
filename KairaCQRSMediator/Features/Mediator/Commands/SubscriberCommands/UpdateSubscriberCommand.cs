using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands
{
    public class UpdateSubscriberCommand : IRequest
    {
        public int SubscriberId { get; set; }
        public string? Mail { get; set; }
        public DateTime SubscribedTime { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
