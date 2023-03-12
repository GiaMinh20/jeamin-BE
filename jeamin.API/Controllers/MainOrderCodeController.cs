using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities;
using jeamin.Entities.Search;
using jeamin.Extensions;
using jeamin.Interface.Services;
using jeamin.Models;
using jeamin.Request;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace jeamin.API.Controllers
{
    [Route("api/main-order-code")]
    [Description("Quản lý mã đơn hàng")]
    [ApiController]
    [Authorize]
    public class MainOrderCodeController : BaseController<MainOrderCode, MainOrderCodeModel, MainOrderCodeRequest, MainOrderCodeSearch>
    {
        protected readonly IMainOrderCodeService mainOrderCodeService;
        public MainOrderCodeController(IServiceProvider serviceProvider, ILogger<BaseController<MainOrderCode, MainOrderCodeModel, MainOrderCodeRequest, MainOrderCodeSearch>> logger, IWebHostEnvironment env) : base(serviceProvider, logger, env)
        {
            this.domainService = this.serviceProvider.GetRequiredService<IMainOrderCodeService>();
            mainOrderCodeService = serviceProvider.GetRequiredService<IMainOrderCodeService>();
        }
    }
}
