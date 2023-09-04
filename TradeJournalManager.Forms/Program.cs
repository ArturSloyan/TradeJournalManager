namespace TradeJournalManager.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
            // TODO: one file programm
            //       find a way to have backup of the trades, like saving in excel with serializer
            //       statistics form
            //          weekly
            //          monthly
            //          yearly
            //          alltime
            //       blazor
            //       make leaderboard view (makes sense only 2> participants- => inshallah john und ruben
        }
    }
}