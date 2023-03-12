using jeamin.Entities.Catalogue;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.DomainServices;
using jeamin.Models.Catalogue;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services.Catalogue
{
    public interface IMenuService : ICatalogueService<Menu, CatalogueSearch>
    {
        Task<PagedList<MenuModel>> GetSubMenu(PagedList<MenuModel> dataList);
    }
}
