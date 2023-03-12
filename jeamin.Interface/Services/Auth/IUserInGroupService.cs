using jeamin.Entities.Auth;
using jeamin.Entities.Search;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services.Auth
{
    public interface IUserInGroupService : IDomainService<UserInGroups, UserInGroupSearch>
    {
        Task<IList<UserInGroups>> GetUserInGroupsByUserGroupId(int userGroupId);
    }
}
