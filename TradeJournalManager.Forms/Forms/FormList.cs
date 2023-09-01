using TradeJournalManager.Core;
using TradeJournalManager.Core.TradeServices;
using TradeJournalManager.Domain.Models;

namespace TradeJournalManager.Forms
{
    public partial class FormList : Form
    {
        private Trade _trade;
        private readonly IDataService<Trade> _dataService;
        public FormList()
        {
            InitializeComponent();

            _dataService = new TradeSqLiteDataService("TradeJournalDB.db");

            Load_DataGrid();
        }

        private void dataGridViewTrades_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _trade = dataGridViewTrades.CurrentRow.DataBoundItem as Trade;
            }
            catch { }
        }

        private void dataGridViewTrades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // details form
        }

        private void Load_DataGrid()
        {
            dataGridViewTrades.DataSource = null;
            dataGridViewTrades.DataSource = _dataService.GetAll();

            buttonEdit.Enabled = dataGridViewTrades.RowCount > 0;
            buttonDelete.Enabled = dataGridViewTrades.RowCount > 0;
        }
    }
}
