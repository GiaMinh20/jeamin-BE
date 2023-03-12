using jeamin.Entities.Auth;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services.Auth
{
    public interface IPermitObjectService : ICatalogueService<PermitObjects, CatalogueSearch>
    {
        Task<bool> UpdateAsyncUserGroupForPermitObject(List<UserGroupForPermitObject> itemModels);
    }
}
