using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeightAndSee2.Models;

namespace WeightAndSee2.Services
{
    public interface IDataStore<T> where T: new()
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<List<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
