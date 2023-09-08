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
            var list = _dataService.GetAll();
            dataGridViewTrades.DataSource = list;

            dataGridViewTrades.Columns[nameof(Trade.Strategy)].Visible = false;
            dataGridViewTrades.Columns[nameof(Trade.EntryDate)].Visible = false;
            dataGridViewTrades.Columns[nameof(Trade.ExitDate)].Visible = false;
            dataGridViewTrades.Columns[nameof(Trade.RenditeDouble)].Visible = false;

            dataGridViewTrades.Columns[nameof(Trade.Id)].DisplayIndex = 0;
            dataGridViewTrades.Columns[nameof(Trade.StrategyName)].DisplayIndex = 1;
            dataGridViewTrades.Columns[nameof(Trade.NameOfIndicator)].DisplayIndex = 2;
            dataGridViewTrades.Columns[nameof(Trade.NameOfCertificate)].DisplayIndex = 3;
            dataGridViewTrades.Columns[nameof(Trade.Buy)].DisplayIndex = 4;
            dataGridViewTrades.Columns[nameof(Trade.Sell)].DisplayIndex = 5;
            dataGridViewTrades.Columns[nameof(Trade.Rendite)].DisplayIndex = 6;
            dataGridViewTrades.Columns[nameof(Trade.ThinkProcess)].DisplayIndex = 7;
            dataGridViewTrades.Columns[nameof(Trade.EntryDatetime)].DisplayIndex = 8;
            dataGridViewTrades.Columns[nameof(Trade.ExitDatetime)].DisplayIndex = 9;

            dataGridViewTrades.Columns[nameof(Trade.RenditeDouble)].DisplayIndex = 10;
            dataGridViewTrades.Columns[nameof(Trade.Strategy)].DisplayIndex = 10;
            dataGridViewTrades.Columns[nameof(Trade.EntryDate)].DisplayIndex = 10;

            dataGridViewTrades.Columns[nameof(Trade.ThinkProcess)].Width = 240;

            dataGridViewTrades.Columns[nameof(Trade.EntryDatetime)].HeaderText = "Entry";
            dataGridViewTrades.Columns[nameof(Trade.ExitDatetime)].HeaderText = "Exit";
            dataGridViewTrades.Columns[nameof(Trade.StrategyName)].HeaderText = "Strategy";
            dataGridViewTrades.Columns[nameof(Trade.NameOfIndicator)].HeaderText = "Indicator";
            dataGridViewTrades.Columns[nameof(Trade.NameOfCertificate)].HeaderText = "Certificate";
            dataGridViewTrades.Columns[nameof(Trade.StrategyName)].HeaderText = "Strategy";
            dataGridViewTrades.Columns[nameof(Trade.EntryDate)].HeaderText = "Entry";
            dataGridViewTrades.Columns[nameof(Trade.ExitDate)].HeaderText = "Exit";
            dataGridViewTrades.Columns[nameof(Trade.ThinkProcess)].HeaderText = "Reason";

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
