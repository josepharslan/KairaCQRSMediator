using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler(IRepository<Testimonial> _repository)
    {
        public async Task Handle(UpdateTestimonialCommand updateTestimonialCommand)
        {
            await _repository.UpdateAsync(new Testimonial
            {
                TestimonialId = updateTestimonialCommand.TestimonialId,
                Comment = updateTestimonialCommand.Comment,
                NameSurname = updateTestimonialCommand.NameSurname
            });
        }
    }
}
