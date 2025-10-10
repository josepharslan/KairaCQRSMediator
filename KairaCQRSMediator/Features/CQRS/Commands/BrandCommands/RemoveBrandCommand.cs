namespace KairaCQRSMediator.Features.CQRS.Commands.BrandCommands
{
    public class RemoveBrandCommand(int id)
    {
        public int Id { get; set; } = id;
    }
}
