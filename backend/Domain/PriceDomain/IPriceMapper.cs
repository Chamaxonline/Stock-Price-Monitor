using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PriceDomain
{
    public interface IPriceMapper
    {
        Task<List<Price>> AddNewRecords();
    }
}
