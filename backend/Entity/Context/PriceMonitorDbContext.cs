using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entity.Context
{
    public class PriceMonitorDbContext : DbContext
    {
        public PriceMonitorDbContext(DbContextOptions<PriceMonitorDbContext> options) : base(options)
        { }

        public DbSet<Source> Source { get; set; }
        public DbSet<Ticker> Ticker { get; set; }
        public DbSet<Price> Price { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Source>().HasData(
          new Source { Id = 1, SourceName = "SRC1", Active = true },
          new Source { Id = 2, SourceName = "SRC2", Active = true },
          new Source { Id = 3, SourceName = "TBK1", Active = true });

            modelBuilder.Entity<Ticker>().HasData(
               new Ticker { Id = 1, Name = "IBM UN", Active = true },
               new Ticker { Id = 2, Name = "IDM UK", Active = true },
               new Ticker { Id = 3, Name = "NIPM DA", Active = true });

            modelBuilder.Entity<Price>().HasData(
                new Price { Id = 1, SourceId = 1, TickerId = 1, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-1.15)), Active = true },
                new Price { Id = 2, SourceId = 1, TickerId = 2, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-2.15)), Active = true },
                new Price { Id = 3, SourceId = 1, TickerId = 3, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-3.15)), Active = true },
                new Price { Id = 4, SourceId = 2, TickerId = 1, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-4.15)), Active = true },
                new Price { Id = 5, SourceId = 2, TickerId = 2, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-5.15)), Active = true },
                new Price { Id = 6, SourceId = 2, TickerId = 3, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 7, SourceId = 3, TickerId = 1, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },
                new Price { Id = 8, SourceId = 3, TickerId = 2, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-1.15)), Active = true },
                new Price { Id = 9, SourceId = 3, TickerId = 3, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-2.15)), Active = true },

                new Price { Id = 10, SourceId = 1, TickerId = 1, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-3.15)), Active = true },
                new Price { Id = 11, SourceId = 1, TickerId = 2, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-4.15)), Active = true },
                new Price { Id = 12, SourceId = 1, TickerId = 3, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-5.15)), Active = true },
                new Price { Id = 13, SourceId = 2, TickerId = 1, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 14, SourceId = 2, TickerId = 2, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },
                new Price { Id = 15, SourceId = 2, TickerId = 3, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 16, SourceId = 3, TickerId = 1, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },
                new Price { Id = 17, SourceId = 3, TickerId = 2, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 18, SourceId = 3, TickerId = 3, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },


                new Price { Id = 19, SourceId = 1, TickerId = 1, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-1.15)), Active = true },
                new Price { Id = 20, SourceId = 1, TickerId = 2, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-2.15)), Active = true },
                new Price { Id = 21, SourceId = 1, TickerId = 3, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-3.15)), Active = true },
                new Price { Id = 22, SourceId = 2, TickerId = 1, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-4.15)), Active = true },
                new Price { Id = 23, SourceId = 2, TickerId = 2, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-5.15)), Active = true },
                new Price { Id = 24, SourceId = 2, TickerId = 3, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 25, SourceId = 3, TickerId = 1, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },
                new Price { Id = 26, SourceId = 3, TickerId = 2, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-1.15)), Active = true },
                new Price { Id = 27, SourceId = 3, TickerId = 3, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-2.15)), Active = true },

                new Price { Id = 28, SourceId = 1, TickerId = 1, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-3.15)), Active = true },
                new Price { Id = 29, SourceId = 1, TickerId = 2, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-4.15)), Active = true },
                new Price { Id = 30, SourceId = 1, TickerId = 3, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-5.15)), Active = true },
                new Price { Id = 31, SourceId = 2, TickerId = 1, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 32, SourceId = 2, TickerId = 2, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },
                new Price { Id = 33, SourceId = 2, TickerId = 3, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 34, SourceId = 3, TickerId = 1, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },
                new Price { Id = 35, SourceId = 3, TickerId = 2, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 36, SourceId = 3, TickerId = 3, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },

                new Price { Id = 37, SourceId = 1, TickerId = 1, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-1.15)), Active = true },
                new Price { Id = 38, SourceId = 1, TickerId = 2, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-2.15)), Active = true },
                new Price { Id = 39, SourceId = 1, TickerId = 3, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-3.15)), Active = true },
                new Price { Id = 40, SourceId = 2, TickerId = 1, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-4.15)), Active = true },
                new Price { Id = 41, SourceId = 2, TickerId = 2, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-5.15)), Active = true },
                new Price { Id = 42, SourceId = 2, TickerId = 3, PriceTag = RandomNumberBetween(130.59, 150.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 43, SourceId = 3, TickerId = 1, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },
                new Price { Id = 44, SourceId = 3, TickerId = 2, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-1.15)), Active = true },
                new Price { Id = 45, SourceId = 3, TickerId = 3, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-2.15)), Active = true },

                new Price { Id = 46, SourceId = 1, TickerId = 1, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-3.15)), Active = true },
                new Price { Id = 47, SourceId = 1, TickerId = 2, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-4.15)), Active = true },
                new Price { Id = 48, SourceId = 1, TickerId = 3, PriceTag = RandomNumberBetween(140.59, 160.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-5.15)), Active = true },
                new Price { Id = 49, SourceId = 2, TickerId = 1, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 50, SourceId = 2, TickerId = 2, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },
                new Price { Id = 51, SourceId = 2, TickerId = 3, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 52, SourceId = 3, TickerId = 1, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true },
                new Price { Id = 53, SourceId = 3, TickerId = 2, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-6.15)), Active = true },
                new Price { Id = 54, SourceId = 3, TickerId = 3, PriceTag = RandomNumberBetween(150.59, 170.59), Time = RandomDateBetween(DateTime.Now, DateTime.Now.AddHours(-7.15)), Active = true }

                );
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
