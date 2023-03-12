using AutoMapper;
using Microsoft.Extensions.Configuration;
using jeamin.Entities.Catalogue;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.Catalogue;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.Services.Catalogue
{
    public class NotificationTemplateService : CatalogueService<NotificationTemplate, CatalogueSearch>, INotificationTemplateService
    {
        public NotificationTemplateService(IAppUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration) : base(unitOfWork, mapper, configuration)
        {
        }
    }
}
