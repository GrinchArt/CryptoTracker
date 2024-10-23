namespace CryptoTracker.Domain.Entities
{
    public class Price
    {
        public decimal Value { get; private set; }
        public DateTime Timestamp { get; private set; }

        public Price(decimal value, DateTime timestamp)
        {
            Value = value;
            Timestamp = timestamp;
        }
    }

}
