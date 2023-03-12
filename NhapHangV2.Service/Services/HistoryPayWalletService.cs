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
    public class HistoryPayWalletService : DomainService<HistoryPayWallet, HistoryPayWalletSearch>, IHistoryPayWalletService
    {
        public HistoryPayWalletService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        //public async Task<bool> CreateHistory(int type, int tradeType, int uID, int mainOrderID, int amount, int moneyLeft)
        //{
        //    HistoryPayWallet historyPayWallet = new HistoryPayWallet();
        //    historyPayWallet = new HistoryPayWallet();
        //}

        protected override string GetStoreProcName()
        {
            return "HistoryPayWallet_GetPagingData";
        }
    }
}
