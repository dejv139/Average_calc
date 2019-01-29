using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyDatabase
    {
        SQLiteAsyncConnection database;
        public MyDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Mark>().Wait();
        }

        public Task<List<Mark>> GetItemsAsync()
        {
            return database.Table<Mark>().ToListAsync();
        }

        public Task<List<Mark>> GetItemsNotDoneAsync(string sql)
        {
            return database.QueryAsync<Mark>(sql);
        }

        public Task<Mark> GetItemAsync(int id)
        {
            return database.Table<Mark>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Mark item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Mark item)
        {
            return database.DeleteAsync(item);
        }
    }
}
