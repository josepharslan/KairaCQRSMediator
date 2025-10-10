namespace KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands
{
    public class RemoveServiceCommand(int id)
    {
        public int Id { get; set; } = id;
    }
}
