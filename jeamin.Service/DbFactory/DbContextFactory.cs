using jeamin.Interface.DbContext;
using jeamin.Interface.DbFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Service.DbFactory
{
    public abstract class DbContextFactory : IDbContextFactory
    {
        public abstract IAppDbContext Create();
    }
}
