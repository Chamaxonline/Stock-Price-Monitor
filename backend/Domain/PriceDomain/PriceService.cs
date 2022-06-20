using Entity.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PriceDomain
{
    public class PriceService :IPriceService
    {
        private readonly IPriceRepository _priceRepository;
        public PriceService(IPriceRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

        public async Task<Price> Add(Price price)
        {
            return await _priceRepository.Add(price);
        }

        public async Task<IEnumerable<Price>> GetAll()
        {
            return await _priceRepository.GetAll();
        }

        public async Task<IEnumerable<Price>> LatestPriceList(int sourceId, int tickerId)
        {
            return await _priceRepository.LatestPriceList(sourceId,tickerId);
        }
    }
}
