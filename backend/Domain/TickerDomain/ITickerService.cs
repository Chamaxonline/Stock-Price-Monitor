using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TickerDomain
{
    public interface ITickerService
    {
        Task<Ticker> Add(Ticker ticker);
        Task<IEnumerable<Ticker>> GetAll();
    }
}
