namespace KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands
{
    public class UpdateTestimonialCommand
    {
        public int TestimonialId { get; set; }
        public string? Comment { get; set; }
        public string? NameSurname { get; set; }
    }
}
