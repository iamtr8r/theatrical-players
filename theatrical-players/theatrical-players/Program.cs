using System;
using theatrical_players.Initial;

namespace theatrical_players
{
    public class Program
    {
        private static void Main()
        {
            WelcomeMessage();
            new InitialServices().BillNow();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Theatrical Players");
            Console.WriteLine();
        }
    }
}
