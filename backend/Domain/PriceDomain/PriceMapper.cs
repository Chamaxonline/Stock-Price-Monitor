using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PriceDomain
{
    public class PriceMapper :IPriceMapper
    {
        public  Task<List<Price>> AddNewRecords()
        {
            var priceList = new List<Price>();
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    var price = new Price
                    {
                        SourceId = i,
                        TickerId =j,
                        PriceTag = RandomNumberBetween(120.59, 150.59),
                        Time = RandomDateBetween(DateTime.Now.AddHours(1.15), DateTime.Now),
                        Active = true
                    };
                    priceList.Add(price);
                }
                
            }
            return Task.FromResult(priceList); 
        }

        private static readonly Random random = new Random();
        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }

        private static DateTime RandomDateBetween(DateTime endDate, DateTime startDate)
        {
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new TimeSpan(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);
            return (startDate + newSpan);
        }
    }
}
