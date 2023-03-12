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
    [Route("api/report-main-order-real")]
    [ApiController]
    [Description("Thống kê tiền mua thật")]
    [Authorize]
    public class MainOrderRealReportController : BaseReportController<MainOrderRealReport, MainOrderRealReportModel, MainOrderRealReportSearch>
    {
        public MainOrderRealReportController(IServiceProvider serviceProvider, ILogger<BaseReportController<MainOrderRealReport, MainOrderRealReportModel, MainOrderRealReportSearch>> logger, IWebHostEnvironment env, IConfiguration configuration) : base(serviceProvider, logger, env, configuration)
        {
            this.domainService = serviceProvider.GetRequiredService<IMainOrderRealReportService>();
        }

        protected override string GetTemplateFilePath(string fileTemplateName)
        {
            return base.GetTemplateFilePath("MainOrderRealReportTemplate.xlsx");
        }

        protected override string GetReportName()
        {
            return "MainOrderReal_Report";
        }
    }
}
