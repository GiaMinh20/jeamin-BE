using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services;
using jeamin.Models;
using jeamin.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace jeamin.API.Controllers
{
    [Route("api/fee-support")]
    [ApiController]
    [Description("Quản lý phụ phí")]
    [Authorize]
    public class FeeSupportController : BaseController<FeeSupport, FeeSupportModel, FeeSupportRequest, BaseSearch>
    {
        public FeeSupportController(IServiceProvider serviceProvider, ILogger<BaseController<FeeSupport, FeeSupportModel, FeeSupportRequest, BaseSearch>> logger, IWebHostEnvironment env) : base(serviceProvider, logger, env)
        {
            this.domainService = serviceProvider.GetRequiredService<IFeeSupportService>();
        }
    }
}
