﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NhapHangV2.Entities;
using NhapHangV2.Entities.Search;
using NhapHangV2.Extensions;
using NhapHangV2.Interface.Services;
using NhapHangV2.Interface.Services.Catalogue;
using NhapHangV2.Interface.Services.Configuration;
using NhapHangV2.Models;
using NhapHangV2.Request;
using NhapHangV2.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

namespace NhapHangV2.API.Controllers
{
    [Route("api/contact-us")]
    [ApiController]
    [Description("Liên hệ với chúng tôi")]
    public class ContactUsController : ControllerBase
    {
        protected IMapper mapper;
        protected readonly IContactUsService contactUsService;
        protected readonly INotificationSettingService notificationSettingService;
        protected readonly INotificationTemplateService notificationTemplateService;
        protected readonly ISendNotificationService sendNotificationService;
        public ContactUsController(IServiceProvider serviceProvider, IMapper mapper)
        {
            notificationSettingService = serviceProvider.GetRequiredService<INotificationSettingService>();
            notificationTemplateService = serviceProvider.GetRequiredService<INotificationTemplateService>();
            sendNotificationService = serviceProvider.GetRequiredService<ISendNotificationService>();
            contactUsService = serviceProvider.GetRequiredService<IContactUsService>();
            this.mapper = mapper;
        }
        /// <summary>
        /// Thêm mới item
        /// </summary>
        /// <param name="itemModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<AppDomainResult> AddItem([FromBody] ContactUsRequest itemModel)
        {
            AppDomainResult appDomainResult = new AppDomainResult();
            bool success = false;
            if (ModelState.IsValid)
            {
                var item = mapper.Map<ContactUs>(itemModel);
                success = await contactUsService.CreateAsync(item);
                if (success)
                {
                    var notificationSetting = await notificationSettingService.GetByIdAsync(21);
                    var notiTemplateUser = await notificationTemplateService.GetByIdAsync(30);
                    await sendNotificationService.SendNotification(notificationSetting, notiTemplateUser, null, string.Format(CoreContants.New_Contact_Admin), String.Empty,
                        null, string.Empty, string.Empty);
                    appDomainResult.ResultCode = (int)HttpStatusCode.OK;
                    appDomainResult.Data = item;
                }
                appDomainResult.Success = success;
            }
            else
                throw new AppException(ModelState.GetErrorMessage());
            return appDomainResult;
        }

        /// <summary>
        /// Thêm mới item
        /// </summary>
        /// <param name="itemModels"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize]
        public async Task<AppDomainResult> Updatetem([FromBody] List<ContactUsRequest> itemModels)
        {
            AppDomainResult appDomainResult = new AppDomainResult();
            bool success = false;
            if (ModelState.IsValid)
            {
                var items = mapper.Map<List<ContactUs>>(itemModels);
                success = await contactUsService.UpdateListContactUs(items);
                if (success)
                {
                    appDomainResult.ResultCode = (int)HttpStatusCode.OK;
                    appDomainResult.Data = items;
                }
                appDomainResult.Success = success;
            }
            else
                throw new AppException(ModelState.GetErrorMessage());
            return appDomainResult;
        }
        /// <summary>
        /// Lấy danh sách item phân trang
        /// </summary>
        /// <param name="baseSearch"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [AppAuthorize(new int[] { CoreContants.ViewAll })]
        public async Task<AppDomainResult> Get([FromQuery] ContactUsSearch baseSearch)
        {
            AppDomainResult appDomainResult = new AppDomainResult();

            if (ModelState.IsValid)
            {
                PagedList<ContactUs> pagedData = await contactUsService.GetPagedListData(baseSearch);
                PagedList<ContactUsModel> pagedDataModel = mapper.Map<PagedList<ContactUsModel>>(pagedData);
                appDomainResult = new AppDomainResult
                {
                    Data = pagedDataModel,
                    Success = true,
                    ResultCode = (int)HttpStatusCode.OK
                };
            }
            else
                throw new AppException(ModelState.GetErrorMessage());
            return appDomainResult;
        }
    }
}
