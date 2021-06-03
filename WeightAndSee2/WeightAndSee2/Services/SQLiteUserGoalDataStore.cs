using System;
using System.Collections.Generic;
using System.Text;
using WeightAndSee2.Models;

namespace WeightAndSee2.Services
{
    public class SQLiteUserGoalDataStore: SQLiteStore<UserGoal>
    {
        public SQLiteUserGoalDataStore()
        {
            Database.CreateTableAsync<UserGoal>().Wait();
            UserGoal defaultGoal = new UserGoal()
            {
                User_ID = 0,
                CreatedAt = DateTime.Now,
                To = DateTime.Now.AddDays(7 * 4 * 6) // Six months.
            };

            try
            {
                Database.InsertOrReplaceAsync(defaultGoal);
            }
            catch (Exception e) { }
        }
    }
}
