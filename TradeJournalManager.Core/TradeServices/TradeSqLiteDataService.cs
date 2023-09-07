using Dapper;
using Microsoft.Data.Sqlite;
using TradeJournalManager.Core.AbstractServices;
using TradeJournalManager.Domain.Models;

namespace TradeJournalManager.Core.TradeServices
{
    public class TradeSqLiteDataService : TradeDataService
    {
        private readonly SqliteConnection _connection;
        public TradeSqLiteDataService(string dbPath)
        {
            _connection = new SqliteConnection($"Data Source = {dbPath}");
        }

        public override void Add(Trade item)
        {
            base.Add(item);

            _connection.Open();
            _connection.Execute($"""
                INSERT INTO {nameof(Trade)}(
                {nameof(Trade.Strategy)},
                {nameof(Trade.NameOfIndicator)},
                {nameof(Trade.NameOfCertificate)},
                {nameof(Trade.Buy)},
                {nameof(Trade.Sell)},
                {nameof(Trade.ThinkProcess)},
                {nameof(Trade.EntryDate)},
                {nameof(Trade.ExitDate)}) VALUES(
                @{nameof(Trade.Strategy)},
                @{nameof(Trade.NameOfIndicator)},
                @{nameof(Trade.NameOfCertificate)},
                @{nameof(Trade.Buy)},
                @{nameof(Trade.Sell)},
                @{nameof(Trade.ThinkProcess)},
                @{nameof(Trade.EntryDate)}, 
                @{nameof(Trade.ExitDate)})
                """, new { item.Strategy, item.NameOfIndicator, item.NameOfCertificate, item.Buy, item.Sell, item.ThinkProcess, item.EntryDate, item.ExitDate });
            _connection.Close();
        }

        public override void Edit(Trade item, int id)
        {
            base.Edit(item, id);

            _connection.Open();
            _connection.Execute($"""
                UPDATE {nameof(Trade)} SET
                {nameof(Trade.Strategy)} = @{nameof(Trade.Strategy)},
                {nameof(Trade.NameOfIndicator)} = @{nameof(Trade.NameOfIndicator)},
                {nameof(Trade.NameOfCertificate)} = @{nameof(Trade.NameOfCertificate)},
                {nameof(Trade.Buy)} = @{nameof(Trade.Buy)},
                {nameof(Trade.Sell)} = @{nameof(Trade.Sell)},
                {nameof(Trade.ThinkProcess)} = @{nameof(Trade.ThinkProcess)},
                {nameof(Trade.EntryDate)} = @{nameof(Trade.EntryDate)},
                {nameof(Trade.ExitDate)} = @{nameof(Trade.ExitDate)} 
                WHERE {nameof(Trade.Id)} = @{nameof(Trade.Id)}
                """, new { item.Strategy, item.NameOfIndicator, item.NameOfCertificate, item.Buy, item.Sell, item.ThinkProcess, item.EntryDate, item.ExitDate, item.Id });
            _connection.Close();
        }

        public override void Delete(int id)
        {
            base.Delete(id);

            _connection.Open();
            _connection.Execute($"""
                DELETE FROM {nameof(Trade)}
                WHERE {nameof(Trade.Id)} = @{nameof(Trade.Id)}
                """, new { Id = id });
            _connection.Close();
        }

        public override List<Trade> GetAll()
        {
            _connection.Open();
            var trades = _connection.Query<Trade>($"""
                SELECT * FROM {nameof(Trade)}
                """).ToList();
            _connection.Close();
            
            return trades;
        }
    }
}