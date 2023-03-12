using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Request.Catalogue
{
    public class CustomerTalkRequest : AppDomainCatalogueRequest
    {
        /// <summary>
        /// Hình ảnh
        /// </summary>
        public string? IMG { get; set; }
    }
}
