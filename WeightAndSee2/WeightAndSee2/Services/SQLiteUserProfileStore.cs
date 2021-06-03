using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeightAndSee2.Models;

namespace WeightAndSee2.Services
{
    public class SQLiteUserProfileStore : SQLiteStore<UserProfile>
    {
        public SQLiteUserProfileStore()
        {
            try
            {
                Database.CreateTableAsync<UserProfile>().Wait();
                UserProfile defaultProfile = new UserProfile 
                { 
                    User_ID = 0, 
                    ID = 0, 
                    BirthDay = DateTime.Parse(@"08/28/1992 00:00:00"), 
                    CreatedAt = DateTime.Now,
                    Height = 183, 
                    Sex = Sex.Male 
                };
                Database.InsertOrReplaceAsync(defaultProfile).Wait();
            }
            catch (Exception e) { }
        }

        public Task<List<UserProfile>> GetAll()
        {
            return Database.QueryAsync<UserProfile>("Select * FROM UserProfile");
        }
    }
}
