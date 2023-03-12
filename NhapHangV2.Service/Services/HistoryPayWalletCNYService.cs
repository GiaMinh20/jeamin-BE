using AutoMapper;
using Microsoft.Data.SqlClient;
using jeamin.Entities;
using jeamin.Entities.Search;
using jeamin.Interface.Services;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.Services
{
    public class HistoryPayWalletCNYService : DomainService<HistoryPayWalletCNY, HistoryPayWalletCNYSearch>, IHistoryPayWalletCNYService
    {
        public HistoryPayWalletCNYService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override string GetStoreProcName()
        {
            return "HistoryPayWalletCNY_GetPagingData";
        }
    }
}
