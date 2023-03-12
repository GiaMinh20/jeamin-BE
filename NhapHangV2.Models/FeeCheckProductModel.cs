using jeamin.Models.Auth;
using jeamin.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using static jeamin.Utilities.CoreContants;

namespace jeamin.Models
{
    public class FeeCheckProductModel : AppDomainModel
    {
        /// <summary>
        /// Số lượng từ
        /// </summary>
        public decimal? AmountFrom { get; set; }

        /// <summary>
        /// Số lượng đến
        /// </summary>
        public decimal? AmountTo { get; set; }

        /// <summary>
        /// Phí
        /// </summary>
        public decimal? Fee { get; set; }

        /// <summary>
        /// Loại
        /// </summary>
        public int? Type { get; set; }

        ///// <summary>
        ///// Tên loại
        ///// </summary>
        public string TypeName { get; set; }
    }
}
