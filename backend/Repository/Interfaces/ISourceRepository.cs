using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockPriceMonitor.Repository.Interfaces
{
    public interface ISourceRepository: IAsyncRepository<Source>
    {
    }
}
