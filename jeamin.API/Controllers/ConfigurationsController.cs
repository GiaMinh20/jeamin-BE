﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities;
using jeamin.Entities.DomainEntities;
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
    [Route("api/configuration")]
    [ApiController]
    [Description("Cấu hình hệ thống")]
    [Authorize]
    public class ConfigurationsController : BaseController<Configurations, ConfigurationsModel, ConfigurationsRequest, BaseSearch>
    {
        protected readonly IConfiguration configuration;
        protected readonly IConfigurationsService configurationsService;
        protected readonly IHubContext<DomainHub, IDomainHub> hubContext;
        public ConfigurationsController(IServiceProvider serviceProvider, ILogger<BaseController<Configurations, ConfigurationsModel, ConfigurationsRequest, BaseSearch>> logger, IWebHostEnvironment env, IConfiguration configuration, IHubContext<DomainHub, IDomainHub> hubContext) : base(serviceProvider, logger, env)
        {
            this.configuration = configuration;
            configurationsService = serviceProvider.GetRequiredService<IConfigurationsService>(); ;
            this.hubContext = hubContext;
            this.domainService = this.serviceProvider.GetRequiredService<IConfigurationsService>();
        }

        /// <summary>
        /// Lấy tỷ giá thanh toán hộ theo cấu hình
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-currency")]
        [AppAuthorize(new int[] { CoreContants.View })]
        public async Task<AppDomainResult> GetCurrency()
        {
            var configurations = await this.domainService.GetAllAsync();
            decimal? currency = 0;
            if (configurations.FirstOrDefault() != null)
                currency = configurations.FirstOrDefault().Currency;
            return new AppDomainResult()
            {
                Data = currency,
                Success = true,
                ResultCode = (int)HttpStatusCode.OK
            };
        }

        /// <summary>
        /// Lấy tỷ giá mua hộ
        /// </summary>
        /// <returns></returns>
        [HttpGet("currency")]
        [AppAuthorize(new int[] { CoreContants.View })]
        public async Task<AppDomainResult> GetCurrencyHeplBuy()
        {
            int UID = LoginContext.Instance.CurrentUser.UserId;
            var currency = await configurationsService.GetCurrency(UID);
            return new AppDomainResult()
            {
                Data = currency,
                Success = true,
                ResultCode = (int)HttpStatusCode.OK
            };
        }

        /// <summary>
        /// Thêm mới item
        /// </summary>
        /// <param name="itemModel"></param>
        /// <returns></returns>
        [HttpPost]
        [AppAuthorize(new int[] { CoreContants.AddNew })]
        public override async Task<AppDomainResult> AddItem([FromBody] ConfigurationsRequest itemModel)
        {
            AppDomainResult appDomainResult = new AppDomainResult();
            bool success = false;
            if (ModelState.IsValid)
            {
                var item = mapper.Map<Configurations>(itemModel);
                if (item != null)
                {
                    // Kiểm tra item có tồn tại chưa?
                    var messageUserCheck = await this.domainService.GetExistItemMessage(item);
                    if (!string.IsNullOrEmpty(messageUserCheck))
                        throw new KeyNotFoundException(messageUserCheck);
                    
                    success = await this.domainService.CreateAsync(item);
                    if (success)
                    {
                        appDomainResult.ResultCode = (int)HttpStatusCode.OK;
                    }
                    
                    appDomainResult.Success = success;
                }
                else
                    throw new KeyNotFoundException("Item không tồn tại");
            }
            else
            {
                throw new AppException(ModelState.GetErrorMessage());
            }
            return appDomainResult;
        }

        /// <summary>
        /// Cập nhật thông tin item
        /// </summary>
        /// <param name="itemModel"></param>
        /// <returns></returns>
        [HttpPut]
        [AppAuthorize(new int[] { CoreContants.Update })]
        public override async Task<AppDomainResult> UpdateItem([FromBody] ConfigurationsRequest itemModel)
        {
            AppDomainResult appDomainResult = new AppDomainResult();
            bool success = false;
            if (ModelState.IsValid)
            {
                var item = mapper.Map<Configurations>(itemModel);
                if (item != null)
                {
                    // Kiểm tra item có tồn tại chưa?
                    var messageUserCheck = await this.domainService.GetExistItemMessage(item);
                    if (!string.IsNullOrEmpty(messageUserCheck))
                        throw new KeyNotFoundException(messageUserCheck);
                    
                    success = await this.domainService.UpdateAsync(item);
                    if (success)
                    {
                        appDomainResult.ResultCode = (int)HttpStatusCode.OK;
                    }
                    
                    appDomainResult.Success = success;
                    await hubContext.Clients.All.ChangeTemp(true);
                }
                else
                    throw new KeyNotFoundException("Item không tồn tại");
            }
            else
                throw new AppException(ModelState.GetErrorMessage());

            return appDomainResult;
        }

    }
}
