using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Request
{
    public class FeeSupportRequest : AppDomainRequest
    {
        public int? MainOrderId { get; set; }

        /// <summary>
        /// Tên phụ phí
        /// </summary>
        public string? SupportName { get; set; }

        /// <summary>
        /// Số tiền (VNĐ)
        /// </summary>
        public decimal? SupportInfoVND { get; set; }
    }
}
