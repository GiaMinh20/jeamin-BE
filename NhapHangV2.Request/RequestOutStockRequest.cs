using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Request
{
    public class RequestOutStockRequest : AppDomainRequest
    {
        public int? ExportRequestTurnId { get; set; }

        public int? SmallPackageId { get; set; }
    }
}
