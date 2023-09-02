using TradeJournalManager.Core;
using TradeJournalManager.Core.TradeServices;
using TradeJournalManager.Domain.Models;
using TradeJournalManager.Forms.Forms;

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

        private void Load_DataGrid()
        {
            dataGridViewTrades.DataSource = null;
            dataGridViewTrades.DataSource = _dataService.GetAll();

            dataGridViewTrades.Columns[nameof(Trade.Strategy)].Visible = false;
            dataGridViewTrades.Columns[nameof(Trade.DateOfTrade)].Visible = false;
            dataGridViewTrades.Columns[nameof(Trade.Rendite)].Visible = false;

            dataGridViewTrades.Columns[nameof(Trade.Id)].DisplayIndex = 0;
            dataGridViewTrades.Columns[nameof(Trade.StrategyName)].DisplayIndex = 1;
            dataGridViewTrades.Columns[nameof(Trade.NameOfIndicator)].DisplayIndex = 2;
            dataGridViewTrades.Columns[nameof(Trade.NameOfCertificate)].DisplayIndex = 3;
            dataGridViewTrades.Columns[nameof(Trade.Buy)].DisplayIndex = 4;
            dataGridViewTrades.Columns[nameof(Trade.Sell)].DisplayIndex = 5;
            dataGridViewTrades.Columns[nameof(Trade.RenditeView)].DisplayIndex = 6;
            dataGridViewTrades.Columns[nameof(Trade.ThinkProzess)].DisplayIndex = 11;
            dataGridViewTrades.Columns[nameof(Trade.Date)].DisplayIndex = 11;

            dataGridViewTrades.Columns[nameof(Trade.Strategy)].DisplayIndex = 11;
            dataGridViewTrades.Columns[nameof(Trade.DateOfTrade)].DisplayIndex = 11;
            dataGridViewTrades.Columns[nameof(Trade.Rendite)].DisplayIndex = 11;

            dataGridViewTrades.Columns[nameof(Trade.ThinkProzess)].Width = 363;

            dataGridViewTrades.Columns[nameof(Trade.StrategyName)].HeaderText = "Strategy";
            dataGridViewTrades.Columns[nameof(Trade.NameOfIndicator)].HeaderText = "Indicator";
            dataGridViewTrades.Columns[nameof(Trade.NameOfCertificate)].HeaderText = "Certificate";
            dataGridViewTrades.Columns[nameof(Trade.StrategyName)].HeaderText = "Strategy";
            dataGridViewTrades.Columns[nameof(Trade.DateOfTrade)].HeaderText = "Date";
            dataGridViewTrades.Columns[nameof(Trade.ThinkProzess)].HeaderText = "Reason";
            dataGridViewTrades.Columns[nameof(Trade.RenditeView)].HeaderText = "Rendite";

            buttonEdit.Enabled = dataGridViewTrades.RowCount > 0;
            buttonDelete.Enabled = dataGridViewTrades.RowCount > 0;
        }

        private void DataGridViewTrades_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTrades.RowCount > 0)
            {
                try
                {
                    _trade = dataGridViewTrades.CurrentRow.DataBoundItem as Trade;
                }
                catch { }
            }
        }

        private void DataGridViewTrades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new FormDetails(_trade).ShowDialog();
        }

        private void ButtonAddOrEdit_Click(object sender, EventArgs e)
        {
            var t = sender == buttonAdd ? new Trade() : _trade;

            if (new FormData(t).ShowDialog() == DialogResult.OK)
            {
                if (sender == buttonAdd)
                {
                    try
                    {
                        _dataService.Add(t);
                    }
                    catch { throw new Exception("Adding trade doesnt work. Contact artur."); }
                }
                else
                {
                    try
                    {
                        _dataService.Edit(t, t.Id);
                    }
                    catch { throw new Exception("Editing trade doesnt work. Contact artur."); }
                }
            }

            Load_DataGrid();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _dataService.Delete(_trade.Id);
            }
            catch { throw new Exception("Deleteing trade doesnt work. Contact artur."); }

            Load_DataGrid();
        }
    }
}
