using AutoMapper;
using Microsoft.EntityFrameworkCore;
using jeamin.Entities;
using jeamin.Entities.Auth;
using jeamin.Entities.Catalogue;
using jeamin.Entities.Search;
using jeamin.Interface.Services;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static jeamin.Utilities.CoreContants;

namespace jeamin.Service.Services
{
    public class NotificationService : DomainService<Notification, NoticationSearch>, INotificationService
    {
        public NotificationService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        protected override string GetStoreProcName()
        {
            return "Notification_GetPagingData";
        }
    }
}
