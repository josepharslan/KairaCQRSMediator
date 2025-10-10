namespace KairaCQRSMediator.Features.Mediator.Results.SubscriberResults
{
    public class GetSubscriberByIdQueryResult
    {
        public string? Mail { get; set; }
        public DateTime SubscribedTime { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
