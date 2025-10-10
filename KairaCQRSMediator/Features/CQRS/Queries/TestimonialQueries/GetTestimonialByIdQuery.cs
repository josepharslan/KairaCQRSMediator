namespace KairaCQRSMediator.Features.CQRS.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery(int id)
    {
        public int Id { get; set; } = id;
    }
}
