using theatrical_players.Bill.Interfaces;

namespace theatrical_players.Bill
{
    public class TragedyServices : ITragedyServices
    {
        public decimal Calculate(int Audience)
        {
            var Plus = Audience > 30 ? Audience - 30 : 0;
            return 40000 + (Plus * 1000);
        }
    }
}
