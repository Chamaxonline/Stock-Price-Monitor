using Entity.Models;
using StockPriceMonitor.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IPriceRepository: IAsyncRepository<Price>
    {
        Task<IEnumerable<Price>> LatestPriceList(int sourceId, int tickerId);
    }
}
