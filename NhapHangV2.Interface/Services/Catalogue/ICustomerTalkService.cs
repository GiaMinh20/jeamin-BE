﻿using jeamin.Entities.Catalogue;
using jeamin.Entities.DomainEntities;
using jeamin.Entities.Search;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services.Catalogue
{
    public interface ICustomerTalkService : ICatalogueService<CustomerTalk, CatalogueSearch>
    {
    }
}
