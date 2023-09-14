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
            textBoxStrategy.Text = _trade.StrategyName;
            textBoxIndicator.Text = _trade.NameOfIndicator;
            textBoxCertificate.Text = _trade.NameOfCertificate;
            textBoxBuy.Text = _trade.Buy.ToString("C");
            textBoxSell.Text = _trade.Sell.ToString("C");
            textBoxRendite.Text = _trade.Rendite;
            textBoxReasons.Text = _trade.ThinkProcess;
            textBoxEntryDate.Text = DateTimeOffset.FromUnixTimeSeconds(_trade.EntryDate).DateTime.ToString();
            textBoxExitDate.Text = DateTimeOffset.FromUnixTimeSeconds(_trade.ExitDate).DateTime.ToString();
            label1.Select();
        }
    }
}
