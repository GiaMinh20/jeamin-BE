using jeamin.Entities.DomainEntities;
using jeamin.Interface.DbContext;
using jeamin.Interface.DbFactory;
using jeamin.Interface.Repository;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeamin.Service
{
    public class AppUnitOfWork : UnitOfWork, IAppUnitOfWork
    {
        readonly IAppDbContext appDbContext;
        public AppUnitOfWork(IAppDbContext context) : base(context)
        {
            appDbContext = context;
        }
        public AppUnitOfWork(IDbContextFactory dbContextFactory) : base(dbContextFactory)
        {
            appDbContext = dbContextFactory.Create();
        }

        public override ICatalogueRepository<T> CatalogueRepository<T>()
        {
            return new CatalogueRepository<T>(appDbContext);
        }

        public override IDomainRepository<T> Repository<T>()
        {
            return new AppRepository<T>(appDbContext);
        }
    }
}
