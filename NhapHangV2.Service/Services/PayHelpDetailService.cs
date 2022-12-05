﻿using AutoMapper;
using NhapHangV2.Entities;
using NhapHangV2.Entities.DomainEntities;
using NhapHangV2.Interface.Services;
using NhapHangV2.Interface.UnitOfWork;
using NhapHangV2.Service.Services.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapHangV2.Service.Services
{
    public class PayHelpDetailService : DomainService<PayHelpDetail, BaseSearch>, IPayHelpDetailService
    {
        public PayHelpDetailService(IAppUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
