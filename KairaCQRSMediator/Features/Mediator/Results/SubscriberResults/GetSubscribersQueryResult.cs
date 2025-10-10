namespace KairaCQRSMediator.Features.Mediator.Results.SubscriberResults
{
    public class GetSubscribersQueryResult
    {
        public int SubscriberId { get; set; }
        public string? Mail { get; set; }
        public DateTime SubscribedTime { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
