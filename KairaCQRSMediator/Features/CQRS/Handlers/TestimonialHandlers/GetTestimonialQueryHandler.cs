using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Results.TestimonialResults;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler(IRepository<Testimonial> _repository)
    {
        public async Task<List<GetTestimonialQueryResult>> Handle()
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x => new GetTestimonialQueryResult()
            {
                TestimonialId = x.TestimonialId,
                Comment = x.Comment,
                NameSurname = x.NameSurname
            }).ToList();
        }
    }
}