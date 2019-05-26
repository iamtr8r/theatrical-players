using theatrical_players.Bill.Interfaces;

namespace theatrical_players.Bill
{
    public class ComedyServices : IComedyServices
    {
        public decimal Calculate(int Audience)
        {
            var Plus = Audience > 20 ? Audience - 20 : 0;
            return 30000 + (Plus * 500);
        }
    }
}
