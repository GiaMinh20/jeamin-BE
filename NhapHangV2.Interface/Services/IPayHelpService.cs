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
    public interface IPayHelpService : IDomainService<PayHelp, PayHelpSearch>
    {
        Task<bool> UpdateStatus(PayHelp model, int status, int statusOld);
        Task<AmountStatistic> GetTotalOrderPriceByUID(int UID);
        Task<bool> UpdateStaff(PayHelp payHelp, int oldSalerId);
    }
}
