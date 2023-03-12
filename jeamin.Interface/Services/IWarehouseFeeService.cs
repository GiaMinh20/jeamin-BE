using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Entities.Search;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services
{
    public interface IWarehouseFeeService : IDomainService<WarehouseFee, WarehouseFeeSearch>
    {
    }
}
