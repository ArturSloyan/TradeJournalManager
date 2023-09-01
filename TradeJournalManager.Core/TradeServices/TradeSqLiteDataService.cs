using Dapper;
using Microsoft.Data.Sqlite;
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
                {nameof(Trade.Rendite)},
                {nameof(Trade.ThinkProzess)},
                {nameof(Trade.DateOfTrade)}) VALUES(
                @{nameof(Trade.Strategy)},
                @{nameof(Trade.NameOfIndicator)},
                @{nameof(Trade.NameOfCertificate)},
                @{nameof(Trade.Buy)},
                @{nameof(Trade.Sell)},
                @{nameof(Trade.Rendite)},
                @{nameof(Trade.ThinkProzess)},
                @{nameof(Trade.DateOfTrade)})
                """, (item.Strategy, item.NameOfIndicator, item.NameOfCertificate, item.Buy, item.Sell, (item.Sell * 100 / item.Buy), item.ThinkProzess, item.DateOfTrade));
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
                {nameof(Trade.Rendite)} = @{nameof(Trade.Rendite)},
                {nameof(Trade.ThinkProzess)} = @{nameof(Trade.ThinkProzess)},
                {nameof(Trade.DateOfTrade)} = @{nameof(Trade.DateOfTrade)}
                WHERE {nameof(Trade.Id)} = @{nameof(Trade.Id)}
                """, (item.Strategy, item.NameOfIndicator, item.NameOfCertificate, item.Buy, item.Sell, item.Rendite = item.Sell * 100 / item.Buy, item.ThinkProzess, item.DateOfTrade, item.Id));
            _connection.Close();
        }

        public override void Delete(int id)
        {
            base.Delete(id);

            _connection.Open();
            _connection.Execute($"""
                DELETE FROM {nameof(Trade)}
                WHERE {nameof(Trade.Id)} = @{nameof(Trade.Id)}
                """, (id));
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