using Entity.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TickerDomain
{
    public class TickerService : ITickerService 
    {
        private readonly ITickerRepository _tickerRepository;
        public TickerService(ITickerRepository tickerRepository)
        {
            _tickerRepository = tickerRepository;
        }

        public async Task<Ticker> Add(Ticker ticker)
        {
            return await _tickerRepository.Add(ticker);
        }

        public async Task<IEnumerable<Ticker>> GetAll()
        {
            return await _tickerRepository.GetAll();
        }
    }
}
