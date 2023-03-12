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
using jeamin.Extensions;
using jeamin.Interface.Services;
using jeamin.Models;
using jeamin.Request;
using jeamin.Service.Services;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace jeamin.API.Controllers
{
    [Route("api/volume-fee")]
    [ApiController]
    [Description("Cấu hình hệ thống")]
    [Authorize]
    public class VolumeFeeController : BaseController<VolumeFee, VolumeFeeModel, VolumeFeeRequest, VolumeFeeSearch>
    {
        public VolumeFeeController(IServiceProvider serviceProvider, ILogger<BaseController<VolumeFee, VolumeFeeModel, VolumeFeeRequest, VolumeFeeSearch>> logger, IWebHostEnvironment env) : base(serviceProvider, logger, env)
        {
            this.domainService = serviceProvider.GetRequiredService<IVolumeFeeService>();
        }

        /// <summary>
        /// Lấy thông tin theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Authorize]
        [AppAuthorize(new int[] { CoreContants.View })]
        public override async Task<AppDomainResult> GetById(int id)
        {
            AppDomainResult appDomainResult = new AppDomainResult();
            var item = await this.domainService.GetDataById(id);
            if (item == null)
                throw new KeyNotFoundException("Item không tồn tại");
            return new AppDomainResult()
            {
                Success = true,
                Data = item,
                ResultCode = (int)HttpStatusCode.OK
            };
        }
    }
}
