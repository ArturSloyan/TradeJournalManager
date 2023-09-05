﻿using TradeJournalManager.Core;
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

            if (tradeList.Count != 0)
            {
                progressBarWinLoss.Value = (int)Math.Round((float)tradeList.Where((trade => trade.IsWinningTrade())).Count() / (tradeList.Count() - tradeList.Where(trade => trade.IsSellTextboxEmpty()).Count()) * 100);
                textBoxFirstTrade.Text = DateTimeOffset.FromUnixTimeSeconds((tradeList.Min(trade => trade.DateOfTrade))).DateTime.ToString();
            }

            var random = new Random().Next(1, quoteList.Count);
            if (quoteList.Any(quote => quote.Id == random))
            {
                textBoxQuote.Text = quoteList.FirstOrDefault(quote => quote.Id == random).Text;
            }

            if (tradeList.Any(trade => !trade.IsSellTextboxEmpty()))
            {
                textBoxAverageRendite.Text = $"{Math.Round(tradeList.Where(trade => !trade.IsSellTextboxEmpty()).Average(trade => trade.RenditeDouble), 2)} %";
            }

            if (tradeList.Any(trade => trade.IsSellTextboxEmpty()))
            {
                textBoxInvestedCapital.Text = tradeList.Where(trade => trade.IsSellTextboxEmpty()).Sum(trade => Convert.ToDouble(trade.Buy)).ToString();
            }

            if (tradeList.Any(trade => trade.IsWinningTrade()))
            {
                textBoxTotalWin.Text = tradeList.Where(trade => trade.IsWinningTrade()).Sum(trade => trade.LongCalculation()).ToString();
                textBoxAverageWin.Text = tradeList.Where(trade => trade.IsWinningTrade()).Average(trade => trade.LongCalculation()).ToString();
                textBoxBiggestWin.Text = tradeList.Where(trade => trade.IsWinningTrade()).Max(trade => trade.LongCalculation()).ToString();
            }

            if (tradeList.Any(trade => trade.IsLosingTrade()))
            {
                textBoxTotalLoss.Text = tradeList.Where(trade => trade.IsLosingTrade()).Sum(trade => trade.ShortCalculation()).ToString();
                textBoxAverageLoss.Text = tradeList.Where(trade => trade.IsLosingTrade()).Average(trade => trade.ShortCalculation()).ToString();
                textBoxBiggestLoss.Text = tradeList.Where(trade => trade.IsLosingTrade()).Max(trade => trade.ShortCalculation()).ToString();
            }

            textBoxTradeCount.Text = tradeList.Count.ToString();
        }
    }
}