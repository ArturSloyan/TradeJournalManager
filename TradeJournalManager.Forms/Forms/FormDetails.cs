using TradeJournalManager.Domain.Models;

namespace TradeJournalManager.Forms.Forms
{
    public partial class FormDetails : Form
    {
        private readonly Trade _trade;
        public FormDetails(Trade trade)
        {
            InitializeComponent();

            _trade = trade;
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            textBoxId.Text = _trade.Id.ToString();
            textBoxStrategy.Text = _trade.Strategy.ToString();
            textBoxIndicator.Text = _trade.NameOfIndicator;
            textBoxCertificate.Text = _trade.NameOfCertificate;
            textBoxBuy.Text = _trade.Buy.ToString();
            textBoxSell.Text = _trade.Sell.ToString();
            textBoxRendite.Text = _trade.Rendite.ToString();
            textBoxReasons.Text = _trade.ThinkProzess;
            textBoxDate.Text = DateTimeOffset.FromUnixTimeSeconds(_trade.DateOfTrade).DateTime.ToString();
        }
    }
}
