using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands
{
    public class CreateContactCommand : IRequest
    {
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
