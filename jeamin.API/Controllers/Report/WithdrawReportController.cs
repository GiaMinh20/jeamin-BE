using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities.Report;
using jeamin.Entities.Search.Report;
using jeamin.Interface.Services.Report;
using jeamin.Models.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace jeamin.API.Controllers.Report
{
    [Route("api/report-withdraw")]
    [ApiController]
    [Description("Thống kê danh sách rút tiền")]
    [Authorize]
    public class WithdrawReportController : BaseReportController<WithdrawReport, WithdrawReportModel, WithdrawReportSearch>
    {
        public WithdrawReportController(IServiceProvider serviceProvider, ILogger<BaseReportController<WithdrawReport, WithdrawReportModel, WithdrawReportSearch>> logger, IWebHostEnvironment env, IConfiguration configuration) : base(serviceProvider, logger, env, configuration)
        {
            this.domainService = serviceProvider.GetRequiredService<IWithdrawReportService>();
        }

        protected override string GetTemplateFilePath(string fileTemplateName)
        {
            return base.GetTemplateFilePath("WithdrawReportTemplate.xlsx");
        }

        protected override string GetReportName()
        {
            return "Withdraw_Report";
        }
    }
}
