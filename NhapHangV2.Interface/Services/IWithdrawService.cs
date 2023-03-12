﻿using jeamin.Entities;
using jeamin.Entities.Search;
using jeamin.Interface.Services.DomainServices;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services
{
    public interface IWithdrawService : IDomainService<Withdraw, WithdrawSearch>
    {
        Task<bool> UpdateStatus(Withdraw item, int status);
        Task<BillInfor> GetBillInforAsync(int id);
    }
}
