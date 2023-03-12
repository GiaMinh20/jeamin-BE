using jeamin.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Models.Report
{
    public class MainOrderRealReportModel : AppDomainReportModel
    {
        /// <summary>
        /// Tổng tiền mua hàng thật (tệ)
        /// </summary>
        public decimal? MaxTotalPriceRealCNY { get; set; }
    }
}
