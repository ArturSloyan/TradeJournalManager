using System.Text.RegularExpressions;
using TradeJournalManager.Core;
using TradeJournalManager.Core.QuoteServices;
using TradeJournalManager.Core.TradeServices;
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

            if (tradeList.Count != 0)
            {
                buttonWinLegende.BackColor = Color.ForestGreen;
                buttonLossLegende.BackColor = Color.LightGray;
                progressBarWinLoss.Value = 100 / tradeList.Count * tradeList.Where((trade => trade.Buy < trade.Sell && trade.Sell != 0)).ToList().Count;
                textBoxFirstTrade.Text = DateTimeOffset.FromUnixTimeSeconds((tradeList.Min(trade => trade.DateOfTrade))).DateTime.ToString();
            }

            if (quoteList.Any(quote => quote.Id == random))
            {
                textBoxQuote.BackColor = Color.AntiqueWhite;
                textBoxQuote.Text = (quoteList.FirstOrDefault(quote => quote.Id == random)).Text;
            }

            if (tradeList.Any(trade => trade.Sell != 0))
            {
                textBoxAverageRendite.Text = $"{Math.Round((tradeList.Where(trade => trade.Sell != 0).Average(trade => double.Parse(MyRegex().Match(trade.Rendite).Value))), 2)} %";
            }

            if (tradeList.Any(trade => trade.Sell == 0))
            {
                textBoxInvestedCapital.Text = (tradeList.Where(trade => trade.Sell == 0).Sum(trade => Convert.ToDouble(trade.Buy))).ToString();
            }

            if (tradeList.Any(trade => trade.Buy < trade.Sell && trade.Sell != 0))
            {
                textBoxTotalWin.Text = (tradeList.Where(trade => trade.Buy < trade.Sell && trade.Sell != 0).Sum(trade => trade.Sell - trade.Buy)).ToString();
                textBoxAverageWin.Text = (tradeList.Where(trade => trade.Buy < trade.Sell && trade.Sell != 0).Average(trade => trade.Sell - trade.Buy)).ToString();
                textBoxBiggestWin.Text = (tradeList.Where(trade => trade.Buy < trade.Sell && trade.Sell != 0).Max(trade => trade.Sell - trade.Buy)).ToString();
            }

            if (tradeList.Any(trade => trade.Buy > trade.Sell && trade.Sell != 0))
            {
                textBoxTotalLoss.Text = (tradeList.Where(trade => trade.Buy > trade.Sell && trade.Sell != 0).Sum(trade => trade.Buy - trade.Sell)).ToString();
                textBoxAverageLoss.Text = (tradeList.Where(trade => trade.Buy > trade.Sell && trade.Sell != 0).Average(trade => trade.Buy - trade.Sell)).ToString();
                textBoxBiggestLoss.Text = (tradeList.Where(trade => trade.Buy > trade.Sell && trade.Sell != 0).Max(trade => trade.Buy - trade.Sell)).ToString();
            }

            textBoxTradeCount.Text = tradeList.Count.ToString();
        }

        [GeneratedRegex("\\d+")]
        private static partial Regex MyRegex();
    }
}