using System;
using System.Threading.Tasks;

namespace Shop.Core.Interfaces;

public interface ICacheService
{
    Task<TItem> GetOrCreateAsync<TItem>(string cacheKey, Func<Task<TItem>> factory);
}