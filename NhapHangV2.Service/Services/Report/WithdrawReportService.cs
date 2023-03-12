﻿using AutoMapper;
using jeamin.Entities.Report;
using jeamin.Entities.Search.Report;
using jeamin.Interface.DbContext;
using jeamin.Interface.Services.Report;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.Services.Report
{
    public class WithdrawReportService : ReportService<WithdrawReport, WithdrawReportSearch>, IWithdrawReportService
    {
        public WithdrawReportService(IAppUnitOfWork unitOfWork, IMapper mapper, IAppDbContext context) : base(unitOfWork, mapper, context)
        {
        }

        protected override string GetStoreProcName()
        {
            return "Report_Withdraw";
        }
    }
}
