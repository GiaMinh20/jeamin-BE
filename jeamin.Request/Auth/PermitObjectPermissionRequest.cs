using jeamin.Request.DomainRequests;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeamin.Request.Auth
{
    public class PermitObjectPermissionRequest : AppDomainRequest
    {
        /// <summary>
        /// Mã chức năng
        /// </summary>
        public int? PermitObjectId { get; set; }

        /// <summary>
        /// List quyền
        /// </summary>
        public string? Permissions { get; set; }

        /// <summary>
        /// Mã nhóm
        /// </summary>
        public int? UserGroupId { get; set; }
    }
}
