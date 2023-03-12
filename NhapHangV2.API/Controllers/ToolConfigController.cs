using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities.DomainEntities;
using jeamin.Entities;
using jeamin.Models;
using jeamin.Request;
using System.ComponentModel;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using jeamin.Interface.Services;
using jeamin.Entities.Search;

namespace jeamin.API.Controllers
{
    [Route("api/tool-config")]
    [ApiController]
    [Description("Cấu hình công cụ")]
    [Authorize]
    public class ToolConfigController : BaseController<ToolConfig, ToolConfigModel, ToolConfigRequest, ToolConfigSearch>
    {
        public ToolConfigController(IServiceProvider serviceProvider,
            ILogger<BaseController<ToolConfig, ToolConfigModel, ToolConfigRequest, ToolConfigSearch>> logger, IWebHostEnvironment env) : base(serviceProvider, logger, env)
        {
            this.domainService = this.serviceProvider.GetRequiredService<IToolConfigService>();
        }
    }
}
