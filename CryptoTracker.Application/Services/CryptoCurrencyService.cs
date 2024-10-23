using CryptoTracker.Application.Dto;
using CryptoTracker.Application.Interfaces;
using CryptoTracker.Domain.Interfaces;

namespace CryptoTracker.Application.Services
{
    public class CryptoCurrencyService : ICryptoCurrencyService
    {
        private readonly ICryptoRepository _cryptoRepository;

        public CryptoCurrencyService(ICryptoRepository cryptoRepository)
        {
            _cryptoRepository = cryptoRepository;
        }

        public async Task<IEnumerable<CryptoCurrencyDto>> GetTopCurrenciesAsync(int count)
        {
            var currencies = await _cryptoRepository.GetTopCurrenciesAsync(count);
            return currencies.Select(c => new CryptoCurrencyDto
            {
                Id = c.Id,
                Name = c.Name,
                Symbol = c.Symbol,
                CurrentPrice = c.CurrentPrice,
                Markets = c.Markets.Select(m => new MarketDto
                {
                    Name = m.Name,
                    TradingPair = m.TradingPair,
                    Price = m.Price.Value
                })
            });
        }

        public async Task<CryptoCurrencyDto> GetCurrencyByIdAsync(Guid id)
        {
            var currency = await _cryptoRepository.GetByIdAsync(id);
            return new CryptoCurrencyDto
            {
                Id = currency.Id,
                Name = currency.Name,
                Symbol = currency.Symbol,
                CurrentPrice = currency.CurrentPrice,
                Markets = currency.Markets.Select(m => new MarketDto
                {
                    Name = m.Name,
                    TradingPair = m.TradingPair,
                    Price = m.Price.Value
                })
            };
        }

        public async Task UpdateCurrencyPriceAsync(Guid currencyId, decimal newPrice)
        {
            var cryptoCurrency = await _cryptoRepository.GetByIdAsync(currencyId);
            cryptoCurrency.UpdatePrice(newPrice);
            await _cryptoRepository.UpdateAsync(cryptoCurrency);
        }
    }
}
