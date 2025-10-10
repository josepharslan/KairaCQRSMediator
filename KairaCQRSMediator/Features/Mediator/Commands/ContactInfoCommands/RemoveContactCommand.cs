using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands
{
    public class RemoveContactCommand(int id) : IRequest
    {
        public int Id { get; set; } = id;
    }
}
