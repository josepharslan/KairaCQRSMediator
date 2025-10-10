namespace KairaCQRSMediator.Features.CQRS.Queries.ServiceQueries
{
    public class GetServiceByIdQuery(int id)
    {
        public int Id { get; set; } = id;
    }
}
