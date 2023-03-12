﻿using jeamin.Entities.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Entities.Search.Report
{
    public class MainOrderRevenueReportSearch : BaseSearch
    {
        /// <summary>
        /// 1: Thống kê doanh thu cho saler
        /// 2: Thống kê doanh thu cho đặt hàng
        /// </summary>
        public int Type { get; set; }
        
        /// <summary>
        /// Trạng thái
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Từ ngày
        /// </summary>
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// Đến ngày
        /// </summary>
        public DateTime? ToDate { get; set; }
    }
}
