using AutoMapper;
using jeamin.Service.Services.DomainServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.UnitOfWork;
using jeamin.Interface.Services.Auth;
using jeamin.Entities.Auth;

namespace jeamin.Service.Services.Auth
{
    public class PermissionService : CatalogueService<Permissions, CatalogueSearch>, IPermissionService
    {
        public PermissionService(IAppUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration) : base(unitOfWork, mapper, configuration)
        {
        }
    }
}
