using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SourceDomain
{
    public interface ISourceService
    {
        Task<IEnumerable<Source>> GetAll();
        Task<Source> Add(Source source);
    }
}
