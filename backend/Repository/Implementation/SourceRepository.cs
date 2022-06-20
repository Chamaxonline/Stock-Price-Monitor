using Entity.Context;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using StockPriceMonitor.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockPriceMonitor.Repository.Implementation
{
    public class SourceRepository : ISourceRepository
    {
        protected PriceMonitorDbContext _context;

        public SourceRepository(PriceMonitorDbContext context)
        {
            _context = context;
        }
        public async Task<Source> Add(Source entity)
        {
            await _context.Set<Source>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<Source, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Source> FirstOrDefault(Expression<Func<Source, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Source>> GetAll()
        {
            return await _context.Set<Source>().Where(x=> x.Active == true).ToListAsync();
        }

        public Task<Source> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Source>> GetWhere(Expression<Func<Source, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Source entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Source entity)
        {
            throw new NotImplementedException();
        }
    }
}
