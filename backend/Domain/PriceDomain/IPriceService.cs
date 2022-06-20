using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PriceDomain
{
    public interface IPriceService
    {
        Task<Price> Add(Price price);
        Task<IEnumerable<Price>> GetAll();
        Task<IEnumerable<Price>> LatestPriceList(int sourceId, int tickerId);
    }
}
