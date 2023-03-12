using jeamin.Models.Auth;
using jeamin.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using static jeamin.Utilities.CoreContants;

namespace jeamin.Models
{
    public class FeePackagedModel : AppDomainModel
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
