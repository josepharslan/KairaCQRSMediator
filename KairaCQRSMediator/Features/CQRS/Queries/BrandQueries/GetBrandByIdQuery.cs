namespace KairaCQRSMediator.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQuery(int Id)
    {
        public int Id { get; set; } = Id;
    }
}
