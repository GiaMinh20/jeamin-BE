using jeamin.Request.Auth;
using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace jeamin.Request
{
    public class FeeCheckProductRequest : AppDomainRequest
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

        /// <summary>
        /// Tên loại
        /// </summary>
        public string? TypeName { get; set; }
    }
}
