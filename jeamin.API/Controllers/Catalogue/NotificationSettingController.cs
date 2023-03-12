using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities.Catalogue;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.Catalogue;
using jeamin.Models.Catalogue;
using jeamin.Request.Catalogue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace jeamin.API.Controllers.Catalogue
{
    [Route("api/notification-setting")]
    [ApiController]
    [Description("Cấu hình thông báo")]
    [Authorize]
    public class NotificationSettingController : BaseCatalogueController<NotificationSetting, NotificationSettingModel, NotificationSettingRequest, CatalogueSearch>
    {
        public NotificationSettingController(IServiceProvider serviceProvider, ILogger<BaseCatalogueController<NotificationSetting, NotificationSettingModel, NotificationSettingRequest, CatalogueSearch>> logger, IWebHostEnvironment env) : base(serviceProvider, logger, env)
        {
            this.catalogueService = serviceProvider.GetRequiredService<INotificationSettingService>();
        }
    }
}
