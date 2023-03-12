using AutoMapper;
using jeamin.Entities;
using jeamin.Entities.DomainEntities;
using jeamin.Entities.Search;
using jeamin.Interface.Services;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;

namespace jeamin.Service.Services
{
    public class ToolConfigService : DomainService<ToolConfig, ToolConfigSearch>, IToolConfigService
    {
        public ToolConfigService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override string GetStoreProcName()
        {
            return "ToolConfigs_GetPagingData";
        }
    }
}
