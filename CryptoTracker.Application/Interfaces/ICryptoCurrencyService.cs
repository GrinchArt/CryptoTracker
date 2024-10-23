using CryptoTracker.Application.Dto;

namespace CryptoTracker.Application.Interfaces
{
    public interface ICryptoCurrencyService
    {
        Task<IEnumerable<CryptoCurrencyDto>> GetTopCurrenciesAsync(int count);
        Task<CryptoCurrencyDto> GetCurrencyByIdAsync(Guid id);
        Task UpdateCurrencyPriceAsync(Guid currencyId, decimal newPrice);
    }
}
