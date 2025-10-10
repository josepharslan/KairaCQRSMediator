namespace KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands
{
    public class RemoveTestimonialCommand(int id)
    {
        public int id { get; set; } = id;
    }
}
