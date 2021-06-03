using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeightAndSee2.Models;

using WeightAndSee2.Core;
namespace WeightAndSee2.Services
{
    public class SQLiteItemStore: IDataStore<Item>
    {
        public SQLiteItemStore()
        {
            // Init DB connection here?
        }

        Task<bool> IDataStore<Item>.AddItemAsync(Item item)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDataStore<Item>.UpdateItemAsync(Item item)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDataStore<Item>.DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<Item> IDataStore<Item>.GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Item>> IDataStore<Item>.GetItemsAsync(bool forceRefresh)
        {
            throw new NotImplementedException();
        }
    }
}
