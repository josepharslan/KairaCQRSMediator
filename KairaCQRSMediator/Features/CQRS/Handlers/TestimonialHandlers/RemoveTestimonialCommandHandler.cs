using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers
{
    public class RemoveTestimonialCommandHandler(IRepository<Testimonial> _repository)
    {
        public async Task Handle(RemoveTestimonialCommand removeTestimonialCommand)
        {
            await _repository.DeleteAsync(removeTestimonialCommand.id);
        }
    }
}
