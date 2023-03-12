using jeamin.Interface.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.DbFactory
{
    public interface IDbContextFactory
    {
        IAppDbContext Create();
    }
}
