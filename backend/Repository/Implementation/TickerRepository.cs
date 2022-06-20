using Entity.Context;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class TickerRepository : ITickerRepository
    {
        protected PriceMonitorDbContext _context;

        public TickerRepository(PriceMonitorDbContext context)
        {
            _context = context;
        }
        public async Task<Ticker> Add(Ticker entity)
        {
            await _context.Set<Ticker>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<Ticker, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Ticker> FirstOrDefault(Expression<Func<Ticker, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ticker>> GetAll()
        {
            return await _context.Set<Ticker>().Where(x => x.Active == true).ToListAsync();
        }

        public Task<Ticker> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticker>> GetWhere(Expression<Func<Ticker, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Ticker entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Ticker entity)
        {
            throw new NotImplementedException();
        }
    }
}
