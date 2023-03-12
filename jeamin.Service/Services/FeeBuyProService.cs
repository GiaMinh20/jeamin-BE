using AutoMapper;
using Microsoft.Data.SqlClient;
using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.Services
{
    public class FeeBuyProService : DomainService<FeeBuyPro, BaseSearch>, IFeeBuyProService
    {
        public FeeBuyProService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override string GetStoreProcName()
        {
            return "FeeBuyPro_GetPagingData";
        }
    }
}
