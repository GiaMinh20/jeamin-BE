using AutoMapper;
using Microsoft.EntityFrameworkCore;
using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Entities.Search;
using jeamin.Interface.Services;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.Services
{
    public class PageService : DomainService<Page, PageSearch>, IPageService
    {
        public PageService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override string GetStoreProcName()
        {
            return "Page_GetPagingData";
        }

        public async Task<Page> GetByCodeAsync(string code)
        {
            var item = await Queryable.Where(e => e.Code == code && !e.Deleted).AsNoTracking().FirstOrDefaultAsync();
            if (item == null)
                return null;
            return item;
        }
    }
}
