using jeamin.Entities.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Repository
{
    public interface IAppCatalogueRepository<T> : ICatalogueRepository<T> where T : AppDomainCatalogue
    {

    }
}
