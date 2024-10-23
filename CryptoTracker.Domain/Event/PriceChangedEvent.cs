using CryptoTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Domain.Event
{
    public class PriceChangedEvent
    {
        public CryptoCurrency Currency { get; }
        public decimal OldPrice { get; }
        public decimal NewPrice { get; }

        public PriceChangedEvent(CryptoCurrency currency, decimal oldPrice, decimal newPrice)
        {
            Currency = currency;
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }

}
