using Dapper;
using Microsoft.Data.Sqlite;
using TradeJournalManager.Domain.Models;

namespace TradeJournalManager.Core.QuoteServices
{
    public class QuoteSqLiteDataService : IDataService<Quote>
    {
        public void Add(Quote item)
        {
            throw new Exception("Adding quote is only possible in database. Contact databaseadmin");
        }

        public void Edit(Quote item, int id)
        {
            throw new Exception("Editing quote is only possible in database. Contact databaseadmin");
        }

        public void Delete(int id)
        {
            throw new Exception("Deleting quote is only possible in database. Contact databaseadmin");
        }

        public List<Quote> GetAll()
        {
            using var connection = new SqliteConnection("Data Source = TradeJournalDB.db");

            return connection.Query<Quote>($"SELECT * FROM {nameof(Quote)}").ToList();
        }
    }
}
