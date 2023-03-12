using jeamin.Entities.Report;
using jeamin.Entities.Search.Report;
using jeamin.Interface.Services.DomainServices;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services.Report
{
    public interface IMainOrderReportService : IReportService<MainOrderReport, MainOrderReportSearch>
    {

        Task<List<MainOrderReportOverView>> GetRevenueOverview(MainOrderReportSearch baseSearch);

    }
}
