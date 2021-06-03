using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeightAndSee2.Models;

namespace WeightAndSee2.Services
{
    public class SQLiteUserDataPointStore: SQLiteStore<UserDataPoint>
    {
        public SQLiteUserDataPointStore()
        {
            try
            {
                Database.CreateTableAsync<UserDataPoint>().Wait();
                UserDataPoint defaultPoint = new UserDataPoint
                {
                    User_ID = 0,
                    CreatedAt = DateTime.Now,
                    Weight = 98.4f
                };
                Database.InsertOrReplaceAsync(defaultPoint);
            }
            catch (Exception e) { }
        }

        public Task<List<UserDataPoint>> GetDataPoints(in User User, in UInt32 DaysToConsider = 30)
        {
            Task<List<UserDataPoint>> retVal = null;
            try
            {
                String mapping = Database.GetMappingAsync<UserDataPoint>().Result.TableName;
                StringBuilder query = new StringBuilder();
                query.Append(String.Format("SELECT * FROM {0}", mapping));
                if (DaysToConsider != 0)
                {
                    DateTime LastConsideredDay = DateTime.Now.AddDays(-DaysToConsider);
                    DateTimeOffset offset = LastConsideredDay;
                    Int64 timestamp = offset.ToUnixTimeSeconds();
                    query.Append(String.Format(" WHERE CreatedAt >= {0}", timestamp.ToString()));

                    String finalQuery = query.ToString();
                    retVal = Database.QueryAsync<UserDataPoint>(finalQuery);
                }
            }
            catch (Exception e) { }

            return retVal;
        }
    }
}
