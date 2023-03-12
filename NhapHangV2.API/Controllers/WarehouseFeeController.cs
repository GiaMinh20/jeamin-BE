using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Entities.Search;
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
    [Route("api/warehouse-fee")]
    [ApiController]
    [Description("Cấu hình hệ thống")]
    [Authorize]
    public class WarehouseFeeController : BaseController<WarehouseFee, WarehouseFeeModel, WarehouseFeeRequest, WarehouseFeeSearch>
    {
        public WarehouseFeeController(IServiceProvider serviceProvider, ILogger<BaseController<WarehouseFee, WarehouseFeeModel, WarehouseFeeRequest, WarehouseFeeSearch>> logger, IWebHostEnvironment env) : base(serviceProvider, logger, env)
        {
            this.domainService = this.serviceProvider.GetRequiredService<IWarehouseFeeService>();
        }
    }
}
