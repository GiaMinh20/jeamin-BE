using jeamin.Entities.DomainEntities;
using jeamin.Interface.DbContext;
using jeamin.Interface.DbFactory;
using jeamin.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeamin.Service.Repository
{
    public class AppRepository<T> : DomainRepository<T>, IAppRepository<T> where T : Entities.DomainEntities.AppDomain
    {
        public AppRepository(IAppDbContext context) : base(context)
        {

        }

        public AppRepository(IDbContextFactory dbContextFactory) : base(dbContextFactory)
        {

        }
    }
}
