using System;
using System.Collections.Generic;
using System.Text;

namespace theatrical_players.Bill.Interfaces
{
    public interface IBillServices
    {
        string ReadCustomerName();
        List<Performance.Performance> ReadPerformances();
        decimal CalculatePrice(Bill bill);
        void ShowTotal(Bill bill, decimal total);
    }
}
