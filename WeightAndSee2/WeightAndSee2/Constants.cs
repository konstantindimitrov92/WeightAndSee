using System;
using System.Collections.Generic;
using System.Text;

namespace WeightAndSee2
{
    public static class Constants
    {
        public const string DatabaseFileName = "MasterDatabase.db";
        public const SQLite.SQLiteOpenFlags Flags =
            // Open the database in r/w mode.
            SQLite.SQLiteOpenFlags.ReadWrite
            // Create if doesn't exist.
            | SQLite.SQLiteOpenFlags.Create
            // Enable multi-threaded database access.
            | SQLite.SQLiteOpenFlags.SharedCache
        ;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return System.IO.Path.Combine(basePath, DatabaseFileName);
            }
        }
    }
}
