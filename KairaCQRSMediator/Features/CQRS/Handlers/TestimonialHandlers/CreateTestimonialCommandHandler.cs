using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler(IRepository<Testimonial> _repository)
    {
        public async Task Handle(CreateTestimonialCommand createTestimonialCommand)
        {
            var testimonial = new Testimonial
            {
                Comment = createTestimonialCommand.Comment,
                NameSurname = createTestimonialCommand.NameSurname
            };

            await _repository.CreateAsync(testimonial);
        }
    }
}
