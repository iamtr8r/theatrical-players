using System;
using System.Collections.Generic;
using System.Text;
using theatrical_players.Bill.Interfaces;
using theatrical_players.Initial.Interfaces;

namespace theatrical_players.Initial
{
    public class InitialServices: IInitialServices
    {
        private readonly IBillServices _billServices;

        public InitialServices(
            IBillServices billServices
            )
        {
            _billServices = billServices;
        }

        public void BillNow()
        {
            var BillObject = new Bill.Bill()
            {
                CustomerName = _billServices.ReadCustomerName(),
                Performances = _billServices.ReadPerformances()
            };
            var TotalPrice = _billServices.CalculatePrice(BillObject);

            _billServices.ShowTotal(BillObject, TotalPrice);
        }
    }
}
