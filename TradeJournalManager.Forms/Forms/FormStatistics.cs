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

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            var tradeList = _tradeDataService.GetAll();
            var quoteList = _quoteDataService.GetAll();

            var random = new Random().Next(1, quoteList.Count);
            if (quoteList.Any(quote => quote.Id == random))
            {
                textBoxQuote.Text = quoteList.FirstOrDefault(quote => quote.Id == random).Text;
            }

            if (tradeList.Count != 0)
            {
                progressBarWinLoss.Value = (int)Math.Round((float)tradeList.Where((trade => trade.IsWinningTrade())).Count() / (tradeList.Count() - tradeList.Where(trade => trade.IsSellTextboxEmpty()).Count()) * 100);
                textBoxFirstTrade.Text = DateTimeOffset.FromUnixTimeSeconds((tradeList.Min(trade => trade.EntryDate))).DateTime.ToString();
            }

            if (tradeList.Any(trade => !trade.IsSellTextboxEmpty()))
            {
                textBoxAverageRendite.Text = $"{Math.Round(tradeList.Where(trade => !trade.IsSellTextboxEmpty()).Average(trade => trade.RenditeDouble), 2)} %";
                textBoxLongestHolding.Text = $"{tradeList.Where(trade => !trade.IsSellTextboxEmpty()).Max(trade => TimeSpan.FromSeconds(trade.ExitDate - trade.EntryDate).Humanize(4))}";
                textBoxShortestHolding.Text = $"{tradeList.Where(trade => !trade.IsSellTextboxEmpty()).Min(trade => TimeSpan.FromSeconds(trade.ExitDate - trade.EntryDate).Humanize(4))}";
                textBoxAverageHolding.Text = $"{TimeSpan.FromSeconds(tradeList.Where(trade => !trade.IsSellTextboxEmpty()).Average(trade => trade.ExitDate - trade.EntryDate)).Humanize(4)}";
            }

            if (tradeList.Any(trade => trade.IsSellTextboxEmpty()))
            {
                textBoxInvestedCapital.Text = tradeList.Where(trade => trade.IsSellTextboxEmpty()).Sum(trade => Convert.ToDouble(trade.Buy)).ToString("C");
            }
            else
            {
                textBoxInvestedCapital.Text = 0.ToString("C");
            }

            if (tradeList.Any(trade => trade.IsWinningTrade()))
            {
                textBoxTotalWin.Text = tradeList.Where(trade => trade.IsWinningTrade()).Sum(trade => trade.LongCalculation()).ToString("C");
                textBoxAverageWin.Text = tradeList.Where(trade => trade.IsWinningTrade()).Average(trade => trade.LongCalculation()).ToString("C");
                textBoxBiggestWin.Text = tradeList.Where(trade => trade.IsWinningTrade()).Max(trade => trade.LongCalculation()).ToString("C");
            }

            if (tradeList.Any(trade => trade.IsLosingTrade()))
            {
                textBoxTotalLoss.Text = tradeList.Where(trade => trade.IsLosingTrade()).Sum(trade => trade.ShortCalculation()).ToString("C");
                textBoxAverageLoss.Text = tradeList.Where(trade => trade.IsLosingTrade()).Average(trade => trade.ShortCalculation()).ToString("C");
                textBoxBiggestLoss.Text = tradeList.Where(trade => trade.IsLosingTrade()).Max(trade => trade.ShortCalculation()).ToString("C");
            }

            textBoxTradeCount.Text = tradeList.Count.ToString();
        }
    }
}