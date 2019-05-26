using System.Collections.Generic;

namespace theatrical_players.Bill
{
    public class Bill
    {
        public string CustomerName { get; set; }
        public List<Performance.Performance> Performances { get; set; }
    }
}
