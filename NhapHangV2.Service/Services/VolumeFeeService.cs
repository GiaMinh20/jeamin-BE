using AutoMapper;
using jeamin.Entities;
using jeamin.Entities.Catalogue;
using jeamin.Entities.Search;
using jeamin.Interface.Services;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System.Threading.Tasks;

namespace jeamin.Service.Services
{
    public class VolumeFeeService : DomainService<VolumeFee, VolumeFeeSearch>, IVolumeFeeService
    {
        public VolumeFeeService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        protected override string GetStoreProcName()
        {
            return "VolumeFee_GetPagingData";
        }
        protected override string GetStoreProcNameGetById()
        {
            return "VolumeFee_GetById";
        }
    }
}
