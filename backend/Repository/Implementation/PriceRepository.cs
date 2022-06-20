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
    public class PriceRepository : IPriceRepository
    {
        protected PriceMonitorDbContext _context;

        public PriceRepository(PriceMonitorDbContext context)
        {
            _context = context;
        }
        public async Task<Price> Add(Price entity)
        {
            await _context.Set<Price>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task<int> CountAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountWhere(Expression<Func<Price, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Price> FirstOrDefault(Expression<Func<Price, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Price>> GetAll()
        {
            return await _context.Set<Price>().Where(x => x.Active == true).ToListAsync();
        }

        public Task<Price> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Price>> GetWhere(Expression<Func<Price, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Price entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Price entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Price>> LatestPriceList(int sourceId, int tickerId)
        {   // here it takes only the latest five records
            var results = await _context.Set<Price>().Where(x => x.SourceId == sourceId && x.TickerId == tickerId && x.Active == true).OrderByDescending(x => x.Time).ToListAsync();
            return results.Take(5);

        }
    }
}
