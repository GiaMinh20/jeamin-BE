using jeamin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services
{
    public interface IDashboardService
    {
        Task<List<Dashboard_GetTotalInWeek>> GetTotalInWeek();

        Task<List<Dashboard_GetItemInWeek>> GetItemInWeek();

        Task<List<Dashboard_GetPercentOrder>> GetPercentOrder();
    }
}
