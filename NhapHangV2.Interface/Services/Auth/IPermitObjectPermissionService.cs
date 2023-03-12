using jeamin.Entities.Auth;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeamin.Interface.Services.Auth
{
    public interface IPermitObjectPermissionService : IDomainService<PermitObjectPermissions, BaseSearch>
    {
    }
}
