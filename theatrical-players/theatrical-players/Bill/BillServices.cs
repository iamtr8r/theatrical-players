using System;
using System.Collections.Generic;
using theatrical_players.Bill.Interfaces;

namespace theatrical_players.Bill
{
    public class BillServices : IBillServices
    {
        private readonly IComedyServices _comedyServices;
        private readonly ITragedyServices _tragedyServices;

        public BillServices(
            IComedyServices comedyServices,
            ITragedyServices tragedyServices
        )
        {
            _comedyServices = comedyServices;
            _tragedyServices = tragedyServices;
        }        

        public string ReadCustomerName()
        {
            Console.WriteLine("Customer Name:");
            var CustomerName = Console.ReadLine().ToString();
            return CustomerName;
        }

        public List<Performance.Performance> ReadPerformances()
        {
            var PerformanceList = new List<Performance.Performance>();

            Console.WriteLine("Do you want to add a Play? (Y/N)");
            var Answer = Console.ReadLine().ToString();

            while (Answer.ToUpper() == "Y")
            {
                Console.WriteLine("Play:");
                var Play = Console.ReadLine().ToString();

                Console.WriteLine("Audience:");
                var Audience = Convert.ToInt32(Console.ReadLine());

                PerformanceList.Add(new Performance.Performance(Play, Audience));
            }
            return PerformanceList;
        }

        public decimal CalculatePrice(Bill bill)
        {
            decimal Total = 0;
            foreach (var Performance in bill.Performances)
            {
                //TODO: ver qual é o tipo da Performance e calcular total de acordo
                // sem usar if????
                if (Performance.Play.Type == "tragedy")
                {
                    Total += _tragedyServices.Calculate(Performance.Audience);
                }
                else
                {
                    Total += _comedyServices.Calculate(Performance.Audience);
                }                
                
            }
            return Total;
        }

        public void ShowTotal(Bill bill, decimal total)
        {
            Console.WriteLine();
            Console.WriteLine($"Customer: {bill.CustomerName}, Total: {total.ToString()}");
            Console.ReadKey();
        }
    }
}
