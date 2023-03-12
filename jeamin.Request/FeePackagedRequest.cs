using jeamin.Request.Auth;
using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace jeamin.Request
{
    public class FeePackagedRequest : AppDomainRequest
    {
        /// <summary>
        /// Số ký ban đầu
        /// </summary>
        public decimal? InitialKg { get; set; }

        /// <summary>
        /// Số tiền ký ban đầu
        /// </summary>
        public decimal? FirstPrice { get; set; }

        /// <summary>
        /// Số tiền cộng thêm trên mỗi ký
        /// </summary>
        public decimal? NextPrice { get; set; }
    }
}
