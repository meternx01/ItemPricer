using ItemPricer.Models;
using SQLite;

namespace ItemPricer.Services
{
    public class ItemRepository
    {
        string _dbPath;

        public string StatusMessage { get; set; }

        private static SQLiteAsyncConnection conn;

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);
        }

        public ItemRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task<List<Item>> GetItems(string searchTerm)
        {

            try
            {
                Init();
                //return await conn.Table<Item>().Where(p => p.Name.Contains(searchTerm) ).ToListAsync();
                return await conn.QueryAsync<Item>("SELECT * FROM item_basic WHERE name LIKE " + searchTerm + " AND AH>0");
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Item>();
        }

    }
}
