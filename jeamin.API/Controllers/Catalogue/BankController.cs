using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using jeamin.BaseAPI.Controllers;
using jeamin.Entities.Catalogue;
using jeamin.Entities.DomainEntities;
using jeamin.Extensions;
using jeamin.Interface.Services.Catalogue;
using jeamin.Models.Catalogue;
using jeamin.Request.Catalogue;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace jeamin.API.Controllers.Catalogue
{
    [Route("api/bank")]
    [ApiController]
    [Description("Danh sách ngân hàng")]
    [Authorize]
    public class BankController : BaseCatalogueController<Bank, BankModel, BankRequest, CatalogueSearch>
    {
        private readonly IConfiguration configuration;
        public BankController(IServiceProvider serviceProvider, ILogger<BaseCatalogueController<Bank, BankModel, BankRequest, CatalogueSearch>> logger, IWebHostEnvironment env, IConfiguration configuration) : base(serviceProvider, logger, env)
        {
            this.catalogueService = serviceProvider.GetRequiredService<IBankService>();
            this.configuration = configuration;
        }

        /// <summary>
        /// Thêm mới item
        /// </summary>
        /// <param name="itemModel"></param>
        /// <returns></returns>
        [HttpPost]
        [AppAuthorize(new int[] { CoreContants.AddNew })]
        public override async Task<AppDomainResult> AddItem([FromBody] BankRequest itemModel)
        {
            AppDomainResult appDomainResult = new AppDomainResult();

            bool success = false;
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(itemModel.Code))
                    itemModel.Code = AppUtilities.RemoveUnicode(itemModel.Name).ToLower().Replace(" ", "-");

                var item = mapper.Map<Bank>(itemModel);
                item.Created = DateTime.UtcNow.AddHours(7);
                item.CreatedBy = LoginContext.Instance.CurrentUser.UserName;
                item.Active = true;

                if (item != null)
                {

                    success = await this.catalogueService.CreateAsync(item);
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
                throw new AppException(ModelState.GetErrorMessage());

            return appDomainResult;
        }

        /// <summary>
        /// Cập nhật thông tin item
        /// </summary>
        /// <param name="itemModel"></param>
        /// <returns></returns>
        [HttpPut]
        [AppAuthorize(new int[] { CoreContants.Update })]
        public override async Task<AppDomainResult> UpdateItem([FromBody] BankRequest itemModel)
        {
            AppDomainResult appDomainResult = new AppDomainResult();

            bool success = false;
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(itemModel.Code))
                    itemModel.Code = AppUtilities.RemoveUnicode(itemModel.Name).ToLower().Replace(" ", "-");

                var item = mapper.Map<Bank>(itemModel);
                item.Updated = DateTime.UtcNow.AddHours(7);
                item.UpdatedBy = LoginContext.Instance.CurrentUser.UserName;


                if (item != null)
                {

                    success = await this.catalogueService.UpdateAsync(item);
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
                throw new AppException(ModelState.GetErrorMessage());

            return appDomainResult;
        }
    }
}
