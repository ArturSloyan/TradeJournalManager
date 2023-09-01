using TradeJournalManager.Domain.Models;

namespace TradeJournalManager.Forms.Forms
{
    public partial class FormData : Form
    {
        private Trade _trade;
        public FormData(Trade trade)
        {
            InitializeComponent();

            _trade = trade;
        }
    }
}
