using AutoMapper;
using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.Services
{
    public class AccountantOutStockPaymentService : DomainService<AccountantOutStockPayment, BaseSearch>, IAccountantOutStockPaymentService
    {
        public AccountantOutStockPaymentService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
