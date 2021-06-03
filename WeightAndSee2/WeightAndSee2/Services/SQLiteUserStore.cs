using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeightAndSee2.Models;
namespace WeightAndSee2.Services
{
    public class SQLiteUserStore : IDataStore<User>
    {
        Task<bool> IDataStore<User>.AddItemAsync(User item)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDataStore<User>.DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<User> IDataStore<User>.GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<User>> IDataStore<User>.GetItemsAsync(bool forceRefresh)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDataStore<User>.UpdateItemAsync(User item)
        {
            throw new NotImplementedException();
        }
    }
}
