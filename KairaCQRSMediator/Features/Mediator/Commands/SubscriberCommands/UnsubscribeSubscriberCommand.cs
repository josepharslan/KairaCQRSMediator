using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.SubscriberCommands
{
    public record UnsubscribeSubscriberCommand(int Id) : IRequest;

}
