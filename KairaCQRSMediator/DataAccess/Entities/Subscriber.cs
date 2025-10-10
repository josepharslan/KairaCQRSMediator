namespace KairaCQRSMediator.DataAccess.Entities
{
    public class Subscriber
    {
        public int SubscriberId { get; set; }
        public string? Mail { get; set; }
        public DateTime SubscribedTime { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
