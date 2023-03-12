using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services
{
    public interface IFeeCheckProductService : IDomainService<FeeCheckProduct, BaseSearch>
    {
        Task<FeeCheckProduct> GetFeeCheckByPriceAndAmount(decimal price, decimal amount);
    }
}
