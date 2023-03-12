using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jeamin.Entities.Search;

namespace jeamin.Interface.Services
{
    public interface IOutStockSessionService : IDomainService<OutStockSession, OutStockSessionSearch>
    {
        Task<bool> Export(int id);

        Task<bool> UpdateStatus(int id, int status, bool isPaymentWallet);

        Task<bool> DeleteNotPayment(OutStockSession item);
    }
}
