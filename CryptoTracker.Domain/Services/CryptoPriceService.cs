using CryptoTracker.Domain.Event;
using CryptoTracker.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Domain.Services
{
    public class CryptoPriceService
    {
        private readonly ICryptoRepository _cryptoRepository;

        public CryptoPriceService(ICryptoRepository cryptoRepository)
        {
            _cryptoRepository = cryptoRepository;
        }

        public async Task UpdateCryptoPriceAsync(Guid currencyId, decimal newPrice)
        {
            var cryptoCurrency = await _cryptoRepository.GetByIdAsync(currencyId);
            var oldPrice = cryptoCurrency.CurrentPrice;
            cryptoCurrency.UpdatePrice(newPrice);

            // New price event
            var priceChangedEvent = new PriceChangedEvent(cryptoCurrency, oldPrice, newPrice);

            await _cryptoRepository.UpdateAsync(cryptoCurrency);
        }
    }

}
