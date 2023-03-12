using jeamin.Entities.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeamin.Entities.Search
{
    public class OutStockSessionSearch : BaseSearch
    {
        /// <summary>
        /// Trạng thái
        /// </summary>
        public int? Status { get; set; }

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
