using jeamin.Entities;
using jeamin.Extensions;
using jeamin.Interface.Services;
using jeamin.Interface.Services.Auth;
using jeamin.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using jeamin.Models;
using System.ComponentModel;
using Microsoft.AspNetCore.Authorization;
using jeamin.Request;
using jeamin.Entities.Search;
using jeamin.Entities.Auth;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities.DomainEntities;

namespace jeamin.API.Controllers
{
    [Route("api/fee-packaged")]
    [ApiController]
    [Description("Quản lý cấu hình phí đóng gỗ")]
    [Authorize]
    public class FeePackagedController : BaseController<FeePackaged, FeePackagedModel, FeePackagedRequest, BaseSearch>
    {
        public FeePackagedController(IServiceProvider serviceProvider, ILogger<BaseController<FeePackaged, FeePackagedModel, FeePackagedRequest, BaseSearch>> logger, IWebHostEnvironment env) : base(serviceProvider, logger, env)
        {
            this.domainService = serviceProvider.GetRequiredService<IFeePackagedService>();
        }
    }
}
