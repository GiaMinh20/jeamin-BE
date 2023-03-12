using jeamin.Entities;
using jeamin.Entities.Search;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services
{
    public interface IExportRequestTurnService : IDomainService<ExportRequestTurn, ExportRequestTurnSearch>
    {
        Task<bool> Export(int id, List<int> smallPackageIds, bool isRequest);

        Task<bool> UpdateStatus(int id, int status, bool isPaymentWallet);
    }
}
