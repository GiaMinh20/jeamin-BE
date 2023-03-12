using jeamin.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Models
{
    public class FeeBuyProModel : AppDomainModel
    {
        /// <summary>
        /// Giá từ
        /// </summary>
        public decimal? PriceFrom { get; set; }

        /// <summary>
        /// Giá đến
        /// </summary>
        public decimal? PriceTo { get; set; }

        /// <summary>
        /// Phần trăm
        /// </summary>
        public decimal? FeePercent { get; set; }
    }
}
