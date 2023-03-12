using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Entities.Search;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services
{
    public interface IRefundService : IDomainService<Refund, RefundSearch>
    {
        Task<bool> UpdateStatus(Refund item, int status);
    }
}
