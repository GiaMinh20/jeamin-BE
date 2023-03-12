using jeamin.Entities.Configuration;
using jeamin.Entities.DomainEntities;
using jeamin.Interface;
using jeamin.Interface.UnitOfWork;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using jeamin.Service.Services.DomainServices;
using jeamin.Interface.Services.Configuration;

namespace jeamin.Service.Services.Configurations
{
    public class OTPHistoryService : DomainService<OTPHistories, BaseSearch>, IOTPHistoryService
    {
        public OTPHistoryService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
