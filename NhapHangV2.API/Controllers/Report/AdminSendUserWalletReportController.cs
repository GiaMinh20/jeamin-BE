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
    [Route("api/report-admin-send-user-wallet")]
    [ApiController]
    [Description("Thống kê danh sách nạp tiền")]
    [Authorize]
    public class AdminSendUserWalletReportController : BaseReportController<AdminSendUserWalletReport, AdminSendUserWalletReportModel, AdminSendUserWalletReportSearch>
    {
        public AdminSendUserWalletReportController(IServiceProvider serviceProvider, ILogger<BaseReportController<AdminSendUserWalletReport, AdminSendUserWalletReportModel, AdminSendUserWalletReportSearch>> logger, IWebHostEnvironment env, IConfiguration configuration) : base(serviceProvider, logger, env, configuration)
        {
            this.domainService = serviceProvider.GetRequiredService<IAdminSendUserWalletReportService>();
        }

        protected override string GetTemplateFilePath(string fileTemplateName)
        {
            return base.GetTemplateFilePath("AdminSendUserWalletReportTemplate.xlsx");
        }

        protected override string GetReportName()
        {
            return "AdminSendUserWallet_Report";
        }
    }
}
