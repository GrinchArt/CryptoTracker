namespace CryptoTracker.Domain.Entities
{
    public class CryptoCurrency
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public decimal CurrentPrice { get; private set; }
        public List<Market> Markets { get; private set; }

        public CryptoCurrency(string name, string symbol)
        {
            Id = Guid.NewGuid();
            Name = name;
            Symbol = symbol;
            Markets = new List<Market>();
        }

        public void UpdatePrice(decimal newPrice)
        {
            CurrentPrice = newPrice;
        }

        public void AddMarket(Market market)
        {
            if (Markets.Any(m => m.Name == market.Name))
                throw new InvalidOperationException("Market already exists.");
            Markets.Add(market);
        }
    }

}
