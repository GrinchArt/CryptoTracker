using CryptoTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Domain.Interfaces
{
    public interface ICryptoRepository
    {
        Task<CryptoCurrency> GetByIdAsync(Guid id);
        Task<IEnumerable<CryptoCurrency>> GetTopCurrenciesAsync(int count);
        Task AddAsync(CryptoCurrency currency);
        Task UpdateAsync(CryptoCurrency currency);
        Task DeleteAsync(Guid id);
    }

}
