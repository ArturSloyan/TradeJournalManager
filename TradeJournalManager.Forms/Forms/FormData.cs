using TradeJournalManager.Domain.Exceptions;
using TradeJournalManager.Domain.Extensions;
using TradeJournalManager.Domain.Models;

namespace TradeJournalManager.Forms.Forms
{
    public partial class FormData : Form
    {
        private readonly Trade _trade;
        public FormData(Trade trade)
        {
            InitializeComponent();

            _trade = trade;
        }

        private void FormData_Load(object sender, EventArgs e)
        {
            comboBoxStrategy.DataSource = Enum.GetValues(typeof(StrategyEnum));
            if (_trade.Id == 0)
            {
                labelHeader.Text = "Add Trade:";
                buttonDo.Text = "Add";
            }
            else
            {
                labelHeader.Text = "Edit Trade:";
                buttonDo.Text = "Edit";

                comboBoxStrategy.Text = _trade.StrategyName;
                textBoxIndicator.Text = _trade.NameOfIndicator;
                textBoxCertificate.Text = _trade.NameOfCertificate;
                textBoxBuy.Text = _trade.Buy.ToString();
                textBoxSell.Text = _trade.Sell.ToString();
                textBoxReasons.Text = _trade.ThinkProcess;
                checkBoxIsClosed.Checked = _trade.IsClosed;

                dateTimePickerEntryDate.Value = DateTimeOffset.FromUnixTimeSeconds(_trade.EntryDate).DateTime;
            }
        }

        private void ButtonDo_Click(object sender, EventArgs e)
        {
            ClearError_Textbox(textBoxIndicator);
            ClearError_Textbox(textBoxCertificate);
            ClearError_Textbox(textBoxBuy);
            ClearError_Textbox(textBoxSell);
            ClearError_Textbox(textBoxReasons);

            try
            {
                long entryDate = 0, exitDate = 0;
                if (double.TryParse(textBoxSell.Text, out double sell))
                {
                    _trade.Sell = sell;
                }
                else
                {
                    _trade.Sell = 0;
                }

                _trade.Buy = double.Parse(textBoxBuy.Text);
                _trade.Strategy = comboBoxStrategy.Text != "SHORT";
                _trade.NameOfIndicator = textBoxIndicator.Text;
                _trade.NameOfCertificate = textBoxCertificate.Text;
                _trade.ThinkProcess = textBoxReasons.Text;
                entryDate = new DateTimeOffset(dateTimePickerEntryDate.Value).ToUnixTimeSeconds();
                exitDate = new DateTimeOffset(dateTimePickerExitDate.Value).ToUnixTimeSeconds();
                _trade.IsClosed = checkBoxIsClosed.Checked;

                if (entryDate > exitDate)
                {
                    throw new Exception($"Entry can´t be earlier than entry.");
                }


                _trade.EntryDate = entryDate;
                _trade.ExitDate = exitDate;

                _trade
                    .IsNotNull()
                    .Validate();
            }
            catch (TradeException ex)
            {
                switch (ex.Accessor)
                {
                    case nameof(Trade.NameOfIndicator):
                        SetError_Textbox(textBoxIndicator, ex.Message);
                        break;
                    case nameof(Trade.NameOfCertificate):
                        SetError_Textbox(textBoxCertificate, ex.Message);
                        break;
                    case nameof(Trade.Buy):
                        SetError_Textbox(textBoxBuy, ex.Message);
                        break;
                    case nameof(Trade.Sell):
                        SetError_Textbox(textBoxSell, ex.Message);
                        break;
                    case nameof(Trade.ThinkProcess):
                        SetError_Textbox(textBoxReasons, ex.Message);
                        break;
                    default:
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;

            Close();
        }

        private void ClearError_Textbox(TextBox textBox)
        {
            errorProvider.Clear();
            textBox.BackColor = Color.White;
        }

        private void SetError_Textbox(TextBox textBox, string message)
        {
            errorProvider.SetError(textBox, message);
            textBox.BackColor = Color.Red;
            textBox.SelectAll();
            textBox.Focus();
        }
    }
}
