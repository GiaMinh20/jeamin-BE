﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities;
using jeamin.Entities.Catalogue;
using jeamin.Entities.DomainEntities;
using jeamin.Extensions;
using jeamin.Interface.Services;
using jeamin.Models;
using jeamin.Request;
using jeamin.Request.Catalogue;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace jeamin.API.Controllers
{
    [Route("api/user-level")]
    [ApiController]
    [Description("Cấu hình phí người dùng")]
    [Authorize]
    public class UserLevelController : BaseController<UserLevel, UserLevelModel, UserLevelRequest, BaseSearch>
    {
        public UserLevelController(IServiceProvider serviceProvider, ILogger<BaseController<UserLevel, UserLevelModel, UserLevelRequest, BaseSearch>> logger, IWebHostEnvironment env) : base(serviceProvider, logger, env)
        {
            this.domainService = this.serviceProvider.GetRequiredService<IUserLevelService>();
        }

        /// <summary>
        /// Cập nhật item
        /// </summary>
        /// <param name="itemModel"></param>
        /// <returns></returns>
        [HttpPut]
        [AppAuthorize(new int[] { CoreContants.Update })]
        public override async Task<AppDomainResult> UpdateItem([FromBody] UserLevelRequest itemModel)
        {
            AppDomainResult appDomainResult = new AppDomainResult();
            bool success = false;
            if (!ModelState.IsValid)
                throw new AppException(ModelState.GetErrorMessage());
            var item = mapper.Map<UserLevel>(itemModel);
            success = await this.domainService.UpdateAsync(item);
            if (!success)
                throw new Exception("Lỗi trong quá trình xử lý");
            appDomainResult.ResultCode = (int)HttpStatusCode.OK;
            appDomainResult.Data = item;
            appDomainResult.Success = success;
            return appDomainResult;
        }
    }
}
