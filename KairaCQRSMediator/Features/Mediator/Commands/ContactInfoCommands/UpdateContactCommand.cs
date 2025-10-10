using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands
{
    public class UpdateContactCommand : IRequest
    {
        public int ContactInfoId { get; set; }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
