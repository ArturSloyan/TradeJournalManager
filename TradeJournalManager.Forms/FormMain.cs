namespace TradeJournalManager.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonList_Click(object sender, EventArgs e)
        {
            new FormList().ShowDialog();
        }

        private void ButtonStatistics_Click(object sender, EventArgs e)
        {
            new FormStatistics().ShowDialog();
        }
    }
}