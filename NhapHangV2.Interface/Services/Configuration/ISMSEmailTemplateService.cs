using jeamin.Entities;
using jeamin.Entities.Configuration;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeamin.Interface.Services.Configuration
{
    public interface ISMSEmailTemplateService : ICatalogueService<SMSEmailTemplates, CatalogueSearch>
    {
    }
}
