using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Request.Catalogue
{
    public class CustomerBenefitsRequest : AppDomainCatalogueRequest
    {
        /// <summary>
        /// Hình ảnh
        /// </summary>
        public string? IMG { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        public string? Link { get; set; }

        /// <summary>
        /// Vị trí
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// 1. Cam kết, 2. Quyền lợi
        /// </summary>
        public int? ItemType { get; set; }
    }
}
