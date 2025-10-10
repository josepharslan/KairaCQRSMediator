using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Queries.TestimonialQueries;
using KairaCQRSMediator.Features.CQRS.Results.TestimonialResults;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler(IRepository<Testimonial> _repository)
    {
        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery getTestimonialByIdQuery)
        {
            var value = await _repository.GetByIdAsync(getTestimonialByIdQuery.Id);

            return new GetTestimonialByIdQueryResult
            {
                TestimonialId = value.TestimonialId,
                Comment = value.Comment,
                NameSurname = value.NameSurname
            };
        }
    }
}
