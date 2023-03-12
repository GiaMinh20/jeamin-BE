using jeamin.Entities.DomainEntities;
using jeamin.Entities;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jeamin.Entities.Search;

namespace jeamin.Interface.Services
{
    public interface IToolConfigService : IDomainService<ToolConfig, ToolConfigSearch>
    {
    }
}
