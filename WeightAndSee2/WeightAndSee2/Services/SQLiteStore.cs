using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeightAndSee2.Models;

namespace WeightAndSee2.Services
{
    public class SQLiteStore<Type>: IDataStore<Type> where Type: new()
    {
        protected static SQLiteAsyncConnection Database;

        public SQLiteStore()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<bool> AddItemAsync(Type item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Type> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Type>> GetItemsAsync(bool forceRefresh = false)
        {
            Task<List<Type>> retVal = null;
            try
            {
                TableMapping mapping = Database.GetMappingAsync<Type>().Result;
                retVal = Database.QueryAsync<Type>(String.Format("SELECT * FROM {0}",mapping.TableName));
            }
            catch (Exception e) { }

            return retVal;
        }

        public Task<bool> UpdateItemAsync(Type item)
        {
            bool affected = false;

            try
            {
                Int32 rowsAffected = Database.UpdateAsync(item).Result;
                affected = (rowsAffected == 1);
            }
            catch (Exception) { }

            return Task.FromResult(affected);
        }
    }
}
