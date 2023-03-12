using jeamin.Entities.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace jeamin.Entities.Search
{
    public class UserInGroupSearch : CatalogueSearch
    {
        /// <summary>
        /// Id người dùng
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Nhóm người dùng
        /// </summary>
        public int? UserGroupId { get; set; }
    }
}
