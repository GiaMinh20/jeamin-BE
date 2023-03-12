﻿using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Request
{
    public class PayHelpRequest : AppDomainRequest
    {
        /// <summary>
        /// Ghi chú
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Trạng thái
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Chưa hoàn thiện
        /// </summary>
        public bool? IsComplete { get; set; }

        /// <summary>
        /// Tổng tiền
        /// </summary>
        public decimal? TotalPrice { get; set; }

        /// <summary>
        /// Tổng tiền (VNĐ)
        /// </summary>
        public decimal? TotalPriceVND { get; set; }

        /// <summary>
        /// Hóa đơn thanh toán hộ
        /// </summary>
        public List<PayHelpDetailRequest>? PayHelpDetails { get; set; }

        /// <summary>
        /// ID Saler
        /// </summary>
        public int? SalerID { get; set; }
    }
}
