using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassLibrary1
{
     public class DBManager
    {
        static MyDatabase database;

        public static MyDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MyDatabase(
                      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Todo4SQLite.db3"));
                }
                return database;
            }
        }
    }
}
