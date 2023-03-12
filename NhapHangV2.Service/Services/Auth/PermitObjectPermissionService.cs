using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services;
using jeamin.Interface.UnitOfWork;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using jeamin.Service.Services.DomainServices;
using jeamin.Interface.Services.Auth;
using jeamin.Entities.Auth;

namespace jeamin.Service.Services.Auth
{
    public class PermitObjectPermissionService : DomainService<PermitObjectPermissions, BaseSearch>, IPermitObjectPermissionService
    {
        public PermitObjectPermissionService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
