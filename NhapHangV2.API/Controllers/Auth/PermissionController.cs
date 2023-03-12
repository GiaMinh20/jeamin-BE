using jeamin.Entities.DomainEntities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeamin.Models.Auth;
using jeamin.Interface.Services.Auth;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel;
using jeamin.BaseAPI.Controllers;
using jeamin.Request.Auth;
using jeamin.Entities.Auth;

namespace jeamin.API.Controllers.Auth
{
    [Route("api/permission")]
    [ApiController]
    [Description("Quyền người dùng")]
    [Authorize]
    public class PermissionController : BaseCatalogueController<Permissions, PermissionModel, PermissionRequest, CatalogueSearch>
    {
        protected PermissionController(IServiceProvider serviceProvider, ILogger<BaseController<Permissions, PermissionModel, PermissionRequest, CatalogueSearch>> logger, IWebHostEnvironment env) : base(serviceProvider, logger, env)
        {
            this.catalogueService = serviceProvider.GetRequiredService<IPermissionService>();
        }
    }
}
