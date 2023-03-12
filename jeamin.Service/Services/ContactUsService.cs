using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using jeamin.Entities;
using jeamin.Entities.Catalogue;
using jeamin.Entities.Search;
using jeamin.Extensions;
using jeamin.Interface.DbContext;
using jeamin.Interface.Services;
using jeamin.Interface.Services.Auth;
using jeamin.Interface.Services.Catalogue;
using jeamin.Interface.Services.Configuration;
using jeamin.Interface.UnitOfWork;
using jeamin.Request;
using jeamin.Service.Services.Auth;
using jeamin.Service.Services.Catalogue;
using jeamin.Service.Services.Configurations;
using jeamin.Service.Services.DomainServices;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static jeamin.Utilities.CoreContants;

namespace jeamin.Service.Services
{
    public class ContactUsService : DomainService<ContactUs, ContactUsSearch>, IContactUsService
    {
        protected readonly IAppDbContext Context;
        public ContactUsService(IServiceProvider serviceProvider, IAppUnitOfWork unitOfWork, IMapper mapper, IAppDbContext Context) : base(unitOfWork, mapper)
        {
            this.Context = Context;
        }
        protected override string GetStoreProcName()
        {
            return "ContactUs_GetPagingData";
        }

        public async Task<List<ContactUs>> UpdateListContactUs(List<int> contactUs)
        {
            using (var dbContextTransaction = Context.Database.BeginTransaction())
            {
                try
                {
                    List<ContactUs> contactUsList = new List<ContactUs>();
                    foreach (var item in contactUs)
                    {
                        var contact = unitOfWork.Repository<ContactUs>().GetQueryable().Where(x => x.Id == item).FirstOrDefault();
                        contact.Status = true;
                        unitOfWork.Repository<ContactUs>().Update(contact);
                        contactUsList.Add(contact);
                    }
                    await unitOfWork.SaveAsync();
                    await dbContextTransaction.CommitAsync();
                    return contactUsList;
                }
                catch (Exception ex)
                {
                    await dbContextTransaction.RollbackAsync();
                    throw new AppException(ex.Message);
                }
            }
        }
    }
}
