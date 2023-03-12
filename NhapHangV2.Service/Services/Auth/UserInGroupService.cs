using jeamin.Interface.UnitOfWork;
using AutoMapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using jeamin.Interface.Services.Auth;
using jeamin.Service.Services.DomainServices;
using jeamin.Entities.Search;
using jeamin.Entities.Auth;
using System.Linq.Dynamic.Core;
using jeamin.Entities;
using System.Collections;

namespace jeamin.Service.Services.Auth
{
    public class UserInGroupService : DomainService<UserInGroups, UserInGroupSearch>, IUserInGroupService
    {
        public UserInGroupService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override string GetStoreProcName()
        {
            return "UserInGroup_GetPagingData";
        }


        public async Task<IList<UserInGroups>> GetUserInGroupsByUserGroupId(int userGroupId)
        {
            var userInGroups = await this.GetAsync(x => !x.Deleted && x.Active && x.UserGroupId == userGroupId);
            if (userInGroups != null)
                return userInGroups;
            return null;
        }
    }
}
