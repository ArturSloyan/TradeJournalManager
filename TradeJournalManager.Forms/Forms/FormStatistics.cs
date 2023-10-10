using Humanizer;
using TradeJournalManager.Core;
using TradeJournalManager.Core.QuoteServices;
using TradeJournalManager.Core.TradeServices;
using TradeJournalManager.Domain.Extensions;
using TradeJournalManager.Domain.Models;

namespace TradeJournalManager.Forms
{
    public partial class FormStatistics : Form
    {
        private readonly IDataService<Trade> _tradeDataService;
        private readonly IDataService<Quote> _quoteDataService;
        public FormStatistics()
        {
            InitializeComponent();

            _tradeDataService = new TradeSqLiteDataService("TradeJournalDB.db");
            _quoteDataService = new QuoteSqLiteDataService();
        }

        private async void FormStatistics_Load(object sender, EventArgs e)
        {
            var tradeList = await _tradeDataService.GetAll();
            var quoteList = await _quoteDataService.GetAll();

            var random = new Random().Next(1, quoteList.Count);
            if (quoteList.Any(quote => quote.Id == random))
            {
                textBoxQuote.Text = quoteList.FirstOrDefault(quote => quote.Id == random).Text;
            }

            textBoxTradeCount.Text = tradeList.Count.ToString();
            progressBarWinLoss.Value = (int)Math.Round((float)tradeList.Where((trade => trade.IsWinningTrade() && trade.IsClosed)).Count() / (tradeList.Count() - tradeList.Where(trade => trade.IsSellTextboxEmpty()).Count()) * 100);
            textBoxInvestedCapital.Text = tradeList.Where(trade => !trade.IsClosed).Sum(trade => Convert.ToDouble(trade.Buy)).ToString("C");

            if (tradeList.Count != 0)
            {
                textBoxFirstTrade.Text = DateTimeOffset.FromUnixTimeSeconds((tradeList.Min(trade => trade.EntryDate))).DateTime.ToString();
            }

            if (tradeList.Any(trade => trade.IsClosed))
            {
                textBoxAverageRendite.Text = $"{Math.Round(tradeList.Where(trade => !trade.IsSellTextboxEmpty() && trade.IsClosed).Average(trade => trade.RenditeDouble), 2)} %";
                textBoxLongestHolding.Text = $"{tradeList.Where(trade => !trade.IsSellTextboxEmpty() && trade.IsClosed).Max(trade => TimeSpan.FromSeconds(trade.ExitDate - trade.EntryDate).Humanize(4))}";
                textBoxShortestHolding.Text = $"{tradeList.Where(trade => !trade.IsSellTextboxEmpty() && trade.IsClosed).Min(trade => TimeSpan.FromSeconds(trade.ExitDate - trade.EntryDate).Humanize(4))}";
                textBoxAverageHolding.Text = $"{TimeSpan.FromSeconds(tradeList.Where(trade => !trade.IsSellTextboxEmpty() && trade.IsClosed).Average(trade => trade.ExitDate - trade.EntryDate)).Humanize(4)}";
            }
            else
            {
                textBoxInvestedCapital.Text = 0.ToString("C");
            }

            if (tradeList.Any(trade => trade.IsWinningTrade() && trade.IsClosed))
            {
                textBoxTotalWin.Text = tradeList.Where(trade => trade.IsWinningTrade() && trade.IsClosed).Sum(trade => trade.LongCalculation()).ToString("C");
                textBoxAverageWin.Text = tradeList.Where(trade => trade.IsWinningTrade() && trade.IsClosed).Average(trade => trade.LongCalculation()).ToString("C");
                textBoxBiggestWin.Text = tradeList.Where(trade => trade.IsWinningTrade() && trade.IsClosed).Max(trade => trade.LongCalculation()).ToString("C");
            }

            if (tradeList.Any(trade => trade.IsLosingTrade() && trade.IsClosed))
            {
                textBoxTotalLoss.Text = tradeList.Where(trade => trade.IsLosingTrade() && trade.IsClosed).Sum(trade => trade.ShortCalculation()).ToString("C");
                textBoxAverageLoss.Text = tradeList.Where(trade => trade.IsLosingTrade() && trade.IsClosed).Average(trade => trade.ShortCalculation()).ToString("C");
                textBoxBiggestLoss.Text = tradeList.Where(trade => trade.IsLosingTrade() && trade.IsClosed).Max(trade => trade.ShortCalculation()).ToString("C");
            }

            label1.Select();
        }
    }
}