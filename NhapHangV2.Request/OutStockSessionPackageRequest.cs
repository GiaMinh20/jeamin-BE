using jeamin.Request.Auth;
using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace jeamin.Request
{
    public class OutStockSessionPackageRequest : AppDomainRequest
    {
        public int? OutStockSessionId { get; set; }

        public int? SmallPackageId { get; set; }

        /// <summary>
        /// Mã vận đơn
        /// </summary>
        public string? OrderTransactionCode { get; set; }

        /// <summary>
        /// Mã đơn mua hộ
        /// </summary>
        public string? MainOrderID { get; set; }

        /// <summary>
        /// Mã đơn ký gửi
        /// </summary>
        public string? TransportationID { get; set; }

        /// <summary>
        /// Ngày xuất kho
        /// </summary>
        public DateTime? DateOutStock { get; set; }
    }
}
