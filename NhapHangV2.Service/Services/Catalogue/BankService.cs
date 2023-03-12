using AutoMapper;
using Microsoft.Data.SqlClient;
using jeamin.Entities.Catalogue;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.Catalogue;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.Services.Catalogue
{
    public class BankService : CatalogueService<Bank, CatalogueSearch>, IBankService
    {
        public BankService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            IsUseStore = true;
        }

        protected override string GetStoreProcName()
        {
            return "Bank_GetPagingData";
        }
    }
}
