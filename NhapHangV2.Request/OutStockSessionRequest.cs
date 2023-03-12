using jeamin.Request.Auth;
using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace jeamin.Request
{
    public class OutStockSessionRequest : AppDomainRequest
    {
        /// <summary>
        /// UID người nhập
        /// </summary>
        public int? UID { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        [StringLength(1000)]
        public string? Note { get; set; }

        /// <summary>
        /// Là đơn mua hộ
        /// </summary>
        public int? IsOutStockOrder { get; set; } = 0;

        /// <summary>
        /// Là đơn ký gửi
        /// </summary>
        public int? IsOutStockTrans { get; set; } = 0;

        public List<int>? SmallPackageIds { get; set; }
    }
}
