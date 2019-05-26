using System.Collections.Generic;

namespace theatrical_players.Bill.Interfaces
{
    public interface IBillServices
    {
        string ReadCustomerName();
        string ReadAddAPlay();
        string ReadPlay();
        int ReadAudience();
        List<Performance.Performance> ReadPerformances();
        decimal CalculatePrice(Bill bill);
        void ShowTotal(Bill bill, decimal total);
    }
}
