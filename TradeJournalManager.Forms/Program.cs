using TradeJournalManager.Core;

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
            //https://www.youtube.com/watch?v=7TpljNN0IvA&ab_channel=rorymulcahey

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());

            // TODO:
            //       technische- und userdokumentation
            //       kommentieren
            //       statistics form
            //          weekly
            //          monthly
            //          yearly
            //          alltime
            //       angular
            //       make leaderboard view (makes sense only 2> participants
        }
    }
}