using Entity.Models;
using StockPriceMonitor.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SourceDomain
{
    public class SourceService : ISourceService
    {
        readonly ISourceRepository _sourceRepository;
        public SourceService(ISourceRepository sourceRepository)
        {
            _sourceRepository = sourceRepository;
        }

        public async Task<Source> Add(Source source)
        {
            return await _sourceRepository.Add(source);
        }

        public async Task<IEnumerable<Source>> GetAll()
        {
            return await _sourceRepository.GetAll();
        }
    }
}
