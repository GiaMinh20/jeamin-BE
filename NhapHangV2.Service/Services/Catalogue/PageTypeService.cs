using AutoMapper;
using Microsoft.EntityFrameworkCore;
using jeamin.Entities.Catalogue;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.Catalogue;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.Services.Catalogue
{
    public class PageTypeService : DomainService<PageType, CatalogueSearch>, IPageTypeService
    {
        public PageTypeService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override string GetStoreProcName()
        {
            return "PageType_GetPagingData";
        }

        public override async Task<PageType> GetByIdAsync(int id)
        {
            var item = await Queryable.Where(e => e.Id == id && !e.Deleted).AsNoTracking().FirstOrDefaultAsync();
            if (item == null)
                return null;
            var page = await unitOfWork.Repository<Entities.Page>().GetQueryable().Where(e => e.PageTypeId == item.Id && !e.Deleted).OrderByDescending(o => o.Id).ToListAsync();
            if (page.Any())
                item.Pages = page;
            return item;
        }

        public async Task<PageType> GetByCodeAsync(string code)
        {
            var item = await Queryable.Where(e => e.Code == code && !e.Deleted).AsNoTracking().FirstOrDefaultAsync();
            if (item == null)
                return null;
            var page = await unitOfWork.Repository<Entities.Page>().GetQueryable().Where(e => e.PageTypeId == item.Id && !e.Deleted).OrderByDescending(o => o.Id).ToListAsync();
            if (page.Any())
                item.Pages = page;
            return item;
        }
    }
}
