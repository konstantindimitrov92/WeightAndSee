using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeightAndSee2.Models;

using WeightAndSee2.Core;
using SQLite;

namespace WeightAndSee2.Services
{
    public class SQLiteUserStore : SQLiteStore<User>
    {
        public SQLiteUserStore()
        {
            try
            {
                Database.CreateTableAsync<User>().Wait();
                User defaultUser = new User 
                { 
                    Username = "dbojadzievski@gmail.com", 
                    Password = "", 
                    CreatedAt = DateTime.Now, 
                    ModifiedAt = null, 
                    ID = 0 
                };
                Database.InsertOrReplaceAsync(defaultUser).Wait();
            }
            catch (Exception e) { }
        }
    }
}
