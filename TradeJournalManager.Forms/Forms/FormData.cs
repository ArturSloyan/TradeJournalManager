using TradeJournalManager.Domain.Exceptions;
using TradeJournalManager.Domain.Extensions;
using TradeJournalManager.Domain.Models;
using static TradeJournalManager.Domain.Models.Trade;

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
                labelHeader.Text = "Add trade:";
                buttonDo.Text = "Add";
            }
            else
            {
                labelHeader.Text = "Edit trade:";
                buttonDo.Text = "Edit";

                comboBoxStrategy.Text = _trade.StrategyName;
                textBoxIndicator.Text = _trade.NameOfIndicator;
                textBoxCertificate.Text = _trade.NameOfCertificate;
                textBoxBuy.Text = _trade.Buy.ToString();
                textBoxSell.Text = _trade.Sell.ToString();
                textBoxReasons.Text = _trade.ThinkProzess;

                dateTimePickerDateOfTrade.Value = DateTimeOffset.FromUnixTimeSeconds(_trade.DateOfTrade).DateTime;
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
                _trade.Sell = Convert.ToDouble(textBoxSell.Text ?? throw new TradeException(nameof(Trade.Sell), "Cant stay empty!"));
                _trade.Buy = Convert.ToDouble(textBoxBuy.Text);
                _trade.Strategy = comboBoxStrategy.Text != "SHORT";
                _trade.NameOfIndicator = textBoxIndicator.Text;
                _trade.NameOfCertificate = textBoxCertificate.Text;
                _trade.ThinkProzess = textBoxReasons.Text;
                _trade.DateOfTrade = new DateTimeOffset(dateTimePickerDateOfTrade.Value).ToUnixTimeSeconds();

                _trade
                    .IsNotNull()
                    .Validate();
            }
            catch (TradeException ex)
            {
                switch (ex.Message)
                {
                    case "NameOfIndicator":
                        SetError_Textbox(textBoxIndicator, ex.Message);
                        break;
                    case "NameOfCertificate":
                        SetError_Textbox(textBoxCertificate, ex.Message);
                        break;
                    case "Buy":
                        SetError_Textbox(textBoxBuy, ex.Message);
                        break;
                    case "Sell":
                        SetError_Textbox(textBoxSell, ex.Message);
                        break;
                    case "ThinkProzess":
                        SetError_Textbox(textBoxReasons, ex.Message);
                        break;
                    default:
                        throw new Exception("Programmers fault.");
                }
            }
            catch
            {
                throw new Exception("Unkown.");
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
