﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using jeamin.Interface.Services;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace jeamin.API.Controllers
{
    [Route("api/dash-board")]
    [ApiController]
    [Description("Dashboard")]
    public class DashboardController : ControllerBase
    {
        protected readonly ILogger<DashboardController> logger;
        protected readonly IServiceProvider serviceProvider;
        protected readonly IMapper mapper;
        protected IWebHostEnvironment env;
        private readonly IDashboardService dashboardService;
        public DashboardController(IServiceProvider serviceProvider, ILogger<DashboardController> logger, IWebHostEnvironment env)
        {
            this.logger = logger;
            this.env = env;
            dashboardService = serviceProvider.GetRequiredService<IDashboardService>();
        }

        /// <summary>
        /// Số lượng đơn hàng + tổng tiền khách nạp trong tuần
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-total-in-week")]
        public async Task<AppDomainResult> GetTotalInWeek()
        {
            var dashBoard = await this.dashboardService.GetTotalInWeek();
            return new AppDomainResult()
            {
                Data = dashBoard,
                Success = true,
                ResultCode = (int)HttpStatusCode.OK
            };
        }

        /// <summary>
        /// Đơn hàng + tiền khách nạp trong tuần (theo ngày)
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-item-in-week")]
        public async Task<AppDomainResult> GetItemInWeek()
        {
            var dashBoard = await this.dashboardService.GetItemInWeek();
            return new AppDomainResult()
            {
                Data = dashBoard,
                Success = true,
                ResultCode = (int)HttpStatusCode.OK
            };
        }


        /// <summary>
        /// tỉ lệ đơn mua hộ theo tuần
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-percent-order")]
        public async Task<AppDomainResult> GetPercentOrder()
        {
            var dashBoard = await this.dashboardService.GetPercentOrder();
            return new AppDomainResult()
            {
                Data = dashBoard,
                Success = true,
                ResultCode = (int)HttpStatusCode.OK
            };
        }

        //Dashboard_GetPerCentOrder

    }
}
