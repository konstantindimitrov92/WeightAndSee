using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeightAndSee2.Models;

namespace WeightAndSee2.Core
{
    public class SQLiteConnection
    {
        private static SQLiteAsyncConnection Connection;

        public static readonly AsyncLazy<SQLiteConnection> Instance = new AsyncLazy<SQLiteConnection>(async () =>
        {
            var instance = new SQLiteConnection();
            return instance;
        });
    }
}
