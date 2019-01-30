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
            database.CreateTableAsync<Subject>().Wait();
        }

        public Task<List<T>> GetListOf<T>() where T : ATable, new()
        {
            return database.Table<T>().ToListAsync();
        }

        public Task<List<Mark>> GetMarksBySqlRequest(string Request)
        {
            return database.QueryAsync<Mark>(Request);
        }

        public async Task<T> GetById<T>(int id) where T : ATable, new()
        {
            return await database.Table<T>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> InsertMark(Mark item)
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
        public Task<int> InsertSubject(Subject item)
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

        public Task<int> DeleteMark(Mark item)
        {
            return database.DeleteAsync(item);
        }
    }
}
