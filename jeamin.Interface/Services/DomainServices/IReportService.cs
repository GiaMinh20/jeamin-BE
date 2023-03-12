using jeamin.Entities.DomainEntities;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services.DomainServices
{
    public interface IReportService<E, T> where E : Entities.DomainEntities.AppDomainReport where T : BaseSearch
    {
        Task<PagedList<E>> GetPagedListData(T baseSearch);
    }
}
