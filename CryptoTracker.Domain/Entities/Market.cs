namespace CryptoTracker.Domain.Entities
{
    public class Market
    {
        public string Name { get; private set; }
        public string TradingPair { get; private set; }
        public Price Price { get; private set; }

        public Market(string name, string tradingPair, Price price)
        {
            Name = name;
            TradingPair = tradingPair;
            Price = price;
        }
    }

}
