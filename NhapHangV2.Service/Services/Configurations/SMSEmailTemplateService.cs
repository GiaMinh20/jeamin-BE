using jeamin.Entities;
using jeamin.Entities.Configuration;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.Configuration;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using jeamin.Utilities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace jeamin.Service.Services.Configurations
{
    public class SMSEmailTemplateService : CatalogueService<SMSEmailTemplates, CatalogueSearch>, ISMSEmailTemplateService
    {
        public SMSEmailTemplateService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
