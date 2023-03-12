using jeamin.Entities.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeamin.Interface.Repository
{
    public interface ICatalogueRepository<T>: IDomainRepository<T> where T : AppDomainCatalogue
    {
        T GetByCode(string code);
    }
}
