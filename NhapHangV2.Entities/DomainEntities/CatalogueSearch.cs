﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Entities.DomainEntities
{
    public class CatalogueSearch : BaseSearch
    {
        /// <summary>
        /// Active
        /// </summary>
        public bool? Active { set; get; }
    }
}
