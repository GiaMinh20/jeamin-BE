using AutoMapper;
using Microsoft.EntityFrameworkCore;
using jeamin.Entities.Catalogue;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.Catalogue;
using jeamin.Interface.UnitOfWork;
using jeamin.Models.Catalogue;
using jeamin.Service.Services.DomainServices;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.Services.Catalogue
{
    public class MenuService : CatalogueService<Menu, CatalogueSearch>, IMenuService
    {
        public MenuService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<PagedList<MenuModel>> GetSubMenu(PagedList<MenuModel> dataList)
        {

            for(int i=0; i<dataList.Items.Count;)
            {
                if (dataList.Items[i].Parent == null || Convert.ToInt32(dataList.Items[i].Parent) == 0)
                {
                    var subMenus = await unitOfWork.Repository<Menu>().GetQueryable().Where(e => e.Parent == dataList.Items[i].Id && !e.Deleted).Select(e => new MenuModel()
                    {
                        Active = e.Active,
                        Code = e.Code,
                        Created = e.Created,
                        CreatedBy = e.CreatedBy,
                        Deleted = e.Deleted,
                        Description = e.Description,
                        Id = e.Id,
                        Link = e.Link,
                        Name = e.Name,
                        Position = e.Position,
                        Parent = e.Parent,
                        RowNumber = e.RowNumber,
                        Type = e.Type,
                        Updated = e.Updated,
                        UpdatedBy = e.UpdatedBy
                    }).ToListAsync();
                    dataList.Items[i].Children = subMenus;
                    i++;
                }
                else
                {
                    dataList.Items.RemoveAt(i);
                }
            }
            return dataList;
        }
    }
}
