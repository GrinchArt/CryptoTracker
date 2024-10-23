namespace CryptoTracker.Application.Dto
{
    public class CryptoCurrencyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal CurrentPrice { get; set; }
        public IEnumerable<MarketDto> Markets { get; set; }
    }
}
