using jeamin.Interface.Services.Catalogue;
using jeamin.Models.Catalogue;
using jeamin.Utilities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace jeamin.BaseAPI.Controllers.Catalogue
{
    [ApiController]
    public abstract class CatalogueController : ControllerBase
    {
        protected IMapper mapper;
        protected IConfiguration configuration;

        public CatalogueController(IServiceProvider serviceProvider, IMapper mapper, IConfiguration configuration)
        {
            this.mapper = mapper;
            this.configuration = configuration;
        }

    }
}
