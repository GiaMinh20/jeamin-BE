using jeamin.Entities.Auth;
using jeamin.Entities.Search;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeamin.Interface.Services.Auth
{
    public interface IUserGroupService : ICatalogueService<UserGroups, UserInGroupSearch>
    {
    }
}
