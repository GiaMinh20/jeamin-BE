﻿using jeamin.Entities.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Entities.Search
{
    public class ToolConfigSearch : BaseSearch
    {
        /// <summary>
        /// Site: 1: Taobao, 2: Tmall, 3: 1688
        /// </summary>
        public int Site { get; set; }
    }
}
