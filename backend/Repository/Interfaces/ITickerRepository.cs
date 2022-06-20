using Entity.Models;
using StockPriceMonitor.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface ITickerRepository: IAsyncRepository<Ticker>
    {
    }
}
