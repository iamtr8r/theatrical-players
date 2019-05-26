using System;
using System.Collections.Generic;
using theatrical_players.Bill.Interfaces;

namespace theatrical_players.Bill
{
    public class BillServices : IBillServices
    {
        private readonly ComedyServices _comedyServices = new ComedyServices();
        private readonly TragedyServices _tragedyServices = new TragedyServices();
        private readonly PlayServices _playServices = new PlayServices();

        public string ReadCustomerName()
        {
            Console.WriteLine("Customer Name:");
            var CustomerName = Console.ReadLine().ToString();
            return CustomerName;
        }

        public string ReadAddAPlay()
        {
            Console.WriteLine("Do you want to add a Play? (Y/N)");
            var Answer = Console.ReadLine().ToUpper().ToString();
            return Answer;
        }

        public string ReadPlay()
        {
            Console.WriteLine("Play:");
            var Play = Console.ReadLine().ToString();
            return Play;
        }

        public int ReadAudience()
        {
            Console.WriteLine("Audience:");
            var Audience = Convert.ToInt32(Console.ReadLine());
            return Audience;
        }

        public List<Performance.Performance> ReadPerformances()
        {
            var PerformanceList = new List<Performance.Performance>();
            while (ReadAddAPlay() == "Y")
            {
                PerformanceList.Add(new Performance.Performance(ReadPlay(), ReadAudience()));
            }
            return PerformanceList;
        }

        public decimal CalculatePrice(Bill bill)
        {
            decimal Total = 0;
            foreach (var Performance in bill.Performances)
            {
                if (_playServices.GetItem(Performance.PlayId).Type == "tragedy")
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
